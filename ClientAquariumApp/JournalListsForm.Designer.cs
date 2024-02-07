namespace ClientAquariumApp
{
    partial class JournalListsForm
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
            dataGridViewJournals = new DataGridView();
            comboBoxFishTank = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewJournals).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.Controls.Add(dataGridViewJournals, 0, 0);
            tableLayoutPanel1.Controls.Add(comboBoxFishTank, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewJournals
            // 
            dataGridViewJournals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewJournals.Dock = DockStyle.Fill;
            dataGridViewJournals.Location = new Point(3, 3);
            dataGridViewJournals.Name = "dataGridViewJournals";
            tableLayoutPanel1.SetRowSpan(dataGridViewJournals, 2);
            dataGridViewJournals.RowTemplate.Height = 25;
            dataGridViewJournals.Size = new Size(574, 444);
            dataGridViewJournals.TabIndex = 0;
            // 
            // comboBoxFishTank
            // 
            comboBoxFishTank.Dock = DockStyle.Fill;
            comboBoxFishTank.FormattingEnabled = true;
            comboBoxFishTank.Location = new Point(583, 3);
            comboBoxFishTank.Name = "comboBoxFishTank";
            comboBoxFishTank.Size = new Size(214, 23);
            comboBoxFishTank.TabIndex = 1;
            // 
            // JournalListsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "JournalListsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JournalListsForm";
            Load += JournalListsForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewJournals).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridViewJournals;
        private ComboBox comboBoxFishTank;
    }
}