namespace Digital_Library
{
    partial class issueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(issueBook));
            panel1 = new Panel();
            label10 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label11 = new Label();
            searchBook = new Button();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            btnExit = new Button();
            txtBName = new TextBox();
            txtSEmail = new TextBox();
            txtSSem = new TextBox();
            txtDep = new TextBox();
            txtSContact = new TextBox();
            txtName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            txtSEnroll = new TextBox();
            label9 = new Label();
            button6 = new Button();
            button4 = new Button();
            button3 = new Button();
            button7 = new Button();
            button5 = new Button();
            button2 = new Button();
            btnStudSearch = new Button();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.OldLace;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(22, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(892, 146);
            panel1.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Algerian", 20F, FontStyle.Italic);
            label10.Location = new Point(557, 47);
            label10.Name = "label10";
            label10.Size = new Size(203, 38);
            label10.TabIndex = 12;
            label10.Text = "Issue Book";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(397, 47);
            label1.Name = "label1";
            label1.Size = new Size(0, 34);
            label1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(323, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(searchBook);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(txtBName);
            panel2.Controls.Add(txtSEmail);
            panel2.Controls.Add(txtSSem);
            panel2.Controls.Add(txtDep);
            panel2.Controls.Add(txtSContact);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(355, 177);
            panel2.Name = "panel2";
            panel2.Size = new Size(559, 475);
            panel2.TabIndex = 9;
            panel2.Paint += panel2_Paint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Algerian", 20F, FontStyle.Italic);
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(474, 38);
            label11.TabIndex = 13;
            label11.Text = "Max book allowance is 3!";
            // 
            // searchBook
            // 
            searchBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchBook.FlatStyle = FlatStyle.Popup;
            searchBook.Font = new Font("Algerian", 9F, FontStyle.Italic);
            searchBook.Location = new Point(336, 337);
            searchBook.Name = "searchBook";
            searchBook.Size = new Size(115, 29);
            searchBook.TabIndex = 15;
            searchBook.Text = "Search Book";
            searchBook.UseVisualStyleBackColor = true;
            searchBook.Click += searchBook_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(277, 374);
            dateTimePicker1.Margin = new Padding(5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(237, 27);
            dateTimePicker1.TabIndex = 14;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label8.Location = new Point(88, 385);
            label8.Margin = new Padding(5);
            label8.Name = "label8";
            label8.Size = new Size(130, 16);
            label8.TabIndex = 13;
            label8.Text = "Book Issue Date";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Algerian", 9F, FontStyle.Italic);
            btnExit.Location = new Point(336, 421);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(115, 29);
            btnExit.TabIndex = 12;
            btnExit.Text = "Issue Book";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtBName
            // 
            txtBName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBName.Location = new Point(277, 286);
            txtBName.Margin = new Padding(5);
            txtBName.Name = "txtBName";
            txtBName.Size = new Size(237, 27);
            txtBName.TabIndex = 9;
            // 
            // txtSEmail
            // 
            txtSEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSEmail.Location = new Point(277, 243);
            txtSEmail.Margin = new Padding(5);
            txtSEmail.Name = "txtSEmail";
            txtSEmail.ReadOnly = true;
            txtSEmail.Size = new Size(237, 27);
            txtSEmail.TabIndex = 8;
            // 
            // txtSSem
            // 
            txtSSem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSSem.Location = new Point(277, 161);
            txtSSem.Margin = new Padding(5);
            txtSSem.Name = "txtSSem";
            txtSSem.ReadOnly = true;
            txtSSem.Size = new Size(237, 27);
            txtSSem.TabIndex = 7;
            // 
            // txtDep
            // 
            txtDep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDep.Location = new Point(277, 109);
            txtDep.Margin = new Padding(5);
            txtDep.Name = "txtDep";
            txtDep.ReadOnly = true;
            txtDep.Size = new Size(237, 27);
            txtDep.TabIndex = 7;
            // 
            // txtSContact
            // 
            txtSContact.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSContact.Location = new Point(277, 203);
            txtSContact.Margin = new Padding(5);
            txtSContact.Name = "txtSContact";
            txtSContact.ReadOnly = true;
            txtSContact.Size = new Size(237, 27);
            txtSContact.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(277, 65);
            txtName.Margin = new Padding(5);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(237, 27);
            txtName.TabIndex = 5;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label7.Location = new Point(88, 254);
            label7.Margin = new Padding(5);
            label7.Name = "label7";
            label7.Size = new Size(108, 16);
            label7.TabIndex = 4;
            label7.Text = "Studnt Email";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label6.Location = new Point(88, 214);
            label6.Margin = new Padding(5);
            label6.Name = "label6";
            label6.Size = new Size(138, 16);
            label6.TabIndex = 3;
            label6.Text = "Student Contact";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label5.Location = new Point(88, 172);
            label5.Margin = new Padding(5);
            label5.Name = "label5";
            label5.Size = new Size(146, 16);
            label5.TabIndex = 2;
            label5.Text = "Student Semester";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label4.Location = new Point(88, 297);
            label4.Margin = new Padding(5);
            label4.Name = "label4";
            label4.Size = new Size(89, 16);
            label4.TabIndex = 1;
            label4.Text = "Book Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label3.Location = new Point(88, 120);
            label3.Margin = new Padding(5);
            label3.Name = "label3";
            label3.Size = new Size(102, 16);
            label3.TabIndex = 1;
            label3.Text = "Department";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label2.Location = new Point(88, 76);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(113, 16);
            label2.TabIndex = 0;
            label2.Text = "Student Name";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BackColor = SystemColors.ControlDark;
            panel3.Controls.Add(txtSEnroll);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(btnStudSearch);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(22, 177);
            panel3.Name = "panel3";
            panel3.Size = new Size(314, 475);
            panel3.TabIndex = 10;
            // 
            // txtSEnroll
            // 
            txtSEnroll.Anchor = AnchorStyles.None;
            txtSEnroll.Location = new Point(56, 200);
            txtSEnroll.Name = "txtSEnroll";
            txtSEnroll.Size = new Size(131, 27);
            txtSEnroll.TabIndex = 2;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label9.Location = new Point(56, 159);
            label9.Name = "label9";
            label9.Size = new Size(186, 16);
            label9.TabIndex = 1;
            label9.Text = "Student Enrollment No";
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Location = new Point(-1729, 428);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 12;
            button6.Text = "Refresh";
            button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(-1689, 305);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 12;
            button4.Text = "Issue Book";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(-1046, 347);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "Issue Book";
            button3.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.None;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Algerian", 9F, FontStyle.Italic);
            button7.Location = new Point(198, 346);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 12;
            button7.Text = "Exit";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Algerian", 9F, FontStyle.Italic);
            button5.Location = new Point(81, 345);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 12;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(-575, 275);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 12;
            button2.Text = "Issue Book";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnStudSearch
            // 
            btnStudSearch.Anchor = AnchorStyles.None;
            btnStudSearch.FlatStyle = FlatStyle.Popup;
            btnStudSearch.Font = new Font("Algerian", 9F, FontStyle.Italic);
            btnStudSearch.Location = new Point(204, 200);
            btnStudSearch.Name = "btnStudSearch";
            btnStudSearch.Size = new Size(88, 29);
            btnStudSearch.TabIndex = 12;
            btnStudSearch.Text = "Search ";
            btnStudSearch.UseVisualStyleBackColor = true;
            btnStudSearch.Click += btnStudSearch_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(56, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 104);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // issueBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Wheat;
            ClientSize = new Size(942, 678);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(960, 725);
            MinimizeBox = false;
            MinimumSize = new Size(960, 725);
            Name = "issueBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Issue Book";
            Load += issueBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnExit;
        private TextBox txtBName;
        private TextBox txtSEmail;
        private TextBox txtSSem;
        private TextBox txtDep;
        private TextBox txtSContact;
        private TextBox txtName;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private Label label10;
        private Panel panel3;
        private TextBox txtSEnroll;
        private Label label9;
        private Button button6;
        private Button button4;
        private Button button3;
        private Button button7;
        private Button button5;
        private Button button2;
        private Button btnStudSearch;
        private PictureBox pictureBox2;
        private Button searchBook;
        private Label label11;
    }
}