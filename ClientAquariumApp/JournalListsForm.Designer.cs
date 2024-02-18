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
            textBoxSearchByName = new TextBox();
            comboBoxFishTank = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridViewJournals = new DataGridView();
            fromDateTimePicker = new DateTimePicker();
            toDateTimePicker = new DateTimePicker();
            searchButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewJournals).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 328F));
            tableLayoutPanel1.Controls.Add(textBoxSearchByName, 0, 1);
            tableLayoutPanel1.Controls.Add(comboBoxFishTank, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 1, 2);
            tableLayoutPanel1.Controls.Add(dataGridViewJournals, 0, 5);
            tableLayoutPanel1.Controls.Add(fromDateTimePicker, 0, 3);
            tableLayoutPanel1.Controls.Add(toDateTimePicker, 1, 3);
            tableLayoutPanel1.Controls.Add(searchButton, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 260F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
            tableLayoutPanel1.Size = new Size(643, 475);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxSearchByName
            // 
            textBoxSearchByName.Dock = DockStyle.Fill;
            textBoxSearchByName.Location = new Point(3, 38);
            textBoxSearchByName.Name = "textBoxSearchByName";
            textBoxSearchByName.Size = new Size(309, 23);
            textBoxSearchByName.TabIndex = 3;
            // 
            // comboBoxFishTank
            // 
            comboBoxFishTank.Dock = DockStyle.Fill;
            comboBoxFishTank.FormattingEnabled = true;
            comboBoxFishTank.Location = new Point(318, 38);
            comboBoxFishTank.Name = "comboBoxFishTank";
            comboBoxFishTank.Size = new Size(322, 23);
            comboBoxFishTank.TabIndex = 1;
            comboBoxFishTank.SelectedIndexChanged += ComboBoxFishTank_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(309, 35);
            label1.TabIndex = 4;
            label1.Text = "SearchbyName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(318, 0);
            label2.Name = "label2";
            label2.Size = new Size(322, 35);
            label2.TabIndex = 5;
            label2.Text = "Select Aquarium";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 70);
            label3.Name = "label3";
            label3.Size = new Size(309, 35);
            label3.TabIndex = 6;
            label3.Text = "From:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(318, 70);
            label4.Name = "label4";
            label4.Size = new Size(322, 35);
            label4.TabIndex = 7;
            label4.Text = "To:";
            // 
            // dataGridViewJournals
            // 
            dataGridViewJournals.AllowUserToAddRows = false;
            dataGridViewJournals.AllowUserToDeleteRows = false;
            dataGridViewJournals.AllowUserToResizeRows = false;
            dataGridViewJournals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridViewJournals, 2);
            dataGridViewJournals.Dock = DockStyle.Fill;
            dataGridViewJournals.Location = new Point(3, 178);
            dataGridViewJournals.MultiSelect = false;
            dataGridViewJournals.Name = "dataGridViewJournals";
            dataGridViewJournals.ReadOnly = true;
            dataGridViewJournals.RowTemplate.Height = 25;
            dataGridViewJournals.ScrollBars = ScrollBars.Vertical;
            dataGridViewJournals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewJournals.ShowCellErrors = false;
            dataGridViewJournals.ShowCellToolTips = false;
            dataGridViewJournals.ShowEditingIcon = false;
            dataGridViewJournals.Size = new Size(637, 254);
            dataGridViewJournals.TabIndex = 2;
            dataGridViewJournals.CellDoubleClick += dataGridViewJournals_CellDoubleClick;
            // 
            // fromDateTimePicker
            // 
            fromDateTimePicker.Location = new Point(3, 108);
            fromDateTimePicker.Name = "fromDateTimePicker";
            fromDateTimePicker.Size = new Size(200, 23);
            fromDateTimePicker.TabIndex = 8;
            // 
            // toDateTimePicker
            // 
            toDateTimePicker.Location = new Point(318, 108);
            toDateTimePicker.Name = "toDateTimePicker";
            toDateTimePicker.Size = new Size(200, 23);
            toDateTimePicker.TabIndex = 9;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(318, 438);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(322, 29);
            searchButton.TabIndex = 10;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // JournalListsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 475);
            Controls.Add(tableLayoutPanel1);
            Name = "JournalListsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JournalListsForm";
            Load += JournalListsForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewJournals).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox comboBoxFishTank;
        private TextBox textBoxSearchByName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridViewJournals;
        private DateTimePicker fromDateTimePicker;
        private DateTimePicker toDateTimePicker;
        private Button searchButton;
    }
}