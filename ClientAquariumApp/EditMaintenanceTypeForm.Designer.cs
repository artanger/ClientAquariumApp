namespace ClientAquariumApp
{
    partial class EditMaintenanceTypeForm
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
            btnEditForm = new Button();
            label1 = new Label();
            txtBoxEditName = new TextBox();
            label2 = new Label();
            editrichTextBoxDescription = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnEditForm, 1, 7);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtBoxEditName, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(editrichTextBoxDescription, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(387, 283);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnEditForm
            // 
            btnEditForm.Dock = DockStyle.Fill;
            btnEditForm.Location = new Point(196, 248);
            btnEditForm.Name = "btnEditForm";
            btnEditForm.Size = new Size(188, 29);
            btnEditForm.TabIndex = 1;
            btnEditForm.Text = "Save";
            btnEditForm.UseVisualStyleBackColor = true;
            btnEditForm.Click += btnEditForm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(187, 35);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtBoxEditName
            // 
            txtBoxEditName.Dock = DockStyle.Fill;
            txtBoxEditName.Location = new Point(3, 38);
            txtBoxEditName.Name = "txtBoxEditName";
            txtBoxEditName.Size = new Size(187, 23);
            txtBoxEditName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 70);
            label2.Name = "label2";
            label2.Size = new Size(187, 35);
            label2.TabIndex = 2;
            label2.Text = "Description";
            // 
            // editrichTextBoxDescription
            // 
            tableLayoutPanel1.SetColumnSpan(editrichTextBoxDescription, 2);
            editrichTextBoxDescription.Dock = DockStyle.Fill;
            editrichTextBoxDescription.Location = new Point(3, 108);
            editrichTextBoxDescription.Name = "editrichTextBoxDescription";
            tableLayoutPanel1.SetRowSpan(editrichTextBoxDescription, 3);
            editrichTextBoxDescription.Size = new Size(381, 99);
            editrichTextBoxDescription.TabIndex = 3;
            editrichTextBoxDescription.Text = "";
            // 
            // EditMaintenanceTypeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 283);
            Controls.Add(tableLayoutPanel1);
            Name = "EditMaintenanceTypeForm";
            Text = "EditMaintenanceTypeForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnEditForm;
        private Label label1;
        private TextBox txtBoxEditName;
        private Label label2;
        private RichTextBox editrichTextBoxDescription;
    }
}