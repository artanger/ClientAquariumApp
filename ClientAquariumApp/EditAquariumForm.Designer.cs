using LiveChartsCore;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.VisualElements;
using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore.VisualElements;
using SkiaSharp;

namespace ClientAquariumApp
{
    partial class EditAquariumForm : Form
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
            textBoxName = new TextBox();
            textBox2 = new TextBox();
            checkBoxLightning = new CheckBox();
            checkBoxPump = new CheckBox();
            checkBoxHeater = new CheckBox();
            checkBoxFilters = new CheckBox();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            descriptionTextBox = new RichTextBox();
            label3 = new Label();
            label4 = new Label();
            numericVolumeOfWater = new NumericUpDown();
            numericFishCount = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBoxWidth = new NumericUpDown();
            textBoxHeight = new NumericUpDown();
            textBoxDepth = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericVolumeOfWater).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericFishCount).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textBoxWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textBoxHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textBoxDepth).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Dock = DockStyle.Fill;
            textBoxName.Location = new Point(3, 33);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(302, 29);
            textBoxName.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(532, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 23);
            textBox2.TabIndex = 5;
            // 
            // checkBoxLightning
            // 
            checkBoxLightning.AutoSize = true;
            checkBoxLightning.Dock = DockStyle.Fill;
            checkBoxLightning.Location = new Point(311, 433);
            checkBoxLightning.Name = "checkBoxLightning";
            checkBoxLightning.Size = new Size(252, 33);
            checkBoxLightning.TabIndex = 8;
            checkBoxLightning.Text = "isLightning";
            checkBoxLightning.UseVisualStyleBackColor = true;
            // 
            // checkBoxPump
            // 
            checkBoxPump.AutoSize = true;
            checkBoxPump.Dock = DockStyle.Fill;
            checkBoxPump.Location = new Point(569, 433);
            checkBoxPump.Name = "checkBoxPump";
            checkBoxPump.Size = new Size(184, 33);
            checkBoxPump.TabIndex = 9;
            checkBoxPump.Text = "isPump";
            checkBoxPump.UseVisualStyleBackColor = true;
            // 
            // checkBoxHeater
            // 
            checkBoxHeater.AutoSize = true;
            checkBoxHeater.Dock = DockStyle.Fill;
            checkBoxHeater.Location = new Point(311, 497);
            checkBoxHeater.Name = "checkBoxHeater";
            checkBoxHeater.Size = new Size(252, 31);
            checkBoxHeater.TabIndex = 10;
            checkBoxHeater.Text = "isHeater";
            checkBoxHeater.UseVisualStyleBackColor = true;
            // 
            // checkBoxFilters
            // 
            checkBoxFilters.AutoSize = true;
            checkBoxFilters.Dock = DockStyle.Fill;
            checkBoxFilters.Location = new Point(569, 497);
            checkBoxFilters.Name = "checkBoxFilters";
            checkBoxFilters.Size = new Size(184, 31);
            checkBoxFilters.TabIndex = 11;
            checkBoxFilters.Text = "isFilters";
            checkBoxFilters.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Top;
            btnSave.Location = new Point(569, 534);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(184, 56);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(302, 30);
            label1.TabIndex = 13;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 60);
            label2.Name = "label2";
            label2.Size = new Size(302, 30);
            label2.TabIndex = 14;
            label2.Text = "Description";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Dock = DockStyle.Fill;
            descriptionTextBox.Location = new Point(3, 93);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(302, 237);
            descriptionTextBox.TabIndex = 2;
            descriptionTextBox.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 408);
            label3.Name = "label3";
            label3.Size = new Size(302, 22);
            label3.TabIndex = 16;
            label3.Text = "VolumeOfWater";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 469);
            label4.Name = "label4";
            label4.Size = new Size(302, 25);
            label4.TabIndex = 17;
            label4.Text = "FishCount";
            // 
            // numericVolumeOfWater
            // 
            numericVolumeOfWater.Dock = DockStyle.Fill;
            numericVolumeOfWater.Location = new Point(3, 433);
            numericVolumeOfWater.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericVolumeOfWater.Name = "numericVolumeOfWater";
            numericVolumeOfWater.Size = new Size(302, 29);
            numericVolumeOfWater.TabIndex = 6;
            // 
            // numericFishCount
            // 
            numericFishCount.Dock = DockStyle.Fill;
            numericFishCount.Location = new Point(3, 497);
            numericFishCount.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericFishCount.Name = "numericFishCount";
            numericFishCount.Size = new Size(302, 29);
            numericFishCount.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(94, 19);
            label5.TabIndex = 21;
            label5.Text = "Width";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(103, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 19);
            label6.TabIndex = 22;
            label6.Text = "Height";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(203, 0);
            label7.Name = "label7";
            label7.Size = new Size(96, 19);
            label7.TabIndex = 24;
            label7.Text = "Depth";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.74074F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.1269836F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.1322746F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(numericFishCount, 0, 8);
            tableLayoutPanel1.Controls.Add(checkBoxFilters, 2, 8);
            tableLayoutPanel1.Controls.Add(textBoxName, 0, 1);
            tableLayoutPanel1.Controls.Add(checkBoxHeater, 1, 8);
            tableLayoutPanel1.Controls.Add(label4, 0, 7);
            tableLayoutPanel1.Controls.Add(checkBoxPump, 2, 6);
            tableLayoutPanel1.Controls.Add(numericVolumeOfWater, 0, 6);
            tableLayoutPanel1.Controls.Add(checkBoxLightning, 1, 6);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(descriptionTextBox, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 4);
            tableLayoutPanel1.Controls.Add(btnSave, 2, 9);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 243F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.Size = new Size(756, 705);
            tableLayoutPanel1.TabIndex = 26;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(label5, 0, 0);
            tableLayoutPanel2.Controls.Add(label6, 1, 0);
            tableLayoutPanel2.Controls.Add(label7, 2, 0);
            tableLayoutPanel2.Controls.Add(textBoxWidth, 0, 1);
            tableLayoutPanel2.Controls.Add(textBoxHeight, 1, 1);
            tableLayoutPanel2.Controls.Add(textBoxDepth, 2, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 336);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 27.6315784F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 72.36842F));
            tableLayoutPanel2.Size = new Size(302, 69);
            tableLayoutPanel2.TabIndex = 16;
            // 
            // textBoxWidth
            // 
            textBoxWidth.Dock = DockStyle.Fill;
            textBoxWidth.Location = new Point(3, 22);
            textBoxWidth.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(94, 29);
            textBoxWidth.TabIndex = 3;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Dock = DockStyle.Fill;
            textBoxHeight.Location = new Point(103, 22);
            textBoxHeight.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(94, 29);
            textBoxHeight.TabIndex = 4;
            // 
            // textBoxDepth
            // 
            textBoxDepth.Dock = DockStyle.Fill;
            textBoxDepth.Location = new Point(203, 22);
            textBoxDepth.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            textBoxDepth.Name = "textBoxDepth";
            textBoxDepth.Size = new Size(96, 29);
            textBoxDepth.TabIndex = 5;
            // 
            // EditAquariumForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 705);
            Controls.Add(tableLayoutPanel1);
            Name = "EditAquariumForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Aquarium";
            ((System.ComponentModel.ISupportInitialize)numericVolumeOfWater).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericFishCount).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textBoxWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)textBoxHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)textBoxDepth).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBoxName;
        private TextBox textBox2;
        private CheckBox checkBoxLightning;
        private CheckBox checkBoxPump;
        private CheckBox checkBoxHeater;
        private CheckBox checkBoxFilters;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private RichTextBox descriptionTextBox;
        private Label label3;
        private Label label4;
        private NumericUpDown numericVolumeOfWater;
        private NumericUpDown numericFishCount;
        private Label label5;
        private Label label6;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private NumericUpDown textBoxWidth;
        private NumericUpDown textBoxHeight;
        private NumericUpDown textBoxDepth;
    }
}