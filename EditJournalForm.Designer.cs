namespace ClientAquariumApp
{
    partial class EditJournalForm
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
            label1 = new Label();
            comboBoxSelectAquarium = new ComboBox();
            dataGridViewJournals = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewJournals).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.75F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.25F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(comboBoxSelectAquarium, 0, 1);
            tableLayoutPanel1.Controls.Add(dataGridViewJournals, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 8, 0, 0);
            label1.Size = new Size(94, 35);
            label1.TabIndex = 0;
            label1.Text = "Select Aquarium";
            // 
            // comboBoxSelectAquarium
            // 
            comboBoxSelectAquarium.Dock = DockStyle.Left;
            comboBoxSelectAquarium.FormattingEnabled = true;
            comboBoxSelectAquarium.Location = new Point(0, 43);
            comboBoxSelectAquarium.Margin = new Padding(0, 8, 0, 8);
            comboBoxSelectAquarium.Name = "comboBoxSelectAquarium";
            comboBoxSelectAquarium.Size = new Size(211, 23);
            comboBoxSelectAquarium.TabIndex = 1;
            // 
            // dataGridViewJournals
            // 
            dataGridViewJournals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewJournals.Location = new Point(3, 73);
            dataGridViewJournals.Name = "dataGridViewJournals";
            dataGridViewJournals.RowTemplate.Height = 25;
            dataGridViewJournals.Size = new Size(552, 237);
            dataGridViewJournals.TabIndex = 2;
            // 
            // EditJournalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "EditJournalForm";
            Text = "EditJournalForm";
            Load += EditJournalForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewJournals).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private ComboBox comboBoxSelectAquarium;
        private DataGridView dataGridViewJournals;
    }
}