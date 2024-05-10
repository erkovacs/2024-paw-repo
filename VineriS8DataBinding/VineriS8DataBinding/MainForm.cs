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
using VineriS6Validation;
using VineriS6Validation.Entities;
using VineriS8DataBinding;

namespace VineriS6Validation
{
    public partial class MainForm : Form
    {
        private MainFormViewModel mainFormViewModel;
        // private List<Participant> participants;


        public MainForm()
        {
            InitializeComponent();
            mainFormViewModel = new MainFormViewModel();
        }

        //private void DisplayParticipants()
        //{
        //    lvParticipants.Items.Clear();
        //    foreach (var _participant in participants)
        //    {
        //        var lvi = new ListViewItem(_participant.FirstName);
        //        lvi.SubItems.Add(_participant.LastName);
        //        lvi.SubItems.Add(_participant.BirthDate.ToString());
        //        lvi.Tag = _participant;
        //        lvParticipants.Items.Add(lvi);
        //    }
        //}

        private void ResetForm()
        {
            tbFirstName.Text = tbLastName.Text = string.Empty;
            dtpBirthDate.Value = DateTime.Now;
        }

        private void btnAddParticipant_Click(object sender, EventArgs e)
        {
            mainFormViewModel.AddParticipant();
            //var participant = new Participant();

            //AddEditForm form = new AddEditForm();
            //form.Participant = participant;
            ////if (form.ShowDialog() == DialogResult.OK)
            ////{
            ////    participants.Add(participant);
            ////}

            //ResetForm();
            ////DisplayParticipants();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvParticipants.DataSource = mainFormViewModel.Participants;

            tbFirstName.DataBindings.Add("Text", mainFormViewModel, "FirstName");
            tbLastName.DataBindings.Add("Text", mainFormViewModel, "LastName");
            dtpBirthDate.DataBindings.Add("Value", mainFormViewModel, "BirthDate");
        }

        private void lvParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lvParticipants.SelectedItems.Count > 0)
            //{
            //    var participant = lvParticipants.SelectedItems[0].Tag as Participant;

            //    AddEditForm form = new AddEditForm(participant);
            //    if (form.ShowDialog() == DialogResult.OK)
            //    {
            //        ResetForm();
            //        //DisplayParticipants();
            //    }
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (lvParticipants.SelectedItems.Count > 0)
            //{ 
            //    var participant = lvParticipants.SelectedItems[0].Tag as Participant;

            //    participant.FirstName = tbFirstName.Text;
            //    participant.LastName = tbLastName.Text;
            //    participant.BirthDate = dateTimePicker1.Value;

            //    ResetForm();
            //   // DisplayParticipants();
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (lvParticipants.SelectedItems.Count > 0)
            //{
            //    var participant = lvParticipants.SelectedItems[0].Tag as Participant;

            //    participants.Remove(participant);

            //    ResetForm();
            //    //DisplayParticipants();
            //}
        }

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //BinaryFormatter formatter = new BinaryFormatter();
            //using (FileStream stream = File.Create("serialized.bin"))
                //formatter.Serialize(stream, participants);
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Participant>));
            using (FileStream stream = File.Create("serialized.xml"))
            {
                //serializer.Serialize(stream, participants);
            }
        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //XmlSerializer serializer = new XmlSerializer(typeof(List<Participant>));
            //using (FileStream stream = File.OpenRead("serialized.xml"))
                // participants = (List<Participant>)serializer.Deserialize(stream);
                //DisplayParticipants();
        }

        private void binaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //BinaryFormatter formatter = new BinaryFormatter();
            //using (FileStream stream = File.OpenRead("serialized.bin"))
                // participants = (List<Participant>)formatter.Deserialize(stream);
                //DisplayParticipants();
        }

        private void cSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine("FirstName,LastName,BirthDate");
            //foreach (Participant participant in participants)
            //{
            //    sb.AppendLine($"{participant.FirstName},{participant.LastName},{participant.BirthDate.ToString()}");
            //}

            //using (StreamWriter sw = File.CreateText("serialized.csv"))
            //    sw.Write(sb.ToString());
        }
    }
}
