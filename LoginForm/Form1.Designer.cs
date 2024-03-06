namespace LoginForm
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.parkingSystem_login;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(351, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(386, 139);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 1;
            label1.Text = "USERNAME";
            label1.Click += Label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(386, 192);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(386, 258);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 1;
            label2.Text = "PASSWORD";
            label2.Click += Label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(386, 311);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 1);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(32, 32, 66);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(467, 368);
            button1.Name = "button1";
            button1.Size = new Size(139, 43);
            button1.TabIndex = 3;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(513, 423);
            label3.Name = "label3";
            label3.Size = new Size(46, 21);
            label3.TabIndex = 4;
            label3.Text = "Exit";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(386, 54);
            label4.Name = "label4";
            label4.Size = new Size(207, 35);
            label4.TabIndex = 5;
            label4.Text = "Welcome User";
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Location = new Point(386, 163);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(300, 23);
            txtUserName.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(386, 282);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(300, 23);
            txtPassword.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(750, 500);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(32, 32, 66);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Button button1;
        private Label label3;
        private Label label4;
        private TextBox txtUserName;
        private TextBox txtPassword;
    }
}
