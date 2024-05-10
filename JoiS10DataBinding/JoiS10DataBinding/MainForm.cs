using JoiS10DataBinding;
using JoiS4WinFormsIntro.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoiS4WinFormsIntro
{
    public partial class MainForm : Form
    {
        private readonly MainFormViewModel _viewModel;

        public MainForm()
        {
            InitializeComponent();
            _viewModel = new MainFormViewModel();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void demoButton_Click(object sender, EventArgs e)
        {
        }

        private void btnAddParticipant_Click(object sender, EventArgs e)
        {
            _viewModel.AddParticipant();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvParticipants.DataSource = _viewModel.Participants;
            tbLastName.DataBindings.Add(nameof(TextBox.Text), _viewModel, nameof(MainFormViewModel.LastName));
            tbfirstName.DataBindings.Add("Text", _viewModel, "FirstName");
            dtpBirthDate.DataBindings.Add("Value", _viewModel, "BirthDate");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        }

        private string SerializeCsv(BindingList<Participant> participants)
        {
            var sb = new StringBuilder();
            sb.AppendLine("FirstName,LastName,BirthDate");
            foreach (var participant in participants)
            {
                sb.AppendLine($"{participant.FirstName},{participant.LastName},{participant.BirthDate.ToLocalTime()}");
            }
            return sb.ToString();
        }

        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = saveFileDialog.FileName;
                var contents = SerializeCsv(_viewModel.Participants);
                using (StreamWriter sw = File.CreateText(fileName))
                    sw.Write(contents);
            }
        }
    }
}
