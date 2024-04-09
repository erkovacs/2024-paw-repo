using ST01_2_1071_Kovacs_Erik.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST01_2_1071_Kovacs_Erik
{
    public partial class AddEditForm : Form
    {
        public Truck Truck { get; set; }
        public AddEditForm()
        {
            InitializeComponent();
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
            if (Truck != null)
            {
                nudId.Value = Truck.Id;
                tbLicencePlateNumber.Text = Truck.LicencePlateNumber;
                dtpRegistrationDate.Value = Truck.RegistrationDate;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Truck != null)
            {
                Truck.Id = (int)nudId.Value;
                Truck.LicencePlateNumber = tbLicencePlateNumber.Text;
                Truck.RegistrationDate = dtpRegistrationDate.Value;
            }
        }

        private void tbLicencePlateNumber_Validating(object sender, CancelEventArgs e)
        {
            if (tbLicencePlateNumber.Text.Length < 6 || tbLicencePlateNumber.Text.Length > 9)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbLicencePlateNumber, "Invalid licence plate number!");
            }
        }
    }
}
