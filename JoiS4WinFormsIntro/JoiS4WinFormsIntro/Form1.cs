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
                tbfirstName.Text,
                tbLastName.Text,
                dtpBirthDate.Value);

            participants.Add(participant);

            tbfirstName.Text = tbLastName.Text = string.Empty;
            dtpBirthDate.Value = DateTime.Now;

            var item = new ListViewItem(participant.FirstName);
            item.SubItems.Add(participant.FirstName);
            item.SubItems.Add(participant.LastName);
            item.SubItems.Add(participant.BirthDate.ToString());
            lvParticipants.Items.Add(item);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            participants = new List<Participant>();
        }
    }
}
