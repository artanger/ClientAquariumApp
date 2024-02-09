namespace ClientAquariumApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainMenuStrip = new MenuStrip();
            journalToolStripMenuItem = new ToolStripMenuItem();
            listJlToolStripMenuItem = new ToolStripMenuItem();
            addJlToolStripMenuItem = new ToolStripMenuItem();
            catalogToolStripMenuItem = new ToolStripMenuItem();
            aquariumToolStripMenuItem = new ToolStripMenuItem();
            listAquaToolStripMenuItem = new ToolStripMenuItem();
            addAquaToolStripMenuItem = new ToolStripMenuItem();
            maintenanceToolStripMenuItem = new ToolStripMenuItem();
            listMtToolStripMenuItem = new ToolStripMenuItem();
            addMaintenanceToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            mainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { journalToolStripMenuItem, catalogToolStripMenuItem, aboutToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(909, 24);
            mainMenuStrip.TabIndex = 2;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // journalToolStripMenuItem
            // 
            journalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listJlToolStripMenuItem, addJlToolStripMenuItem });
            journalToolStripMenuItem.Name = "journalToolStripMenuItem";
            journalToolStripMenuItem.Size = new Size(57, 20);
            journalToolStripMenuItem.Text = "Journal";
            // 
            // listJlToolStripMenuItem
            // 
            listJlToolStripMenuItem.Name = "listJlToolStripMenuItem";
            listJlToolStripMenuItem.Size = new Size(138, 22);
            listJlToolStripMenuItem.Text = "Journal lists ";
            listJlToolStripMenuItem.Click += listJlToolStripMenuItem_Click;
            // 
            // addJlToolStripMenuItem
            // 
            addJlToolStripMenuItem.Name = "addJlToolStripMenuItem";
            addJlToolStripMenuItem.Size = new Size(138, 22);
            addJlToolStripMenuItem.Text = "Add";
            addJlToolStripMenuItem.Click += addJlToolStripMenuItem_Click;
            // 
            // catalogToolStripMenuItem
            // 
            catalogToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aquariumToolStripMenuItem, maintenanceToolStripMenuItem });
            catalogToolStripMenuItem.Name = "catalogToolStripMenuItem";
            catalogToolStripMenuItem.Size = new Size(60, 20);
            catalogToolStripMenuItem.Text = "Catalog";
            // 
            // aquariumToolStripMenuItem
            // 
            aquariumToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listAquaToolStripMenuItem, addAquaToolStripMenuItem });
            aquariumToolStripMenuItem.Name = "aquariumToolStripMenuItem";
            aquariumToolStripMenuItem.Size = new Size(180, 22);
            aquariumToolStripMenuItem.Text = "Aquarium";
            // 
            // listAquaToolStripMenuItem
            // 
            listAquaToolStripMenuItem.Name = "listAquaToolStripMenuItem";
            listAquaToolStripMenuItem.Size = new Size(96, 22);
            listAquaToolStripMenuItem.Text = "List";
            listAquaToolStripMenuItem.Click += listAquaToolStripMenuItem_Click;
            // 
            // addAquaToolStripMenuItem
            // 
            addAquaToolStripMenuItem.Name = "addAquaToolStripMenuItem";
            addAquaToolStripMenuItem.Size = new Size(96, 22);
            addAquaToolStripMenuItem.Text = "Add";
            addAquaToolStripMenuItem.Click += addAquaToolStripMenuItem_Click;
            // 
            // maintenanceToolStripMenuItem
            // 
            maintenanceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listMtToolStripMenuItem, addMaintenanceToolStripMenuItem });
            maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            maintenanceToolStripMenuItem.Size = new Size(180, 22);
            maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // listMtToolStripMenuItem
            // 
            listMtToolStripMenuItem.Name = "listMtToolStripMenuItem";
            listMtToolStripMenuItem.Size = new Size(180, 22);
            listMtToolStripMenuItem.Text = "List";
            listMtToolStripMenuItem.Click += listMtToolStripMenuItem_Click;
            // 
            // addMaintenanceToolStripMenuItem
            // 
            addMaintenanceToolStripMenuItem.Name = "addMaintenanceToolStripMenuItem";
            addMaintenanceToolStripMenuItem.Size = new Size(180, 22);
            addMaintenanceToolStripMenuItem.Text = "Add";
            addMaintenanceToolStripMenuItem.Click += addMaintenanceToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 666);
            Controls.Add(mainMenuStrip);
            IsMdiContainer = true;
            MainMenuStrip = mainMenuStrip;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void addJournalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem catalogToolStripMenuItem;
        private ToolStripMenuItem journalToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aquariumToolStripMenuItem;
        private ToolStripMenuItem maintenanceToolStripMenuItem;
        private ToolStripMenuItem listAquaToolStripMenuItem;
        private ToolStripMenuItem addAquaToolStripMenuItem;
        private ToolStripMenuItem listMtToolStripMenuItem;
        private ToolStripMenuItem addMaintenanceToolStripMenuItem;
        private ToolStripMenuItem listJlToolStripMenuItem;
        private ToolStripMenuItem addJlToolStripMenuItem;
    }
}