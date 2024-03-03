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
            label3 = new Label();
            txtDescription = new RichTextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            comboBoxSelectAquarium = new ComboBox();
            SelectDate = new Label();
            dateTimePicker1 = new DateTimePicker();
            listBoxAvailable = new ListBox();
            listBoxSelected = new ListBox();
            label4 = new Label();
            label5 = new Label();
            btnSaveJournal = new Button();
            btnAdd = new Button();
            btnRemove = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(txtDescription, 0, 5);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(txtName, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(comboBoxSelectAquarium, 0, 3);
            tableLayoutPanel1.Controls.Add(SelectDate, 0, 8);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 0, 9);
            tableLayoutPanel1.Controls.Add(listBoxAvailable, 0, 11);
            tableLayoutPanel1.Controls.Add(listBoxSelected, 2, 11);
            tableLayoutPanel1.Controls.Add(label4, 0, 10);
            tableLayoutPanel1.Controls.Add(label5, 2, 10);
            tableLayoutPanel1.Controls.Add(btnSaveJournal, 2, 17);
            tableLayoutPanel1.Controls.Add(btnAdd, 1, 12);
            tableLayoutPanel1.Controls.Add(btnRemove, 1, 14);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 18;
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(542, 677);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 140);
            label3.Name = "label3";
            label3.Size = new Size(208, 35);
            label3.TabIndex = 4;
            label3.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Dock = DockStyle.Fill;
            txtDescription.Location = new Point(3, 178);
            txtDescription.Name = "txtDescription";
            tableLayoutPanel1.SetRowSpan(txtDescription, 3);
            txtDescription.Size = new Size(208, 99);
            txtDescription.TabIndex = 5;
            txtDescription.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(208, 35);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(3, 38);
            txtName.Name = "txtName";
            txtName.Size = new Size(208, 23);
            txtName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 70);
            label1.Name = "label1";
            label1.Size = new Size(208, 35);
            label1.TabIndex = 0;
            label1.Text = "Select Aquarium";
            // 
            // comboBoxSelectAquarium
            // 
            comboBoxSelectAquarium.Dock = DockStyle.Fill;
            comboBoxSelectAquarium.FormattingEnabled = true;
            comboBoxSelectAquarium.Location = new Point(3, 108);
            comboBoxSelectAquarium.Name = "comboBoxSelectAquarium";
            comboBoxSelectAquarium.Size = new Size(208, 23);
            comboBoxSelectAquarium.TabIndex = 1;
            // 
            // SelectDate
            // 
            SelectDate.AutoSize = true;
            SelectDate.Dock = DockStyle.Fill;
            SelectDate.Location = new Point(3, 280);
            SelectDate.Name = "SelectDate";
            SelectDate.Size = new Size(208, 35);
            SelectDate.TabIndex = 6;
            SelectDate.Text = "SelectDate";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarTitleForeColor = Color.AliceBlue;
            dateTimePicker1.Dock = DockStyle.Fill;
            dateTimePicker1.Location = new Point(3, 318);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(208, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // listBoxAvailable
            // 
            listBoxAvailable.Dock = DockStyle.Fill;
            listBoxAvailable.FormattingEnabled = true;
            listBoxAvailable.ItemHeight = 15;
            listBoxAvailable.Location = new Point(3, 388);
            listBoxAvailable.Name = "listBoxAvailable";
            tableLayoutPanel1.SetRowSpan(listBoxAvailable, 5);
            listBoxAvailable.Size = new Size(208, 169);
            listBoxAvailable.TabIndex = 8;
            // 
            // listBoxSelected
            // 
            listBoxSelected.Dock = DockStyle.Fill;
            listBoxSelected.FormattingEnabled = true;
            listBoxSelected.ItemHeight = 15;
            listBoxSelected.Location = new Point(331, 388);
            listBoxSelected.Name = "listBoxSelected";
            tableLayoutPanel1.SetRowSpan(listBoxSelected, 5);
            listBoxSelected.Size = new Size(208, 169);
            listBoxSelected.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 350);
            label4.Name = "label4";
            label4.Size = new Size(208, 35);
            label4.TabIndex = 10;
            label4.Text = "Available";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(331, 350);
            label5.Name = "label5";
            label5.Size = new Size(208, 35);
            label5.TabIndex = 11;
            label5.Text = "Selected";
            // 
            // btnSaveJournal
            // 
            btnSaveJournal.Dock = DockStyle.Fill;
            btnSaveJournal.Location = new Point(331, 598);
            btnSaveJournal.Name = "btnSaveJournal";
            btnSaveJournal.Size = new Size(208, 76);
            btnSaveJournal.TabIndex = 12;
            btnSaveJournal.Text = "Save";
            btnSaveJournal.UseVisualStyleBackColor = true;
            btnSaveJournal.Click += btnSaveJournal_Click;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Location = new Point(217, 423);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(108, 29);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Dock = DockStyle.Fill;
            btnRemove.Location = new Point(217, 493);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(108, 29);
            btnRemove.TabIndex = 14;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // EditJournalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 677);
            Controls.Add(tableLayoutPanel1);
            Name = "EditJournalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditJournalForm";
            Load += EditJournalForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private ComboBox comboBoxSelectAquarium;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private RichTextBox txtDescription;
        private Label SelectDate;
        private DateTimePicker dateTimePicker1;
        private ListBox listBoxAvailable;
        private ListBox listBoxSelected;
        private Label label4;
        private Label label5;
        private Button btnSaveJournal;
        private Button btnAdd;
        private Button btnRemove;
    }
}