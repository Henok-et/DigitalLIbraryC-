namespace Digital_Library
{
    partial class ViewStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudent));
            panel2 = new Panel();
            cancel = new Button();
            delete = new Button();
            Update = new Button();
            txtSSem = new TextBox();
            txtSEmail = new TextBox();
            txtSContact = new TextBox();
            txtSDep = new TextBox();
            txtSEnroll = new TextBox();
            txtSName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            txtSearch = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(cancel);
            panel2.Controls.Add(delete);
            panel2.Controls.Add(Update);
            panel2.Controls.Add(txtSSem);
            panel2.Controls.Add(txtSEmail);
            panel2.Controls.Add(txtSContact);
            panel2.Controls.Add(txtSDep);
            panel2.Controls.Add(txtSEnroll);
            panel2.Controls.Add(txtSName);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(25, 402);
            panel2.Name = "panel2";
            panel2.Size = new Size(905, 264);
            panel2.TabIndex = 11;
            panel2.Paint += panel2_Paint;
            // 
            // cancel
            // 
            cancel.FlatStyle = FlatStyle.Popup;
            cancel.Font = new Font("Algerian", 9F, FontStyle.Italic);
            cancel.Location = new Point(693, 236);
            cancel.Name = "cancel";
            cancel.Size = new Size(94, 29);
            cancel.TabIndex = 12;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // delete
            // 
            delete.FlatStyle = FlatStyle.Popup;
            delete.Font = new Font("Algerian", 9F, FontStyle.Italic);
            delete.Location = new Point(593, 236);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 12;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // Update
            // 
            Update.FlatStyle = FlatStyle.Popup;
            Update.Font = new Font("Algerian", 9F, FontStyle.Italic);
            Update.Location = new Point(493, 236);
            Update.Name = "Update";
            Update.Size = new Size(94, 29);
            Update.TabIndex = 12;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // txtSSem
            // 
            txtSSem.Location = new Point(657, 26);
            txtSSem.Name = "txtSSem";
            txtSSem.Size = new Size(182, 27);
            txtSSem.TabIndex = 11;
            // 
            // txtSEmail
            // 
            txtSEmail.Location = new Point(657, 181);
            txtSEmail.Name = "txtSEmail";
            txtSEmail.Size = new Size(182, 27);
            txtSEmail.TabIndex = 10;
            // 
            // txtSContact
            // 
            txtSContact.Location = new Point(657, 103);
            txtSContact.Name = "txtSContact";
            txtSContact.Size = new Size(182, 27);
            txtSContact.TabIndex = 9;
            // 
            // txtSDep
            // 
            txtSDep.Location = new Point(290, 177);
            txtSDep.Name = "txtSDep";
            txtSDep.Size = new Size(179, 27);
            txtSDep.TabIndex = 8;
            // 
            // txtSEnroll
            // 
            txtSEnroll.Location = new Point(290, 103);
            txtSEnroll.Name = "txtSEnroll";
            txtSEnroll.Size = new Size(179, 27);
            txtSEnroll.TabIndex = 7;
            // 
            // txtSName
            // 
            txtSName.Location = new Point(290, 26);
            txtSName.Name = "txtSName";
            txtSName.Size = new Size(179, 27);
            txtSName.TabIndex = 6;
            txtSName.TextChanged += txtSName_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label8.Location = new Point(493, 184);
            label8.Name = "label8";
            label8.Size = new Size(117, 16);
            label8.TabIndex = 5;
            label8.Text = "Student Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label7.Location = new Point(493, 106);
            label7.Name = "label7";
            label7.Size = new Size(138, 16);
            label7.TabIndex = 4;
            label7.Text = "Student Contact";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label6.Location = new Point(493, 26);
            label6.Name = "label6";
            label6.Size = new Size(146, 16);
            label6.TabIndex = 3;
            label6.Text = "Student Semester";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label5.Location = new Point(129, 109);
            label5.Name = "label5";
            label5.Size = new Size(120, 16);
            label5.TabIndex = 2;
            label5.Text = "Enrollment no";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label4.Location = new Point(116, 187);
            label4.Name = "label4";
            label4.Size = new Size(168, 16);
            label4.TabIndex = 1;
            label4.Text = "Student Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label3.Location = new Point(129, 29);
            label3.Name = "label3";
            label3.Size = new Size(113, 16);
            label3.TabIndex = 0;
            label3.Text = "Student Name";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.OldLace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(905, 241);
            dataGridView1.TabIndex = 10;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(706, 108);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(381, 111);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(210, 27);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label2.Location = new Point(196, 117);
            label2.Name = "label2";
            label2.Size = new Size(113, 16);
            label2.TabIndex = 7;
            label2.Text = "Student Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.OldLace;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(25, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 107);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(612, 34);
            label1.Name = "label1";
            label1.Size = new Size(227, 34);
            label1.TabIndex = 1;
            label1.Text = "View Student";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(356, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ViewStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(942, 678);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(txtSearch);
            Controls.Add(label2);
            Controls.Add(panel1);
            MaximumSize = new Size(960, 725);
            MinimumSize = new Size(960, 725);
            Name = "ViewStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Student";
            Load += View_Student_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private TextBox txtSEmail;
        private TextBox txtSContact;
        private TextBox txtSDep;
        private TextBox txtSEnroll;
        private TextBox txtSName;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox txtSearch;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtSSem;
        private Button Update;
        private Button cancel;
        private Button delete;
    }
}