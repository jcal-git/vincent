namespace projdcit
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
            panellogin = new Panel();
            button1 = new Button();
            labelpass = new Label();
            label2 = new Label();
            logpass = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            panelbutton1 = new Panel();
            label3 = new Label();
            panelbutton2 = new Panel();
            label4 = new Label();
            panelsignin = new Panel();
            label15 = new Label();
            button2 = new Button();
            panel3 = new Panel();
            radioButton3 = new RadioButton();
            radioButton1 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            panellogin.SuspendLayout();
            panelbutton1.SuspendLayout();
            panelbutton2.SuspendLayout();
            panelsignin.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panellogin
            // 
            panellogin.Anchor = AnchorStyles.None;
            panellogin.BackColor = SystemColors.ActiveBorder;
            panellogin.BackgroundImage = (Image)resources.GetObject("panellogin.BackgroundImage");
            panellogin.BackgroundImageLayout = ImageLayout.Stretch;
            panellogin.Controls.Add(button1);
            panellogin.Controls.Add(labelpass);
            panellogin.Controls.Add(label2);
            panellogin.Controls.Add(logpass);
            panellogin.Controls.Add(textBox1);
            panellogin.Controls.Add(label1);
            panellogin.Location = new Point(330, 171);
            panellogin.Name = "panellogin";
            panellogin.Size = new Size(632, 479);
            panellogin.TabIndex = 0;
            panellogin.Visible = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(142, 362);
            button1.Name = "button1";
            button1.Size = new Size(371, 55);
            button1.TabIndex = 7;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelpass
            // 
            labelpass.AutoSize = true;
            labelpass.BackColor = Color.Transparent;
            labelpass.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelpass.Location = new Point(233, 320);
            labelpass.Name = "labelpass";
            labelpass.Size = new Size(172, 30);
            labelpass.TabIndex = 6;
            labelpass.Text = "Forgot Password";
            labelpass.MouseClick += labelpass_MouseClick;
            labelpass.MouseLeave += labelpass_MouseLeave;
            labelpass.MouseHover += label3_MouseHover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(142, 238);
            label2.Name = "label2";
            label2.Size = new Size(126, 30);
            label2.TabIndex = 5;
            label2.Text = "PASSWORD";
            label2.Click += label2_Click;
            // 
            // logpass
            // 
            logpass.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logpass.Location = new Point(142, 271);
            logpass.Name = "logpass";
            logpass.PasswordChar = '*';
            logpass.Size = new Size(371, 35);
            logpass.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(142, 173);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(371, 35);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(142, 140);
            label1.Name = "label1";
            label1.Size = new Size(122, 30);
            label1.TabIndex = 0;
            label1.Text = "USERNAME";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(24, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(99, 92);
            panel2.TabIndex = 0;
            // 
            // panelbutton1
            // 
            panelbutton1.BackColor = Color.Transparent;
            panelbutton1.Controls.Add(label3);
            panelbutton1.ForeColor = SystemColors.ActiveCaptionText;
            panelbutton1.Location = new Point(330, 719);
            panelbutton1.Name = "panelbutton1";
            panelbutton1.Size = new Size(231, 54);
            panelbutton1.TabIndex = 1;
            panelbutton1.Paint += panel3_Paint;
            panelbutton1.MouseClick += panel3_MouseClick;
            panelbutton1.MouseLeave += panelbutton1_MouseLeave;
            panelbutton1.MouseHover += panel3_MouseHover;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(80, 12);
            label3.Name = "label3";
            label3.Size = new Size(73, 30);
            label3.TabIndex = 0;
            label3.Text = "Log In";
            label3.Click += label3_Click;
            label3.MouseClick += label3_MouseClick;
            label3.MouseHover += label3_MouseHover_1;
            // 
            // panelbutton2
            // 
            panelbutton2.BackColor = Color.Transparent;
            panelbutton2.Controls.Add(label4);
            panelbutton2.Location = new Point(731, 719);
            panelbutton2.Name = "panelbutton2";
            panelbutton2.Size = new Size(231, 54);
            panelbutton2.TabIndex = 2;
            panelbutton2.Paint += panelbutton2_Paint;
            panelbutton2.MouseClick += panelbutton2_MouseClick;
            panelbutton2.MouseLeave += panelbutton2_MouseLeave;
            panelbutton2.MouseHover += panelbutton2_MouseHover;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(82, 12);
            label4.Name = "label4";
            label4.Size = new Size(78, 30);
            label4.TabIndex = 3;
            label4.Text = "Sign In";
            label4.MouseClick += label4_MouseClick;
            label4.MouseHover += label4_MouseHover;
            // 
            // panelsignin
            // 
            panelsignin.BackColor = Color.SteelBlue;
            panelsignin.Controls.Add(label15);
            panelsignin.Controls.Add(button2);
            panelsignin.Controls.Add(panel3);
            panelsignin.Controls.Add(dateTimePicker1);
            panelsignin.Controls.Add(textBox8);
            panelsignin.Controls.Add(textBox7);
            panelsignin.Controls.Add(textBox6);
            panelsignin.Controls.Add(textBox5);
            panelsignin.Controls.Add(textBox4);
            panelsignin.Controls.Add(textBox3);
            panelsignin.Controls.Add(textBox2);
            panelsignin.Controls.Add(label14);
            panelsignin.Controls.Add(label13);
            panelsignin.Controls.Add(label12);
            panelsignin.Controls.Add(label11);
            panelsignin.Controls.Add(label10);
            panelsignin.Controls.Add(label9);
            panelsignin.Controls.Add(label8);
            panelsignin.Controls.Add(label7);
            panelsignin.Controls.Add(panel1);
            panelsignin.Controls.Add(label5);
            panelsignin.ForeColor = SystemColors.ActiveCaption;
            panelsignin.Location = new Point(193, 119);
            panelsignin.Name = "panelsignin";
            panelsignin.Size = new Size(860, 568);
            panelsignin.TabIndex = 3;
            panelsignin.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(803, 17);
            label15.Name = "label15";
            label15.Size = new Size(41, 45);
            label15.TabIndex = 4;
            label15.Text = "X";
            label15.Click += label15_Click;
            label15.MouseClick += label15_MouseClick;
            // 
            // button2
            // 
            button2.BackColor = Color.Azure;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(677, 501);
            button2.Name = "button2";
            button2.Size = new Size(113, 54);
            button2.TabIndex = 19;
            button2.Text = "Sign In";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSteelBlue;
            panel3.Controls.Add(radioButton3);
            panel3.Controls.Add(radioButton1);
            panel3.Location = new Point(66, 408);
            panel3.Name = "panel3";
            panel3.Size = new Size(317, 103);
            panel3.TabIndex = 18;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton3.ForeColor = Color.Black;
            radioButton3.Location = new Point(11, 45);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(73, 29);
            radioButton3.TabIndex = 1;
            radioButton3.TabStop = true;
            radioButton3.Text = "Male";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = Color.Black;
            radioButton1.Location = new Point(11, 10);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(92, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Female";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(250, 350);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(122, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.LightSteelBlue;
            textBox8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox8.Location = new Point(66, 344);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(317, 33);
            textBox8.TabIndex = 16;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.LightSteelBlue;
            textBox7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(473, 408);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(317, 33);
            textBox7.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.LightSteelBlue;
            textBox6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(473, 344);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(317, 33);
            textBox6.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.LightSteelBlue;
            textBox5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(473, 280);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(317, 33);
            textBox5.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.LightSteelBlue;
            textBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(473, 220);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(317, 33);
            textBox4.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightSteelBlue;
            textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(66, 283);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(317, 33);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightSteelBlue;
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(66, 219);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(317, 33);
            textBox2.TabIndex = 10;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(484, 380);
            label14.Name = "label14";
            label14.Size = new Size(166, 25);
            label14.TabIndex = 9;
            label14.Text = "Confirm Password";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(484, 316);
            label13.Name = "label13";
            label13.Size = new Size(91, 25);
            label13.TabIndex = 8;
            label13.Text = "Password";
            label13.Click += label13_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(484, 252);
            label12.Name = "label12";
            label12.Size = new Size(80, 25);
            label12.TabIndex = 7;
            label12.Text = "Address";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(484, 186);
            label11.Name = "label11";
            label11.Size = new Size(132, 25);
            label11.TabIndex = 6;
            label11.Text = "Email Address";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(64, 380);
            label10.Name = "label10";
            label10.Size = new Size(42, 25);
            label10.TabIndex = 5;
            label10.Text = "Sex";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(64, 317);
            label9.Name = "label9";
            label9.Size = new Size(123, 25);
            label9.TabIndex = 4;
            label9.Text = "Date of Birth";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(64, 255);
            label8.Name = "label8";
            label8.Size = new Size(142, 25);
            label8.TabIndex = 3;
            label8.Text = "Phone Number";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(64, 186);
            label7.Name = "label7";
            label7.Size = new Size(158, 25);
            label7.TabIndex = 2;
            label7.Text = "User Registration";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(label6);
            panel1.Location = new Point(64, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 64);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(65, 7);
            label6.Name = "label6";
            label6.Size = new Size(619, 50);
            label6.TabIndex = 0;
            label6.Text = "Note: Your details must match your ID ( Passport, driving license, etc.) \r\nthat will be required during check-in.";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(64, 37);
            label5.Name = "label5";
            label5.Size = new Size(158, 25);
            label5.TabIndex = 0;
            label5.Text = "User Registration";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.e1fb67b8_81e6_4f98_9c64_8ea5bd6d79c8;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1205, 804);
            Controls.Add(panelsignin);
            Controls.Add(panelbutton2);
            Controls.Add(panelbutton1);
            Controls.Add(panel2);
            Controls.Add(panellogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panellogin.ResumeLayout(false);
            panellogin.PerformLayout();
            panelbutton1.ResumeLayout(false);
            panelbutton1.PerformLayout();
            panelbutton2.ResumeLayout(false);
            panelbutton2.PerformLayout();
            panelsignin.ResumeLayout(false);
            panelsignin.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panellogin;
        private Panel panel2;
        private Button button1;
        private Label labelpass;
        private Label label2;
        private TextBox logpass;
        private TextBox textBox1;
        private Label label1;
        private Panel panelbutton1;
        private Panel panelbutton2;
        private Label label3;
        private Label label4;
        private Panel panelsignin;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox textBox2;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private Panel panel3;
        private RadioButton radioButton3;
        private RadioButton radioButton1;
        private Button button2;
        private Label label15;
    }
}
