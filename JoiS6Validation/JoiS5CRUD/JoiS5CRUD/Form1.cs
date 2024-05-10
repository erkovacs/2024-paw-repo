using JoiS4WinFormsIntro.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoiS4WinFormsIntro
{
    public partial class Form1 : Form
    {
        private List<Participant> participants;

        public Form1()
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

            if (result == DialogResult.OK)
            {
                myTextBox.Text += "User clicked OK!\n";
            }
            else
            {
                myTextBox.Text += "User clicked another button!\n";
            }
        }

        private void demoButton_Click(object sender, EventArgs e)
        {
            var e2 = e as MouseEventArgs;
            myTextBox.Text += "Clicked P=" + e2.X + ", " + e2.Y;
        }

        private void btnAddParticipant_Click(object sender, EventArgs e)
        {
            var participant = new Participant(
                tbLastName.Text,
                tbfirstName.Text,
                dtpBirthDate.Value);

            participants.Add(participant);

            ResetForm();
            DisplayParticipants();
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
    }
}
