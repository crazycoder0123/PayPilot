namespace PayPilot
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            logid = new TextBox();
            logpass = new TextBox();
            label5 = new Label();
            logbt = new Button();
            logforpass = new Label();
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(526, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 676);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(22, 26, 48);
            label1.Location = new Point(71, 532);
            label1.Name = "label1";
            label1.Size = new Size(458, 24);
            label1.TabIndex = 1;
            label1.Text = "Streamline employee payroll with precision and ease";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(349, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 26, 48);
            label2.Location = new Point(171, 87);
            label2.Name = "label2";
            label2.Size = new Size(172, 41);
            label2.TabIndex = 1;
            label2.Text = "WELCOME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(49, 48, 77);
            label3.Location = new Point(152, 137);
            label3.Name = "label3";
            label3.Size = new Size(209, 20);
            label3.TabIndex = 2;
            label3.Text = "LOGIN INTO YOUR ACCOUNT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(49, 48, 77);
            label4.Location = new Point(60, 268);
            label4.Name = "label4";
            label4.Size = new Size(81, 28);
            label4.TabIndex = 3;
            label4.Text = "UserID ";
            // 
            // logid
            // 
            logid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logid.ForeColor = Color.FromArgb(22, 26, 48);
            logid.Location = new Point(60, 308);
            logid.Name = "logid";
            logid.Size = new Size(388, 34);
            logid.TabIndex = 4;
            // 
            // logpass
            // 
            logpass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logpass.ForeColor = Color.FromArgb(22, 26, 48);
            logpass.Location = new Point(60, 411);
            logpass.Name = "logpass";
            logpass.PasswordChar = '*';
            logpass.Size = new Size(388, 34);
            logpass.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(49, 48, 77);
            label5.Location = new Point(60, 370);
            label5.Name = "label5";
            label5.Size = new Size(101, 28);
            label5.TabIndex = 5;
            label5.Text = "Password";
            // 
            // logbt
            // 
            logbt.BackColor = Color.FromArgb(182, 187, 196);
            logbt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logbt.ForeColor = Color.FromArgb(22, 26, 48);
            logbt.Location = new Point(60, 517);
            logbt.Name = "logbt";
            logbt.Size = new Size(388, 51);
            logbt.TabIndex = 7;
            logbt.Text = "Login";
            logbt.UseVisualStyleBackColor = false;
            logbt.Click += logbt_Click;
            // 
            // logforpass
            // 
            logforpass.AutoSize = true;
            logforpass.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logforpass.ForeColor = Color.FromArgb(22, 26, 48);
            logforpass.Location = new Point(60, 462);
            logforpass.Name = "logforpass";
            logforpass.Size = new Size(140, 21);
            logforpass.TabIndex = 2;
            logforpass.Text = "Forgot Password?";
            logforpass.Click += logforpass_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.FromArgb(22, 26, 48);
            checkBox1.Location = new Point(301, 461);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(147, 25);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 229);
            ClientSize = new Size(1095, 676);
            Controls.Add(checkBox1);
            Controls.Add(logforpass);
            Controls.Add(logbt);
            Controls.Add(logpass);
            Controls.Add(label5);
            Controls.Add(logid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PayPilot";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox logid;
        private TextBox logpass;
        private Label label5;
        private Button logbt;
        private Label logforpass;
        private CheckBox checkBox1;
    }
}