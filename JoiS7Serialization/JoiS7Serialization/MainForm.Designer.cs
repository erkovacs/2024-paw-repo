namespace JoiS4WinFormsIntro
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbfirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddParticipant = new System.Windows.Forms.Button();
            this.lvParticipants = new System.Windows.Forms.ListView();
            this.colFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.writeToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbfirstName
            // 
            this.tbfirstName.Location = new System.Drawing.Point(118, 52);
            this.tbfirstName.Name = "tbfirstName";
            this.tbfirstName.Size = new System.Drawing.Size(279, 22);
            this.tbfirstName.TabIndex = 1;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(118, 93);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(279, 22);
            this.tbLastName.TabIndex = 2;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(118, 137);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(279, 22);
            this.dtpBirthDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Birth date";
            // 
            // btnAddParticipant
            // 
            this.btnAddParticipant.Location = new System.Drawing.Point(33, 189);
            this.btnAddParticipant.Name = "btnAddParticipant";
            this.btnAddParticipant.Size = new System.Drawing.Size(137, 23);
            this.btnAddParticipant.TabIndex = 7;
            this.btnAddParticipant.Text = "Add Participant";
            this.btnAddParticipant.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddParticipant.UseVisualStyleBackColor = true;
            this.btnAddParticipant.Click += new System.EventHandler(this.btnAddParticipant_Click);
            // 
            // lvParticipants
            // 
            this.lvParticipants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFirstName,
            this.colLastName,
            this.colBirthDate});
            this.lvParticipants.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvParticipants.FullRowSelect = true;
            this.lvParticipants.GridLines = true;
            this.lvParticipants.HideSelection = false;
            this.lvParticipants.Location = new System.Drawing.Point(33, 238);
            this.lvParticipants.Name = "lvParticipants";
            this.lvParticipants.Size = new System.Drawing.Size(606, 133);
            this.lvParticipants.TabIndex = 8;
            this.lvParticipants.UseCompatibleStateImageBehavior = false;
            this.lvParticipants.View = System.Windows.Forms.View.Details;
            // 
            // colFirstName
            // 
            this.colFirstName.Text = "First name";
            this.colFirstName.Width = 98;
            // 
            // colLastName
            // 
            this.colLastName.Text = "LastName";
            this.colLastName.Width = 100;
            // 
            // colBirthDate
            // 
            this.colBirthDate.Text = "Birth date";
            this.colBirthDate.Width = 130;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(186, 189);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit participant";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(330, 189);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(497, 189);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.writeToFileToolStripMenuItem,
            this.restoreFromFileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(668, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // writeToFileToolStripMenuItem
            // 
            this.writeToFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem,
            this.binaryToolStripMenuItem,
            this.cSVToolStripMenuItem});
            this.writeToFileToolStripMenuItem.Name = "writeToFileToolStripMenuItem";
            this.writeToFileToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.writeToFileToolStripMenuItem.Text = "Write to file";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            this.binaryToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.binaryToolStripMenuItem.Text = "Binary";
            this.binaryToolStripMenuItem.Click += new System.EventHandler(this.binaryToolStripMenuItem_Click);
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cSVToolStripMenuItem.Text = "CSV";
            this.cSVToolStripMenuItem.Click += new System.EventHandler(this.cSVToolStripMenuItem_Click);
            // 
            // restoreFromFileToolStripMenuItem
            // 
            this.restoreFromFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem1,
            this.binaryToolStripMenuItem1,
            this.cSVToolStripMenuItem1});
            this.restoreFromFileToolStripMenuItem.Name = "restoreFromFileToolStripMenuItem";
            this.restoreFromFileToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.restoreFromFileToolStripMenuItem.Text = "Restore from file";
            // 
            // xMLToolStripMenuItem1
            // 
            this.xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            this.xMLToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.xMLToolStripMenuItem1.Text = "XML";
            this.xMLToolStripMenuItem1.Click += new System.EventHandler(this.xMLToolStripMenuItem1_Click);
            // 
            // binaryToolStripMenuItem1
            // 
            this.binaryToolStripMenuItem1.Name = "binaryToolStripMenuItem1";
            this.binaryToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.binaryToolStripMenuItem1.Text = "Binary";
            this.binaryToolStripMenuItem1.Click += new System.EventHandler(this.binaryToolStripMenuItem1_Click);
            // 
            // cSVToolStripMenuItem1
            // 
            this.cSVToolStripMenuItem1.Name = "cSVToolStripMenuItem1";
            this.cSVToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.cSVToolStripMenuItem1.Text = "CSV";
            this.cSVToolStripMenuItem1.Click += new System.EventHandler(this.cSVToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 396);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lvParticipants);
            this.Controls.Add(this.btnAddParticipant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbfirstName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbfirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddParticipant;
        private System.Windows.Forms.ListView lvParticipants;
        private System.Windows.Forms.ColumnHeader colFirstName;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colBirthDate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem writeToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem1;
    }
}

