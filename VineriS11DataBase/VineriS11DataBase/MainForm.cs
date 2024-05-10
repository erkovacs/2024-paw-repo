using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VineriS4WinFormsIntro.Entities;

namespace VineriS4WinFormsIntro
{
    public partial class MainForm : Form
    {
        private const string ConnectionString = "Data Source=database.sqlite";
        List<Participant> participants;


        public MainForm()
        {
            InitializeComponent();
            participants = new List<Participant>();
        }

        private void DisplayParticipants()
        {
            lvParticipants.Items.Clear();
            foreach (var participant in participants)
            {
                var lvi = new ListViewItem(participant.FirstName);
                lvi.SubItems.Add(participant.LastName);
                lvi.SubItems.Add(participant.BirthDate.ToString());
                lvi.Tag = participant;
                lvParticipants.Items.Add(lvi);
            }
        }

        // Insert / Create
        private void AddParticipant(Participant participant)
        {
            string query = "INSERT INTO Participant (FirstName, LastName, BirthDate) " + 
                "VALUES (\"" + participant.FirstName + "\",\"" + participant.LastName + "\",\"" +
                participant.BirthDate + "\"); SELECT last_insert_rowid()"; // prone to sql injection!

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                long id = (long)command.ExecuteScalar();
                participant.Id = (int)id;
                participants.Add(participant);
            }
        }

        // Select / Read
        private void ReadParticipants()
        {
            participants.Clear();
            
            string query = "SELECT * FROM Participant;";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);

                using (SQLiteDataReader reader = command.ExecuteReader()) 
                {
                   while (reader.Read()) 
                   {
                        long id = (long)reader["Id"];
                        string firstName = (string)reader["FirstName"];
                        string lastName = (string)reader["LastName"];
                        DateTime birthDate = DateTime.Parse((string)reader["BirthDate"]);
                        var participant = new Participant(lastName, firstName, birthDate);
                        participant.Id = (int)id;
                        participants.Add(participant);
                   }
                }
            }
        }

        // Delete
        private void DeleteParticipant(int id)
        {
            string query = "DELETE FROM Participant WHERE Id = @Id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }

        private void ClearForm() 
        {
            tbId.Text = tbFirstName.Text = tbLastName.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnAddParticipant_Click(object sender, EventArgs e)
        {
            var participant = new Participant(
                tbFirstName.Text, tbLastName.Text, 
                dateTimePicker1.Value);

            tbFirstName.Text = tbLastName.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;

            AddParticipant(participant);
            DisplayParticipants();

            ClearForm();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ReadParticipants();
            DisplayParticipants();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvParticipants.SelectedItems.Count > 0)
            {
                Participant participant = lvParticipants.SelectedItems[0].Tag as Participant;
                DeleteParticipant(participant.Id);
                ReadParticipants();
                DisplayParticipants();
                ClearForm();
            }
        }

        private void lvParticipants_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvParticipants.SelectedItems.Count > 0)
            {
                Participant participant = lvParticipants.SelectedItems[0].Tag as Participant;
                tbId.Text = participant.Id.ToString();
                tbFirstName.Text = participant.FirstName.ToString();
                tbLastName.Text = participant.LastName.ToString();
                dateTimePicker1.Value = participant.BirthDate;
            }
        }
    }
}
