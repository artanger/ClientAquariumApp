namespace ClientAquariumApp
{
    partial class NewJournalForm
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
            comboBoxFishTanks = new ComboBox();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtDescription = new RichTextBox();
            dateTimePicker = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            btnSaveJournal = new Button();
            listBoxAvailable = new ListBox();
            listBoxSelected = new ListBox();
            btnAdd = new Button();
            btnRemove = new Button();
            label5 = new Label();
            label6 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 103F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(comboBoxFishTanks, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(txtName, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 4);
            tableLayoutPanel1.Controls.Add(txtDescription, 0, 5);
            tableLayoutPanel1.Controls.Add(dateTimePicker, 0, 11);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 10);
            tableLayoutPanel1.Controls.Add(btnSaveJournal, 2, 18);
            tableLayoutPanel1.Controls.Add(listBoxAvailable, 0, 13);
            tableLayoutPanel1.Controls.Add(listBoxSelected, 2, 13);
            tableLayoutPanel1.Controls.Add(btnAdd, 1, 14);
            tableLayoutPanel1.Controls.Add(btnRemove, 1, 16);
            tableLayoutPanel1.Controls.Add(label5, 0, 12);
            tableLayoutPanel1.Controls.Add(label6, 2, 12);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 21;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(460, 683);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // comboBoxFishTanks
            // 
            comboBoxFishTanks.Dock = DockStyle.Fill;
            comboBoxFishTanks.FormattingEnabled = true;
            comboBoxFishTanks.Location = new Point(3, 38);
            comboBoxFishTanks.Name = "comboBoxFishTanks";
            comboBoxFishTanks.Size = new Size(174, 23);
            comboBoxFishTanks.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(0, 70);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 8, 0, 8);
            label1.Size = new Size(180, 35);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(txtName, 3);
            txtName.Location = new Point(3, 108);
            txtName.Name = "txtName";
            txtName.Size = new Size(450, 23);
            txtName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(0, 140);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 8, 0, 8);
            label2.Size = new Size(180, 35);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // txtDescription
            // 
            tableLayoutPanel1.SetColumnSpan(txtDescription, 3);
            txtDescription.Dock = DockStyle.Fill;
            txtDescription.Location = new Point(3, 178);
            txtDescription.Name = "txtDescription";
            tableLayoutPanel1.SetRowSpan(txtDescription, 5);
            txtDescription.Size = new Size(450, 169);
            txtDescription.TabIndex = 4;
            txtDescription.Text = "";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Dock = DockStyle.Fill;
            dateTimePicker.Location = new Point(3, 388);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(174, 23);
            dateTimePicker.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 8, 0, 8);
            label3.Size = new Size(180, 35);
            label3.TabIndex = 11;
            label3.Text = "Select Aquarium";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(0, 350);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 8, 0, 8);
            label4.Size = new Size(180, 35);
            label4.TabIndex = 12;
            label4.Text = "Select Date";
            // 
            // btnSaveJournal
            // 
            btnSaveJournal.Dock = DockStyle.Left;
            btnSaveJournal.Location = new Point(286, 623);
            btnSaveJournal.Name = "btnSaveJournal";
            btnSaveJournal.Size = new Size(165, 24);
            btnSaveJournal.TabIndex = 8;
            btnSaveJournal.Text = "Save Journal";
            btnSaveJournal.UseVisualStyleBackColor = true;
            btnSaveJournal.Click += btnSaveJournal_Click;
            // 
            // listBoxAvailable
            // 
            listBoxAvailable.Dock = DockStyle.Left;
            listBoxAvailable.FormattingEnabled = true;
            listBoxAvailable.ItemHeight = 15;
            listBoxAvailable.Location = new Point(3, 458);
            listBoxAvailable.Name = "listBoxAvailable";
            tableLayoutPanel1.SetRowSpan(listBoxAvailable, 5);
            listBoxAvailable.Size = new Size(174, 159);
            listBoxAvailable.TabIndex = 13;
            // 
            // listBoxSelected
            // 
            listBoxSelected.Dock = DockStyle.Left;
            listBoxSelected.FormattingEnabled = true;
            listBoxSelected.ItemHeight = 15;
            listBoxSelected.Location = new Point(286, 458);
            listBoxSelected.Name = "listBoxSelected";
            tableLayoutPanel1.SetRowSpan(listBoxSelected, 5);
            listBoxSelected.Size = new Size(165, 159);
            listBoxSelected.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.Location = new Point(199, 493);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(64, 29);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.None;
            btnRemove.Location = new Point(199, 563);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(64, 24);
            btnRemove.TabIndex = 16;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkOrchid;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(0, 420);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(180, 35);
            label5.TabIndex = 17;
            label5.Text = "Available";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Green;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(286, 420);
            label6.Name = "label6";
            label6.Size = new Size(167, 35);
            label6.TabIndex = 18;
            label6.Text = "Selected";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NewJournalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 683);
            Controls.Add(tableLayoutPanel1);
            Name = "NewJournalForm";
            Text = "NewJournalForm";
            Activated += NewJournalForm_Activated;
            Load += NewJournalForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox comboBoxFishTanks;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private RichTextBox txtDescription;
        private DateTimePicker dateTimePicker;
        private Button btnSaveJournal;
        private Label label3;
        private Label label4;
        private ListBox listBoxAvailable;
        private ListBox listBoxSelected;
        private Button btnAdd;
        private Button btnRemove;
        private Label label5;
        private Label label6;
    }
}