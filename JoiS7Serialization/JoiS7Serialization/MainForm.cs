using JoiS4WinFormsIntro.Entities;
using JoiS6Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace JoiS4WinFormsIntro
{
    public partial class MainForm : Form
    {
        private string myValue = "\"";

        private List<Participant> participants;

        public MainForm()
        {
            InitializeComponent();
        }

        private void DisplayParticipants()
        {
            lvParticipants.Items.Clear();
            foreach (var participant in participants)
            {
                var item = new ListViewItem(participant.FirstName);
                item.SubItems.Add(participant.LastName);
                item.SubItems.Add(participant.BirthDate.ToString());
                item.Tag = participant;
                lvParticipants.Items.Add(item);
            }
        }

        private string SerializeCsv (List<Participant> participants)
        {
            var sb = new StringBuilder();
            sb.AppendLine("FirstName,LastName,BirthDate");
            foreach (var participant in participants) 
            {
                sb.AppendLine($"{participant.FirstName},{participant.LastName},{participant.BirthDate.ToLocalTime()}");
            }
            return sb.ToString();
        }

        private void ResetForm()
        {
            tbfirstName.Text = tbLastName.Text = string.Empty;
            dtpBirthDate.Value = DateTime.Now;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Hello world",
                "Message",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Exclamation);
        }

        private void demoButton_Click(object sender, EventArgs e)
        {
            var e2 = e as MouseEventArgs;
        }

        private void btnAddParticipant_Click(object sender, EventArgs e)
        {
            //var participant = new Participant(
            //    tbLastName.Text,
            //    tbfirstName.Text,
            //    dtpBirthDate.Value);
            var participant = new Participant();

            Form form = new AddEditForm(participant);
            if (form.ShowDialog() == DialogResult.OK) 
            {
                participants.Add(participant);

                ResetForm();
                DisplayParticipants();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            participants = new List<Participant>();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var item = lvParticipants.SelectedItems[0];
            var participant = item.Tag as Participant;
            if (participant != null)
            {
                tbfirstName.Text = participant.FirstName;
                tbLastName.Text = participant.LastName;
                dtpBirthDate.Value = participant.BirthDate;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lvParticipants.SelectedItems.Count > 0)
            {
                var item = lvParticipants.SelectedItems[0];
                var participant = item.Tag as Participant;
                if (participant != null)
                {
                    participant.FirstName = tbfirstName.Text;
                    participant.LastName = tbLastName.Text;
                    participant.BirthDate = dtpBirthDate.Value;

                    ResetForm();
                    DisplayParticipants();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to delete?",
                "Confirm deletion",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (lvParticipants.SelectedItems.Count > 0)
                {
                    var item = lvParticipants.SelectedItems[0];
                    var participant = item.Tag as Participant;

                    participants.Remove(participant);

                    DisplayParticipants();
                }
            }
        }

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.Create("serialized.bin"))
                formatter.Serialize(stream, participants);
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Participant>));
            using (FileStream stream = File.Create("SerializedXML.xml"))
                serializer.Serialize(stream, participants);
        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Participant>));
            using (FileStream stream = File.OpenRead("SerializedXML.xml"))
                participants = (List<Participant>)serializer.Deserialize(stream);
                DisplayParticipants();
        }

        private void binaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.OpenRead("serialized.bin"))
                participants = (List<Participant>)formatter.Deserialize(stream);
                DisplayParticipants();
        }

        private void cSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = saveFileDialog.FileName;
                var contents = SerializeCsv(participants);
                using (StreamWriter sw = File.CreateText(fileName))
                    sw.Write(contents);
            }
        }

        private void cSVToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                MessageBox.Show(fileName);

                // 1. Open file
                // 2. Read each line
                // 3. Split by ","
                // 4. Create a new Participant
                //     4.1. Value at index 0 = First Name
                //     4.2. Value at index 1 = Last Name
                //     4.3.Value at index 2 = Birth Date (you need to parse this!)
                // 5. Add Participant to List of Participants
            }
        }
    }
}
