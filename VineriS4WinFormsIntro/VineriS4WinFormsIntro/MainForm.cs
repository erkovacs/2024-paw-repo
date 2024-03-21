using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //var participant = new Participant("kovacs", "erik", DateTime.Now);
            //participant.FirstName = "andrei";
            //MessageBox.Show("Participant: " + participant.FirstName);
        }

        private void btnAddParticipant_Click(object sender, EventArgs e)
        {
            var participant = new Participant(
                tbFirstName.Text, tbLastName.Text, 
                dateTimePicker1.Value);

            tbFirstName.Text = tbLastName.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;

            var lvi = new ListViewItem(participant.FirstName);
            lvi.SubItems.Add(participant.LastName);
            lvi.SubItems.Add(participant.BirthDate.ToString());
            lvParticipants.Items.Add(lvi);
        }
    }
}
