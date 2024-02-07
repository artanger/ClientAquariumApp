namespace ClientAquariumApp
{
    partial class AddMaintenanceTypeForm
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
            textBoxNameType = new TextBox();
            label2 = new Label();
            richTextBoxDescription = new RichTextBox();
            addTypeButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxNameType, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(richTextBoxDescription, 0, 3);
            tableLayoutPanel1.Controls.Add(addTypeButton, 1, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(387, 293);
            tableLayoutPanel1.TabIndex = 0;
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
            // textBoxNameType
            // 
            textBoxNameType.Dock = DockStyle.Fill;
            textBoxNameType.Location = new Point(3, 38);
            textBoxNameType.Name = "textBoxNameType";
            textBoxNameType.Size = new Size(187, 23);
            textBoxNameType.TabIndex = 1;
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
            // richTextBoxDescription
            // 
            tableLayoutPanel1.SetColumnSpan(richTextBoxDescription, 2);
            richTextBoxDescription.Dock = DockStyle.Fill;
            richTextBoxDescription.Location = new Point(3, 108);
            richTextBoxDescription.Name = "richTextBoxDescription";
            tableLayoutPanel1.SetRowSpan(richTextBoxDescription, 3);
            richTextBoxDescription.Size = new Size(381, 99);
            richTextBoxDescription.TabIndex = 3;
            richTextBoxDescription.Text = "";
            // 
            // addTypeButton
            // 
            addTypeButton.Dock = DockStyle.Fill;
            addTypeButton.Location = new Point(196, 248);
            addTypeButton.Name = "addTypeButton";
            addTypeButton.Size = new Size(188, 42);
            addTypeButton.TabIndex = 4;
            addTypeButton.Text = "Add";
            addTypeButton.UseVisualStyleBackColor = true;
            addTypeButton.Click += addTypeButton_Click;
            // 
            // AddMaintenanceTypeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 293);
            Controls.Add(tableLayoutPanel1);
            Name = "AddMaintenanceTypeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddMaintenanceTypeForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox textBoxNameType;
        private Label label2;
        private RichTextBox richTextBoxDescription;
        private Button addTypeButton;
    }
}