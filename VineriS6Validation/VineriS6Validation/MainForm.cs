using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VineriS6Validation;
using VineriS6Validation.Entities;

namespace VineriS6Validation
{
    public partial class MainForm : Form
    {
        private List<Participant> participants;
        public MainForm()
        {
            InitializeComponent();
        }

        private void DisplayParticipants()
        {
            lvParticipants.Items.Clear();
            foreach (var _participant in participants)
            {
                var lvi = new ListViewItem(_participant.FirstName);
                lvi.SubItems.Add(_participant.LastName);
                lvi.SubItems.Add(_participant.BirthDate.ToString());
                lvi.Tag = _participant;
                lvParticipants.Items.Add(lvi);
            }
        }

        private void ResetForm()
        {
            tbFirstName.Text = tbLastName.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnAddParticipant_Click(object sender, EventArgs e)
        {
            var participant = new Participant();

            AddEditForm form = new AddEditForm();
            form.Participant = participant;
            if (form.ShowDialog() == DialogResult.OK)
            {
                participants.Add(participant);
            }

            ResetForm();
            DisplayParticipants();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            participants = new List<Participant>();
        }

        private void lvParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvParticipants.SelectedItems.Count > 0)
            {
                var participant = lvParticipants.SelectedItems[0].Tag as Participant;

                AddEditForm form = new AddEditForm(participant);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ResetForm();
                    DisplayParticipants();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lvParticipants.SelectedItems.Count > 0)
            { 
                var participant = lvParticipants.SelectedItems[0].Tag as Participant;

                participant.FirstName = tbFirstName.Text;
                participant.LastName = tbLastName.Text;
                participant.BirthDate = dateTimePicker1.Value;

                ResetForm();
                DisplayParticipants();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvParticipants.SelectedItems.Count > 0)
            {
                var participant = lvParticipants.SelectedItems[0].Tag as Participant;

                participants.Remove(participant);

                ResetForm();
                DisplayParticipants();
            }
        }
    }
}
