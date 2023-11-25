namespace WF_DZ_8
{
    partial class Form1
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
            colorDialog = new ColorDialog();
            fontComboBox = new ComboBox();
            pictureBox = new PictureBox();
            watermarkTextBox = new TextBox();
            fontSizeNumericUpDown = new NumericUpDown();
            colorTextBox = new TextBox();
            loadImageButton = new Button();
            addWatermarkButton = new Button();
            selectFontButton = new Button();
            selectColorButton = new Button();
            splitContainer = new SplitContainer();
            locationGroupBox = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            rotateNumericUpDown = new NumericUpDown();
            yPositionNumericUpDown = new NumericUpDown();
            xPositionNumericUpDown = new NumericUpDown();
            label7 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            fontStyleGroupBox = new GroupBox();
            label1 = new Label();
            colorGroupBox = new GroupBox();
            blueNumericUpDown = new NumericUpDown();
            greenNumericUpDown = new NumericUpDown();
            redNumericUpDown = new NumericUpDown();
            clearButton = new Button();
            saveImageButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fontSizeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            locationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rotateNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yPositionNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xPositionNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            fontStyleGroupBox.SuspendLayout();
            colorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)blueNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greenNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)redNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // fontComboBox
            // 
            fontComboBox.FormattingEnabled = true;
            fontComboBox.Location = new Point(3, 20);
            fontComboBox.Margin = new Padding(2);
            fontComboBox.Name = "fontComboBox";
            fontComboBox.Size = new Size(118, 23);
            fontComboBox.TabIndex = 0;
            fontComboBox.Visible = false;
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(1, 0);
            pictureBox.Margin = new Padding(2);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(405, 316);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // watermarkTextBox
            // 
            watermarkTextBox.Location = new Point(3, 87);
            watermarkTextBox.Margin = new Padding(2);
            watermarkTextBox.Name = "watermarkTextBox";
            watermarkTextBox.Size = new Size(193, 23);
            watermarkTextBox.TabIndex = 2;
            // 
            // fontSizeNumericUpDown
            // 
            fontSizeNumericUpDown.Location = new Point(4, 45);
            fontSizeNumericUpDown.Margin = new Padding(2);
            fontSizeNumericUpDown.Name = "fontSizeNumericUpDown";
            fontSizeNumericUpDown.Size = new Size(117, 23);
            fontSizeNumericUpDown.TabIndex = 3;
            fontSizeNumericUpDown.Visible = false;
            // 
            // colorTextBox
            // 
            colorTextBox.BorderStyle = BorderStyle.FixedSingle;
            colorTextBox.ForeColor = SystemColors.Window;
            colorTextBox.Location = new Point(4, 20);
            colorTextBox.Margin = new Padding(2);
            colorTextBox.Multiline = true;
            colorTextBox.Name = "colorTextBox";
            colorTextBox.ReadOnly = true;
            colorTextBox.Size = new Size(195, 81);
            colorTextBox.TabIndex = 6;
            // 
            // loadImageButton
            // 
            loadImageButton.Location = new Point(2, 344);
            loadImageButton.Margin = new Padding(2);
            loadImageButton.Name = "loadImageButton";
            loadImageButton.Size = new Size(198, 30);
            loadImageButton.TabIndex = 7;
            loadImageButton.Text = "Завантажити зображення";
            loadImageButton.UseVisualStyleBackColor = true;
            loadImageButton.Click += loadImageButton_Click;
            // 
            // addWatermarkButton
            // 
            addWatermarkButton.Location = new Point(2, 320);
            addWatermarkButton.Margin = new Padding(2);
            addWatermarkButton.Name = "addWatermarkButton";
            addWatermarkButton.Size = new Size(397, 22);
            addWatermarkButton.TabIndex = 8;
            addWatermarkButton.Text = "Додати";
            addWatermarkButton.UseVisualStyleBackColor = true;
            addWatermarkButton.Click += addWatermarkButton_Click;
            // 
            // selectFontButton
            // 
            selectFontButton.BackColor = SystemColors.ActiveCaption;
            selectFontButton.FlatStyle = FlatStyle.System;
            selectFontButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            selectFontButton.Location = new Point(-1, 15);
            selectFontButton.Margin = new Padding(2);
            selectFontButton.Name = "selectFontButton";
            selectFontButton.Size = new Size(194, 53);
            selectFontButton.TabIndex = 9;
            selectFontButton.Text = "ОБРАТИ";
            selectFontButton.UseVisualStyleBackColor = false;
            // 
            // selectColorButton
            // 
            selectColorButton.BackColor = SystemColors.ActiveCaption;
            selectColorButton.FlatStyle = FlatStyle.System;
            selectColorButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            selectColorButton.Location = new Point(3, 105);
            selectColorButton.Margin = new Padding(2);
            selectColorButton.Name = "selectColorButton";
            selectColorButton.Size = new Size(194, 53);
            selectColorButton.TabIndex = 10;
            selectColorButton.Text = "ОБРАТИ";
            selectColorButton.UseVisualStyleBackColor = false;
            // 
            // splitContainer
            // 
            splitContainer.BorderStyle = BorderStyle.FixedSingle;
            splitContainer.Location = new Point(5, 5);
            splitContainer.Margin = new Padding(2);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(blueNumericUpDown);
            splitContainer.Panel1.Controls.Add(locationGroupBox);
            splitContainer.Panel1.Controls.Add(fontStyleGroupBox);
            splitContainer.Panel1.Controls.Add(colorGroupBox);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(clearButton);
            splitContainer.Panel2.Controls.Add(saveImageButton);
            splitContainer.Panel2.Controls.Add(pictureBox);
            splitContainer.Panel2.Controls.Add(loadImageButton);
            splitContainer.Panel2.Controls.Add(addWatermarkButton);
            splitContainer.Size = new Size(614, 404);
            splitContainer.SplitterDistance = 204;
            splitContainer.SplitterWidth = 3;
            splitContainer.TabIndex = 11;
            // 
            // locationGroupBox
            // 
            locationGroupBox.Controls.Add(label10);
            locationGroupBox.Controls.Add(label9);
            locationGroupBox.Controls.Add(label8);
            locationGroupBox.Controls.Add(rotateNumericUpDown);
            locationGroupBox.Controls.Add(yPositionNumericUpDown);
            locationGroupBox.Controls.Add(xPositionNumericUpDown);
            locationGroupBox.Controls.Add(label7);
            locationGroupBox.Controls.Add(numericUpDown1);
            locationGroupBox.Controls.Add(button1);
            locationGroupBox.Location = new Point(0, 292);
            locationGroupBox.Margin = new Padding(2);
            locationGroupBox.Name = "locationGroupBox";
            locationGroupBox.Padding = new Padding(2);
            locationGroupBox.Size = new Size(201, 105);
            locationGroupBox.TabIndex = 16;
            locationGroupBox.TabStop = false;
            locationGroupBox.Text = "Положення водяного знаку";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(80, 80);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 21;
            label10.Text = "Обертання";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(80, 55);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 20;
            label9.Text = "Висота";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(80, 31);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 19;
            label8.Text = "Ширина";
            // 
            // rotateNumericUpDown
            // 
            rotateNumericUpDown.Location = new Point(3, 78);
            rotateNumericUpDown.Margin = new Padding(2);
            rotateNumericUpDown.Name = "rotateNumericUpDown";
            rotateNumericUpDown.Size = new Size(73, 23);
            rotateNumericUpDown.TabIndex = 18;
            // 
            // yPositionNumericUpDown
            // 
            yPositionNumericUpDown.Location = new Point(3, 53);
            yPositionNumericUpDown.Margin = new Padding(2);
            yPositionNumericUpDown.Name = "yPositionNumericUpDown";
            yPositionNumericUpDown.Size = new Size(73, 23);
            yPositionNumericUpDown.TabIndex = 17;
            // 
            // xPositionNumericUpDown
            // 
            xPositionNumericUpDown.Location = new Point(3, 29);
            xPositionNumericUpDown.Margin = new Padding(2);
            xPositionNumericUpDown.Name = "xPositionNumericUpDown";
            xPositionNumericUpDown.Size = new Size(73, 23);
            xPositionNumericUpDown.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(126, 115);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 15;
            label7.Text = "BLUE";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(5, 111);
            numericUpDown1.Margin = new Padding(2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(117, 23);
            numericUpDown1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(4, 136);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(194, 22);
            button1.TabIndex = 10;
            button1.Text = "Color Selection";
            button1.UseVisualStyleBackColor = true;
            // 
            // fontStyleGroupBox
            // 
            fontStyleGroupBox.Controls.Add(label1);
            fontStyleGroupBox.Controls.Add(selectFontButton);
            fontStyleGroupBox.Controls.Add(fontSizeNumericUpDown);
            fontStyleGroupBox.Controls.Add(fontComboBox);
            fontStyleGroupBox.Controls.Add(watermarkTextBox);
            fontStyleGroupBox.Location = new Point(4, 2);
            fontStyleGroupBox.Margin = new Padding(2);
            fontStyleGroupBox.Name = "fontStyleGroupBox";
            fontStyleGroupBox.Padding = new Padding(2);
            fontStyleGroupBox.Size = new Size(201, 121);
            fontStyleGroupBox.TabIndex = 11;
            fontStyleGroupBox.TabStop = false;
            fontStyleGroupBox.Text = "Стиль тексту";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(31, 70);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 10;
            label1.Text = "ВВЕДІТЬ ВАШ ТЕКСТ";
            // 
            // colorGroupBox
            // 
            colorGroupBox.Controls.Add(greenNumericUpDown);
            colorGroupBox.Controls.Add(redNumericUpDown);
            colorGroupBox.Controls.Add(selectColorButton);
            colorGroupBox.Controls.Add(colorTextBox);
            colorGroupBox.Location = new Point(0, 125);
            colorGroupBox.Margin = new Padding(2);
            colorGroupBox.Name = "colorGroupBox";
            colorGroupBox.Padding = new Padding(2);
            colorGroupBox.Size = new Size(201, 162);
            colorGroupBox.TabIndex = 12;
            colorGroupBox.TabStop = false;
            colorGroupBox.Text = "Колір водяного знаку";
            // 
            // blueNumericUpDown
            // 
            blueNumericUpDown.BorderStyle = BorderStyle.None;
            blueNumericUpDown.Location = new Point(195, 264);
            blueNumericUpDown.Margin = new Padding(2);
            blueNumericUpDown.Name = "blueNumericUpDown";
            blueNumericUpDown.Size = new Size(10, 19);
            blueNumericUpDown.TabIndex = 12;
            blueNumericUpDown.Visible = false;
            // 
            // greenNumericUpDown
            // 
            greenNumericUpDown.BorderStyle = BorderStyle.None;
            greenNumericUpDown.Location = new Point(195, 139);
            greenNumericUpDown.Margin = new Padding(2);
            greenNumericUpDown.Name = "greenNumericUpDown";
            greenNumericUpDown.Size = new Size(10, 19);
            greenNumericUpDown.TabIndex = 11;
            greenNumericUpDown.Visible = false;
            // 
            // redNumericUpDown
            // 
            redNumericUpDown.BorderStyle = BorderStyle.None;
            redNumericUpDown.Location = new Point(194, 139);
            redNumericUpDown.Margin = new Padding(2);
            redNumericUpDown.Name = "redNumericUpDown";
            redNumericUpDown.Size = new Size(10, 19);
            redNumericUpDown.TabIndex = 10;
            redNumericUpDown.Visible = false;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(2, 375);
            clearButton.Margin = new Padding(2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(397, 22);
            clearButton.TabIndex = 12;
            clearButton.Text = "Очистити";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // saveImageButton
            // 
            saveImageButton.Location = new Point(202, 344);
            saveImageButton.Margin = new Padding(2);
            saveImageButton.Name = "saveImageButton";
            saveImageButton.Size = new Size(198, 30);
            saveImageButton.TabIndex = 11;
            saveImageButton.Text = "Зберегти";
            saveImageButton.UseVisualStyleBackColor = true;
            saveImageButton.Click += saveImageButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 415);
            Controls.Add(splitContainer);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Водяний знак";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)fontSizeNumericUpDown).EndInit();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            locationGroupBox.ResumeLayout(false);
            locationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rotateNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)yPositionNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)xPositionNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            fontStyleGroupBox.ResumeLayout(false);
            fontStyleGroupBox.PerformLayout();
            colorGroupBox.ResumeLayout(false);
            colorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)blueNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)greenNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)redNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ColorDialog colorDialog;
        private ComboBox fontComboBox;
        private PictureBox pictureBox;
        private TextBox watermarkTextBox;
        private NumericUpDown fontSizeNumericUpDown;
        private TextBox colorTextBox;
        private Button loadImageButton;
        private Button addWatermarkButton;
        private Button selectFontButton;
        private Button selectColorButton;
        private SplitContainer splitContainer;
        private Button saveImageButton;
        private GroupBox fontStyleGroupBox;
        private GroupBox colorGroupBox;
        private NumericUpDown blueNumericUpDown;
        private NumericUpDown greenNumericUpDown;
        private GroupBox locationGroupBox;
        private NumericUpDown rotateNumericUpDown;
        private NumericUpDown yPositionNumericUpDown;
        private NumericUpDown xPositionNumericUpDown;
        private Label label7;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Label label8;
        private Label label10;
        private Label label9;
        private Button clearButton;
        private Label label1;
        private NumericUpDown redNumericUpDown;
    }
}