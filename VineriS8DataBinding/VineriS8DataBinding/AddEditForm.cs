using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VineriS6Validation.Entities;

namespace VineriS6Validation
{
    public partial class AddEditForm : Form
    {
        public Participant Participant { get; set; }
        public AddEditForm()
        {
            InitializeComponent();
        }

        public AddEditForm (Participant participant) : this()
        {
            Participant = participant;
        }

        private bool isValidString(string str)
        {
            return !String.IsNullOrWhiteSpace(str);
        }

        private bool isValidDate(DateTime dt)
        {
            var start = new DateTime(1900, 1, 1);
            var end = DateTime.Now;

            return start.CompareTo(dt) <= 0 && end.CompareTo(dt) >= 0;
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
            if (!ValidateChildren())
            {
                MessageBox.Show("Your form contains errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Participant != null)
            {
                Participant.FirstName = tbFirstName.Text;
                Participant.LastName = tbLastName.Text;
                Participant.BirthDate = dtpBirthDate.Value;
            }
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (!isValidString(tbFirstName.Text))
            {
                // e.Cancel = true;
                errorProvider.SetError(tbFirstName, "Invalid string!");
            }
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (!isValidString(tbLastName.Text))
            {
                //e.Cancel = true;
                errorProvider.SetError(tbLastName, "Invalid string!");
            }
        }

        private void dtpBirthDate_Validating(object sender, CancelEventArgs e)
        {
            if (!isValidDate(dtpBirthDate.Value))
            {
                //e.Cancel = true;
                errorProvider.SetError(dtpBirthDate, "Invalid date!");
            }
        }
    }
}
