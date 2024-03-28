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

namespace JoiS6Validation
{
    public partial class AddEditForm : Form
    {
        public Participant Participant;

        public AddEditForm()
        {
            InitializeComponent();
        }

        public AddEditForm(Participant participant) : this()
        {
            if (participant == null) 
            {
                throw new ArgumentNullException("Participant is null!");
            }
            Participant = participant;
        }

        private bool IsValidString(string str) 
        {
            if (String.IsNullOrEmpty(str))
            {
                return false;
            }
            else if (String.IsNullOrWhiteSpace(str)) 
            {
                return false;
            }
            return true;
        }

        private bool isValidDate(DateTime dt) 
        {
            var start = new DateTime(1990, 1, 1);
            var end = DateTime.Now;
            if (dt.CompareTo(start) >= 0 && dt.CompareTo(end) <= 0)  
            { 
                return true;
            }
            return false;
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
            if (Participant != null)
            {
                tbFirstName.Text = Participant.FirstName;
                tbLastName.Text = Participant.LastName;
                dtpBirthDate.Value = Participant.BirthDate;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Participant != null)
            {
                Participant.FirstName = tbFirstName.Text;
                Participant.LastName = tbLastName.Text;
                Participant.BirthDate = dtpBirthDate.Value;
            }
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidString(tbFirstName.Text))
            {
                e.Cancel = true;
                errorProvider.SetError((TextBox)sender, "Invalid string provided!");
                MessageBox.Show("Invalid string provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidString(tbLastName.Text))
            {
                e.Cancel = true;
                errorProvider.SetError((TextBox)sender, "Invalid string provided!");
            }
        }

        private void dtpBirthDate_Validating(object sender, CancelEventArgs e)
        {
            if (!isValidDate(dtpBirthDate.Value)) 
            {
                e.Cancel = true;
                errorProvider.SetError((DateTimePicker)sender, "Invalid date provided!");
            }
        }
    }
}
