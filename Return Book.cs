using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Library
{
    public partial class Return_Book : Form
    {
        private string bname;
        private string bdate;
        private int rowid;

        public Return_Book()
        {
            InitializeComponent();
        }

        private async void btnSearchStud_Click(object sender, EventArgs e)
        {
            try
            {
                await SearchBooksAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task SearchBooksAsync()
        {
            string enrollmentNo = txtEnroll.Text.Trim();

            using (SqlConnection con = new SqlConnection("Data Source=_JOYS\\MSSQLSERVER2022;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True"))
            {
                await con.OpenAsync();

                // Check if the student has any books to return
                string query = "SELECT * FROM IRBook WHERE std_enroll = @EnrollmentNo AND book_return_date IS NULL";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EnrollmentNo", enrollmentNo);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        await Task.Run(() => da.Fill(ds)); // Fill dataset asynchronously

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            // Display the books the student needs to return
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                        else
                        {
                            MessageBox.Show("No books found for the given enrollment number or all books have been returned.", "No Books Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridView1.DataSource = null;
                        }
                    }
                }
            }
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            try
            {
                await ReturnBookAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ReturnBookAsync()
        {
            using (SqlConnection con = new SqlConnection("Data Source=_JOYS\\MSSQLSERVER2022;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True"))
            {
                await con.OpenAsync();

                // Update the book return date
                string updateQuery = "UPDATE IRBook SET book_return_date = @ReturnDate WHERE id = @RowId";
                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@ReturnDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@RowId", rowid);

                    await cmd.ExecuteNonQueryAsync();
                }

                // Get the actual book name from the variable
                string bookName = bname;

                // Increment the available quantity in the newBook table based on book name
                int updatedQuantity = await GetUpdatedQuantityFromDatabaseAsync(bookName);

                if (updatedQuantity != -1)
                {
                    string incrementQuantityQuery = "UPDATE newBook SET bQuan = @UpdatedQuantity WHERE bName = @BookName";
                    using (SqlCommand cmd = new SqlCommand(incrementQuantityQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@BookName", bookName);
                        cmd.Parameters.AddWithValue("@UpdatedQuantity", updatedQuantity + 1);

                        await cmd.ExecuteNonQueryAsync();
                    }

                    MessageBox.Show("Return successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the DataGridView
                    await SearchBooksAsync();
                }
            }
        }


        private async Task<int> GetUpdatedQuantityFromDatabaseAsync(string bookName)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=_JOYS\\MSSQLSERVER2022;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True"))
                {
                    await con.OpenAsync();

                    string query = "SELECT bQuan FROM newBook WHERE bName = @BookName";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@BookName", bookName);

                        object result = await cmd.ExecuteScalarAsync();
                        if (result != null && int.TryParse(result.ToString(), out int updatedQuantity))
                        {
                            return updatedQuantity;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving updated quantity: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return -1; // Default value or handle the error appropriately
        }


        private async void Return_Book_Load(object sender, EventArgs e)
        {
            await Return_Book_LoadAsync(sender, e);
        }

        private async Task Return_Book_LoadAsync(object sender, EventArgs e)
        {
            panel1.Visible = false;
            txtEnroll.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is within valid row and column indices
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count &&
                e.ColumnIndex >= 0 && e.ColumnIndex < dataGridView1.Columns.Count &&
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                panel1.Visible = true;
                rowid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bdate = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtBook.Text = bname;
                txtIssue.Text = bdate;
            }
        }


        private void txtEnroll_TextChanged(object sender, EventArgs e)
        {
            if (txtEnroll.Text == "")
            {
                panel1.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtEnroll.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
