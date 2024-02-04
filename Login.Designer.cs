namespace Digital_Library
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtName = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.HighlightText;
            txtName.Font = new Font("Algerian", 9F, FontStyle.Italic);
            txtName.Location = new Point(112, 230);
            txtName.Name = "txtName";
            txtName.Size = new Size(181, 27);
            txtName.TabIndex = 0;
            txtName.Text = "Name";
            txtName.MouseClick += txtName_MouseClick;
            txtName.TextChanged += txtName_TextChanged;
            txtName.MouseEnter += txtName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label2.Location = new Point(51, 259);
            label2.Name = "label2";
            label2.Size = new Size(0, 16);
            label2.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Algerian", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(112, 302);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(181, 27);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "Password";
            txtPassword.MouseClick += txtPassword_MouseClick;
            txtPassword.TextChanged += txtPassword_TextChanged;
            txtPassword.MouseEnter += txtPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Algerian", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ControlDarkDark;
            btnLogin.Location = new Point(128, 413);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(154, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(102, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 14F, FontStyle.Bold);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(377, 31);
            label1.TabIndex = 6;
            label1.Text = "New Gen Digital Library";
            label1.Click += label1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(400, 478);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtName);
            MaximumSize = new Size(418, 525);
            MinimumSize = new Size(418, 525);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label2;
        private TextBox txtPassword;
        private Button btnLogin;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
