namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.modeButton = new System.Windows.Forms.Button();
            this.result_box = new System.Windows.Forms.TextBox();
            this.pastInput = new System.Windows.Forms.Label();
            this.eraseButton = new System.Windows.Forms.PictureBox();
            this.one = new System.Windows.Forms.PictureBox();
            this.four = new System.Windows.Forms.PictureBox();
            this.seven = new System.Windows.Forms.PictureBox();
            this.three = new System.Windows.Forms.PictureBox();
            this.six = new System.Windows.Forms.PictureBox();
            this.nine = new System.Windows.Forms.PictureBox();
            this.equalSign = new System.Windows.Forms.PictureBox();
            this.two = new System.Windows.Forms.PictureBox();
            this.five = new System.Windows.Forms.PictureBox();
            this.eight = new System.Windows.Forms.PictureBox();
            this.zero = new System.Windows.Forms.PictureBox();
            this.dot = new System.Windows.Forms.PictureBox();
            this.plusSign = new System.Windows.Forms.PictureBox();
            this.minusSign = new System.Windows.Forms.PictureBox();
            this.asterisk = new System.Windows.Forms.PictureBox();
            this.slash = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eraseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.one)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.four)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.three)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.six)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equalSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.two)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.five)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minusSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asterisk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slash)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.modeButton);
            this.panel1.Controls.Add(this.result_box);
            this.panel1.Controls.Add(this.pastInput);
            this.panel1.Controls.Add(this.eraseButton);
            this.panel1.Controls.Add(this.one);
            this.panel1.Controls.Add(this.four);
            this.panel1.Controls.Add(this.seven);
            this.panel1.Controls.Add(this.three);
            this.panel1.Controls.Add(this.six);
            this.panel1.Controls.Add(this.nine);
            this.panel1.Controls.Add(this.equalSign);
            this.panel1.Controls.Add(this.two);
            this.panel1.Controls.Add(this.five);
            this.panel1.Controls.Add(this.eight);
            this.panel1.Controls.Add(this.zero);
            this.panel1.Controls.Add(this.dot);
            this.panel1.Controls.Add(this.plusSign);
            this.panel1.Controls.Add(this.minusSign);
            this.panel1.Controls.Add(this.asterisk);
            this.panel1.Controls.Add(this.slash);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 490);
            this.panel1.TabIndex = 0;
            // 
            // modeButton
            // 
            this.modeButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.modeButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modeButton.Location = new System.Drawing.Point(27, 125);
            this.modeButton.Name = "modeButton";
            this.modeButton.Size = new System.Drawing.Size(116, 44);
            this.modeButton.TabIndex = 8;
            this.modeButton.Text = "Dark mode off";
            this.modeButton.UseVisualStyleBackColor = false;
            this.modeButton.Click += new System.EventHandler(this.modeSwitch);
            // 
            // result_box
            // 
            this.result_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result_box.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.result_box.ForeColor = System.Drawing.Color.Black;
            this.result_box.Location = new System.Drawing.Point(23, 62);
            this.result_box.Name = "result_box";
            this.result_box.Size = new System.Drawing.Size(270, 31);
            this.result_box.TabIndex = 7;
            this.result_box.TabStop = false;
            this.result_box.Text = "0";
            this.result_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pastInput
            // 
            this.pastInput.AutoSize = true;
            this.pastInput.BackColor = System.Drawing.Color.White;
            this.pastInput.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pastInput.ForeColor = System.Drawing.Color.CadetBlue;
            this.pastInput.Location = new System.Drawing.Point(21, 23);
            this.pastInput.Name = "pastInput";
            this.pastInput.Size = new System.Drawing.Size(0, 23);
            this.pastInput.TabIndex = 1;
            // 
            // eraseButton
            // 
            this.eraseButton.BackColor = System.Drawing.Color.Transparent;
            this.eraseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eraseButton.Image = global::Calculator.Properties.Resources.erase;
            this.eraseButton.Location = new System.Drawing.Point(165, 115);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(135, 60);
            this.eraseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eraseButton.TabIndex = 6;
            this.eraseButton.TabStop = false;
            this.eraseButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.Transparent;
            this.one.Cursor = System.Windows.Forms.Cursors.Hand;
            this.one.Image = ((System.Drawing.Image)(resources.GetObject("one.Image")));
            this.one.Location = new System.Drawing.Point(90, 190);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(60, 60);
            this.one.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.one.TabIndex = 5;
            this.one.TabStop = false;
            this.one.Tag = "1";
            this.one.Click += new System.EventHandler(this.button_click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.Transparent;
            this.four.Cursor = System.Windows.Forms.Cursors.Hand;
            this.four.Image = ((System.Drawing.Image)(resources.GetObject("four.Image")));
            this.four.Location = new System.Drawing.Point(90, 265);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(60, 60);
            this.four.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.four.TabIndex = 5;
            this.four.TabStop = false;
            this.four.Tag = "4";
            this.four.Click += new System.EventHandler(this.button_click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.Transparent;
            this.seven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seven.Image = ((System.Drawing.Image)(resources.GetObject("seven.Image")));
            this.seven.Location = new System.Drawing.Point(90, 340);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(60, 60);
            this.seven.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.seven.TabIndex = 5;
            this.seven.TabStop = false;
            this.seven.Tag = "7";
            this.seven.Click += new System.EventHandler(this.button_click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.Transparent;
            this.three.Cursor = System.Windows.Forms.Cursors.Hand;
            this.three.Image = ((System.Drawing.Image)(resources.GetObject("three.Image")));
            this.three.Location = new System.Drawing.Point(240, 190);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(60, 60);
            this.three.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.three.TabIndex = 4;
            this.three.TabStop = false;
            this.three.Tag = "3";
            this.three.Click += new System.EventHandler(this.button_click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.Transparent;
            this.six.Cursor = System.Windows.Forms.Cursors.Hand;
            this.six.Image = ((System.Drawing.Image)(resources.GetObject("six.Image")));
            this.six.Location = new System.Drawing.Point(240, 265);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(60, 60);
            this.six.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.six.TabIndex = 4;
            this.six.TabStop = false;
            this.six.Tag = "6";
            this.six.Click += new System.EventHandler(this.button_click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.Transparent;
            this.nine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nine.Image = ((System.Drawing.Image)(resources.GetObject("nine.Image")));
            this.nine.Location = new System.Drawing.Point(240, 340);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(60, 60);
            this.nine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nine.TabIndex = 4;
            this.nine.TabStop = false;
            this.nine.Tag = "9";
            this.nine.Click += new System.EventHandler(this.button_click);
            // 
            // equalSign
            // 
            this.equalSign.BackColor = System.Drawing.Color.Transparent;
            this.equalSign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.equalSign.Image = ((System.Drawing.Image)(resources.GetObject("equalSign.Image")));
            this.equalSign.Location = new System.Drawing.Point(241, 415);
            this.equalSign.Name = "equalSign";
            this.equalSign.Size = new System.Drawing.Size(60, 60);
            this.equalSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.equalSign.TabIndex = 4;
            this.equalSign.TabStop = false;
            this.equalSign.Click += new System.EventHandler(this.equalSign_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.Transparent;
            this.two.Cursor = System.Windows.Forms.Cursors.Hand;
            this.two.Image = ((System.Drawing.Image)(resources.GetObject("two.Image")));
            this.two.Location = new System.Drawing.Point(165, 190);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(60, 60);
            this.two.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.two.TabIndex = 3;
            this.two.TabStop = false;
            this.two.Tag = "2";
            this.two.Click += new System.EventHandler(this.button_click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.Transparent;
            this.five.Cursor = System.Windows.Forms.Cursors.Hand;
            this.five.Image = ((System.Drawing.Image)(resources.GetObject("five.Image")));
            this.five.Location = new System.Drawing.Point(165, 265);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(60, 60);
            this.five.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.five.TabIndex = 3;
            this.five.TabStop = false;
            this.five.Tag = "5";
            this.five.Click += new System.EventHandler(this.button_click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.Transparent;
            this.eight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eight.Image = ((System.Drawing.Image)(resources.GetObject("eight.Image")));
            this.eight.Location = new System.Drawing.Point(165, 340);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(60, 60);
            this.eight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eight.TabIndex = 3;
            this.eight.TabStop = false;
            this.eight.Tag = "8";
            this.eight.Click += new System.EventHandler(this.button_click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.Transparent;
            this.zero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zero.Image = ((System.Drawing.Image)(resources.GetObject("zero.Image")));
            this.zero.Location = new System.Drawing.Point(166, 415);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(60, 60);
            this.zero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zero.TabIndex = 3;
            this.zero.TabStop = false;
            this.zero.Tag = "0";
            this.zero.Click += new System.EventHandler(this.button_click);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.Color.Transparent;
            this.dot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dot.Image = ((System.Drawing.Image)(resources.GetObject("dot.Image")));
            this.dot.Location = new System.Drawing.Point(91, 415);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(60, 60);
            this.dot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dot.TabIndex = 2;
            this.dot.TabStop = false;
            this.dot.Tag = ".";
            this.dot.Click += new System.EventHandler(this.button_click);
            // 
            // plusSign
            // 
            this.plusSign.BackColor = System.Drawing.Color.Transparent;
            this.plusSign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plusSign.Image = ((System.Drawing.Image)(resources.GetObject("plusSign.Image")));
            this.plusSign.Location = new System.Drawing.Point(15, 190);
            this.plusSign.Name = "plusSign";
            this.plusSign.Size = new System.Drawing.Size(60, 60);
            this.plusSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plusSign.TabIndex = 1;
            this.plusSign.TabStop = false;
            this.plusSign.Tag = "+";
            this.plusSign.Click += new System.EventHandler(this.operator_click);
            // 
            // minusSign
            // 
            this.minusSign.BackColor = System.Drawing.Color.Transparent;
            this.minusSign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minusSign.Image = ((System.Drawing.Image)(resources.GetObject("minusSign.Image")));
            this.minusSign.Location = new System.Drawing.Point(15, 265);
            this.minusSign.Name = "minusSign";
            this.minusSign.Size = new System.Drawing.Size(60, 60);
            this.minusSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minusSign.TabIndex = 1;
            this.minusSign.TabStop = false;
            this.minusSign.Tag = "-";
            this.minusSign.Click += new System.EventHandler(this.operator_click);
            // 
            // asterisk
            // 
            this.asterisk.BackColor = System.Drawing.Color.Transparent;
            this.asterisk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.asterisk.Image = ((System.Drawing.Image)(resources.GetObject("asterisk.Image")));
            this.asterisk.Location = new System.Drawing.Point(15, 340);
            this.asterisk.Name = "asterisk";
            this.asterisk.Size = new System.Drawing.Size(60, 60);
            this.asterisk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.asterisk.TabIndex = 1;
            this.asterisk.TabStop = false;
            this.asterisk.Tag = "*";
            this.asterisk.Click += new System.EventHandler(this.operator_click);
            // 
            // slash
            // 
            this.slash.BackColor = System.Drawing.Color.Transparent;
            this.slash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slash.Image = ((System.Drawing.Image)(resources.GetObject("slash.Image")));
            this.slash.Location = new System.Drawing.Point(16, 415);
            this.slash.Name = "slash";
            this.slash.Size = new System.Drawing.Size(60, 60);
            this.slash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slash.TabIndex = 1;
            this.slash.TabStop = false;
            this.slash.Tag = "/";
            this.slash.Click += new System.EventHandler(this.operator_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(317, 491);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eraseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.one)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.four)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.three)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.six)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equalSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.two)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.five)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minusSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asterisk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox eraseButton;
        private PictureBox one;
        private PictureBox four;
        private PictureBox seven;
        private PictureBox three;
        private PictureBox six;
        private PictureBox nine;
        private PictureBox equalSign;
        private PictureBox two;
        private PictureBox five;
        private PictureBox eight;
        private PictureBox zero;
        private PictureBox dot;
        private PictureBox plusSign;
        private PictureBox minusSign;
        private PictureBox asterisk;
        private PictureBox slash;
        private TextBox result_box;
        private Label pastInput;
        private Button modeButton;
    }
}