namespace LoginForm2
{
    partial class LoginForm
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
            panel1 = new Panel();
            AdminLogInButton = new Button();
            panel3 = new Panel();
            textBox2 = new TextBox();
            panel2 = new Panel();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(AdminLogInButton);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(470, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(492, 392);
            panel1.TabIndex = 0;
            // 
            // AdminLogInButton
            // 
            AdminLogInButton.BackColor = Color.FromArgb(32, 32, 66);
            AdminLogInButton.Cursor = Cursors.Hand;
            AdminLogInButton.FlatStyle = FlatStyle.Flat;
            AdminLogInButton.Font = new Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminLogInButton.ForeColor = Color.White;
            AdminLogInButton.Location = new Point(63, 274);
            AdminLogInButton.Name = "AdminLogInButton";
            AdminLogInButton.Size = new Size(370, 64);
            AdminLogInButton.TabIndex = 2;
            AdminLogInButton.Text = "LOGIN";
            AdminLogInButton.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(textBox2);
            panel3.Location = new Point(63, 180);
            panel3.Name = "panel3";
            panel3.Size = new Size(370, 64);
            panel3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(224, 224, 224);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(0, 23);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = " password";
            textBox2.Size = new Size(370, 18);
            textBox2.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(63, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 64);
            panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(0, 23);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = " username";
            textBox1.Size = new Size(370, 18);
            textBox1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ParkXPert_removebg_preview;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(300, 300);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 66);
            ClientSize = new Size(1437, 807);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Font = new Font("Cascadia Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button AdminLogInButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
