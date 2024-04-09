using ST01_2_1071_Kovacs_Erik.Entities;
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

namespace ST01_2_1071_Kovacs_Erik
{
    public partial class MainForm : Form
    {
        private Fleet Fleet { get; set; }
        public MainForm()
        {
            Fleet = new Fleet();
            InitializeComponent();
        }

        private void DisplayTrucks () 
        {
            lvTrucks.Items.Clear();
            Fleet.Trucks.Sort();
            foreach (var truck in Fleet.Trucks)
            {
                ListViewItem lvi = new ListViewItem(truck.Id.ToString());
                lvi.SubItems.Add(truck.LicencePlateNumber);
                lvi.SubItems.Add(truck.RegistrationDate.ToString());
                lvi.Tag = truck;
                lvTrucks.Items.Add(lvi);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditForm form = new AddEditForm();
            Truck truck = new Truck();
            form.Truck = truck;
            if (form.ShowDialog() == DialogResult.OK) 
            {
                Fleet.Trucks.Add(truck);
                DisplayTrucks();
            }
        }

        private void lvTrucks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddEditForm form = new AddEditForm();
            if (lvTrucks.SelectedItems.Count == 1)
            {
                Truck truck = lvTrucks.SelectedItems[0].Tag as Truck;
                form.Truck = truck;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DisplayTrucks();
                }
            }
        }

        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.Create(sfd.FileName))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, Fleet);
                }
            }
        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.OpenRead(ofd.FileName))
                { 
                    BinaryFormatter bf = new BinaryFormatter();
                    Fleet = (Fleet)bf.Deserialize(fs);
                    DisplayTrucks();
                }
            }
        }
    }
}
