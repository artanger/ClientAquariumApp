namespace ClientAquariumApp
{
    partial class MaintenanceListForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridViewMaintenanceTypes = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaintenanceTypes).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dataGridViewMaintenanceTypes, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(712, 418);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewMaintenanceTypes
            // 
            dataGridViewMaintenanceTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridViewMaintenanceTypes, 2);
            dataGridViewMaintenanceTypes.Dock = DockStyle.Fill;
            dataGridViewMaintenanceTypes.Location = new Point(3, 63);
            dataGridViewMaintenanceTypes.Name = "dataGridViewMaintenanceTypes";
            dataGridViewMaintenanceTypes.RowTemplate.Height = 25;
            dataGridViewMaintenanceTypes.Size = new Size(706, 352);
            dataGridViewMaintenanceTypes.TabIndex = 0;
            dataGridViewMaintenanceTypes.CellContentClick += dataGridViewMaintenanceTypes_CellContentClick;
            // 
            // MaintenanceListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 418);
            Controls.Add(tableLayoutPanel1);
            Name = "MaintenanceListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MaintenanceListForm";
            Load += MaintenanceListForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaintenanceTypes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridViewMaintenanceTypes;
    }
}