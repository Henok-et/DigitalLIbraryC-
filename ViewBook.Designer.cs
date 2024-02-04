namespace Digital_Library
{
    partial class ViewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtSearch = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtPurchaseDate = new DateTimePicker();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtpub = new TextBox();
            txtAuthor = new TextBox();
            txtName = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OldLace;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(6, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 106);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 20F, FontStyle.Italic);
            label1.Location = new Point(397, 47);
            label1.Name = "label1";
            label1.Size = new Size(192, 38);
            label1.TabIndex = 1;
            label1.Text = "View Book";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(195, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label2.Location = new Point(209, 119);
            label2.Name = "label2";
            label2.Size = new Size(89, 16);
            label2.TabIndex = 1;
            label2.Text = "Book Name";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(394, 113);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(263, 27);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Algerian", 9F, FontStyle.Italic);
            button1.Location = new Point(719, 110);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.OldLace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(925, 236);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(txtPurchaseDate);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(txtpub);
            panel2.Controls.Add(txtAuthor);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(6, 406);
            panel2.Name = "panel2";
            panel2.Size = new Size(925, 246);
            panel2.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Algerian", 9F, FontStyle.Italic);
            btnCancel.Location = new Point(759, 210);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Algerian", 9F, FontStyle.Italic);
            btnDelete.Location = new Point(628, 210);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Algerian", 9F, FontStyle.Italic);
            btnUpdate.Location = new Point(503, 210);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtPurchaseDate
            // 
            txtPurchaseDate.Location = new Point(628, 17);
            txtPurchaseDate.Name = "txtPurchaseDate";
            txtPurchaseDate.Size = new Size(243, 27);
            txtPurchaseDate.TabIndex = 11;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(628, 164);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(225, 27);
            txtQuantity.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(628, 86);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(225, 27);
            txtPrice.TabIndex = 9;
            // 
            // txtpub
            // 
            txtpub.Location = new Point(321, 164);
            txtpub.Name = "txtpub";
            txtpub.Size = new Size(125, 27);
            txtpub.TabIndex = 8;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(321, 87);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(125, 27);
            txtAuthor.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(321, 24);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label8.Location = new Point(457, 182);
            label8.Name = "label8";
            label8.Size = new Size(0, 16);
            label8.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label9.Location = new Point(463, 170);
            label9.Name = "label9";
            label9.Size = new Size(121, 16);
            label9.TabIndex = 4;
            label9.Text = "Book Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label7.Location = new Point(457, 97);
            label7.Name = "label7";
            label7.Size = new Size(91, 16);
            label7.TabIndex = 4;
            label7.Text = "Book Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label6.Location = new Point(457, 24);
            label6.Name = "label6";
            label6.Size = new Size(165, 16);
            label6.TabIndex = 3;
            label6.Text = "Book Purchase Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label5.Location = new Point(147, 162);
            label5.Name = "label5";
            label5.Size = new Size(146, 16);
            label5.TabIndex = 2;
            label5.Text = "Book Publication ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label4.Location = new Point(147, 93);
            label4.Name = "label4";
            label4.Size = new Size(150, 16);
            label4.TabIndex = 1;
            label4.Text = "Book Author Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 9F, FontStyle.Italic);
            label3.Location = new Point(147, 16);
            label3.Name = "label3";
            label3.Size = new Size(89, 16);
            label3.TabIndex = 0;
            label3.Text = "Book Name";
            // 
            // ViewBook
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
            Name = "ViewBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Book";
            Load += ViewBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtSearch;
        private Button button1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private DateTimePicker txtPurchaseDate;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtpub;
        private TextBox txtAuthor;
        private TextBox txtName;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label9;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
    }
}