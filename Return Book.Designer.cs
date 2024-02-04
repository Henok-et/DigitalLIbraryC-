namespace Digital_Library
{
    partial class Return_Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Return_Book));
            panel3 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtEnroll = new TextBox();
            label9 = new Label();
            button6 = new Button();
            button4 = new Button();
            button3 = new Button();
            button7 = new Button();
            button5 = new Button();
            button2 = new Button();
            btnSearchStud = new Button();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button9 = new Button();
            button8 = new Button();
            txtIssue = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            txtBook = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BackColor = SystemColors.ControlDark;
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Controls.Add(txtEnroll);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(btnSearchStud);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(24, 26);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(214, 465);
            panel3.TabIndex = 11;
            panel3.Paint += panel3_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(153, 359);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(7, 6);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // txtEnroll
            // 
            txtEnroll.Anchor = AnchorStyles.None;
            txtEnroll.Location = new Point(36, 182);
            txtEnroll.Margin = new Padding(3, 2, 3, 2);
            txtEnroll.Name = "txtEnroll";
            txtEnroll.Size = new Size(165, 23);
            txtEnroll.TabIndex = 2;
            txtEnroll.TextChanged += txtEnroll_TextChanged;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label9.Location = new Point(38, 156);
            label9.Name = "label9";
            label9.Size = new Size(149, 14);
            label9.TabIndex = 1;
            label9.Text = "Student Enrollment No";
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Location = new Point(-1454, 321);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(82, 22);
            button6.TabIndex = 12;
            button6.Text = "Refresh";
            button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(-1419, 229);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(82, 22);
            button4.TabIndex = 12;
            button4.Text = "Issue Book";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(-857, 260);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 12;
            button3.Text = "Issue Book";
            button3.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.None;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Algerian", 9F, FontStyle.Italic);
            button7.Location = new Point(114, 316);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(82, 22);
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
            button5.Location = new Point(18, 316);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(82, 22);
            button5.TabIndex = 12;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(-444, 206);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 12;
            button2.Text = "Issue Book";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnSearchStud
            // 
            btnSearchStud.Anchor = AnchorStyles.None;
            btnSearchStud.FlatStyle = FlatStyle.Popup;
            btnSearchStud.Font = new Font("Algerian", 9F, FontStyle.Italic);
            btnSearchStud.Location = new Point(48, 248);
            btnSearchStud.Margin = new Padding(3, 2, 3, 2);
            btnSearchStud.Name = "btnSearchStud";
            btnSearchStud.Size = new Size(128, 22);
            btnSearchStud.TabIndex = 12;
            btnSearchStud.Text = "Search Student";
            btnSearchStud.UseVisualStyleBackColor = true;
            btnSearchStud.Click += btnSearchStud_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(38, 31);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(256, 26);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(558, 260);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(txtIssue);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(txtBook);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(256, 304);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 186);
            panel1.TabIndex = 13;
            // 
            // button9
            // 
            button9.FlatStyle = FlatStyle.Popup;
            button9.Font = new Font("Algerian", 9F, FontStyle.Italic);
            button9.Location = new Point(430, 106);
            button9.Margin = new Padding(3, 2, 3, 2);
            button9.Name = "button9";
            button9.Size = new Size(82, 22);
            button9.TabIndex = 8;
            button9.Text = "Cancel";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.FlatStyle = FlatStyle.Popup;
            button8.Font = new Font("Algerian", 9F, FontStyle.Italic);
            button8.Location = new Point(430, 76);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(82, 22);
            button8.TabIndex = 7;
            button8.Text = "Return";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // txtIssue
            // 
            txtIssue.Location = new Point(187, 78);
            txtIssue.Margin = new Padding(3, 2, 3, 2);
            txtIssue.Name = "txtIssue";
            txtIssue.Size = new Size(230, 23);
            txtIssue.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(187, 107);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(230, 23);
            dateTimePicker2.TabIndex = 5;
            // 
            // txtBook
            // 
            txtBook.Location = new Point(187, 45);
            txtBook.Margin = new Padding(3, 2, 3, 2);
            txtBook.Name = "txtBook";
            txtBook.Size = new Size(230, 23);
            txtBook.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label4.Location = new Point(52, 111);
            label4.Name = "label4";
            label4.Size = new Size(117, 14);
            label4.TabIndex = 2;
            label4.Text = "Book Return Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label3.Location = new Point(52, 80);
            label3.Name = "label3";
            label3.Size = new Size(105, 14);
            label3.TabIndex = 1;
            label3.Text = "Book Issue Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label2.Location = new Point(52, 47);
            label2.Name = "label2";
            label2.Size = new Size(72, 14);
            label2.TabIndex = 0;
            label2.Text = "Book Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 14;
            // 
            // Return_Book
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(826, 509);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(842, 553);
            MinimumSize = new Size(842, 548);
            Name = "Return_Book";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Return Book";
            Load += Return_Book_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private TextBox txtEnroll;
        private Label label9;
        private Button button6;
        private Button button4;
        private Button button3;
        private Button button7;
        private Button button5;
        private Button button2;
        private Button btnSearchStud;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private TextBox txtIssue;
        private DateTimePicker dateTimePicker2;
        private TextBox txtBook;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button9;
        private Button button8;
    }
}