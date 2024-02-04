using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Digital_Library
{
    public partial class issueBook : Form
    {
        private int count;
        private const int MaximumBookLimit = 3; // Replace with your actual maximum book limit

        public issueBook()
        {
            InitializeComponent();
        }

        private void issueBook_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=_JOYS\\MSSQLSERVER2022;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                con.Open();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void searchBook_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=_JOYS\\MSSQLSERVER2022;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT bName FROM newBook WHERE bName = @BookName", con);
                cmd.Parameters.AddWithValue("@BookName", txtBName.Text.Trim());

                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {
                    // Book found, display it in the TextBox
                    while (sdr.Read())
                    {
                        txtBName.Text = sdr["bName"].ToString();
                    }

                    // Display an alert that the book is available
                    MessageBox.Show("Book is available!", "Book Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Book not found
                    MessageBox.Show("Sorry, the book couldn't be found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBName.Text = ""; // Clear the TextBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnStudSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSEnroll.Text))
            {
                string enrollmentNo = txtSEnroll.Text;

                try
                {
                    using (SqlConnection con = new SqlConnection("Data Source=_JOYS\\MSSQLSERVER2022;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True"))
                    {
                        con.Open();

                        string query = "SELECT * FROM newStudent WHERE enroll = @EnrollmentNo";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@EnrollmentNo", enrollmentNo);

                            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds);

                                cmd.CommandText = "SELECT COUNT(std_enroll) FROM IRBook WHERE std_enroll = @EnrollmentNo AND book_return_Date IS NULL";
                                SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                                DataSet DS1 = new DataSet();
                                DA1.Fill(DS1);

                                count = int.Parse(DS1.Tables[0].Rows[0][0].ToString());

                                if (ds.Tables[0].Rows.Count != 0)
                                {
                                    txtName.Text = ds.Tables[0].Rows[0]["sName"].ToString();
                                    txtDep.Text = ds.Tables[0].Rows[0]["dep"].ToString();
                                    txtSSem.Text = ds.Tables[0].Rows[0]["sem"].ToString();
                                    txtSContact.Text = ds.Tables[0].Rows[0]["contact"].ToString();
                                    txtSEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
                                }
                                else
                                {
                                    ClearTextBoxes();
                                    MessageBox.Show("Invalid Enrollment no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearTextBoxes()
        {
            txtName.Clear();
            txtDep.Clear();
            txtSSem.Clear();
            txtSContact.Clear();
            txtSEmail.Clear();
        }

        private void UpdateBookQuantity(SqlConnection con, string bookName)
        {
            try
            {
                string updateQuery = "UPDATE newBook SET bQuan = bQuan - 1 WHERE bName = @BookName";
                using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                {
                    updateCmd.Parameters.AddWithValue("@BookName", bookName);
                    updateCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating book quantity: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetBookQuantity(SqlConnection con, string bookName)
        {
            try
            {
                string query = "SELECT bQuan FROM newBook WHERE bName = @BookName";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@BookName", bookName);
                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int quantity))
                    {
                        return quantity;
                    }
                    return 0; // Return 0 if there's an issue retrieving the quantity
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting book quantity: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private int GetIssuedBookCount(SqlConnection con, string enrollmentNo)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM IRBook WHERE std_enroll = @EnrollmentNo";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EnrollmentNo", enrollmentNo);
                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int count))
                    {
                        return count;
                    }
                    return 0; // Return 0 if there's an issue retrieving the count
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting issued book count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private int GetBookIssueCountForUser(SqlConnection con, string enrollmentNo, string bookName)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM IRBook WHERE std_enroll = @EnrollmentNo AND book_name = @BookName";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EnrollmentNo", enrollmentNo);
                    cmd.Parameters.AddWithValue("@BookName", bookName);
                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int count))
                    {
                        return count;
                    }
                    return 0; // Return 0 if there's an issue retrieving the count
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting book issue count for user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private bool IsBookAvailable(SqlConnection con, string bookName)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM newBook WHERE bName = @BookName", con);
            cmd.Parameters.AddWithValue("@BookName", bookName);
            int bookCount = (int)cmd.ExecuteScalar();
            return bookCount > 0;
        }

        // Helper method to check if the user has returned all previously issued books
        private bool HasUserReturnedAllBooks(SqlConnection con, string enrollmentNo)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM IRBook WHERE std_enroll = @EnrollmentNo AND book_return_Date IS NULL";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EnrollmentNo", enrollmentNo);
                    int count = (int)cmd.ExecuteScalar();

                    // If the count is 0, it means the user has returned all books
                    return count == 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking if user has returned all books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtSEnroll.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSEnroll.Text))
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("Data Source=_JOYS\\MSSQLSERVER2022;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True"))
                    {
                        con.Open();

                        string enrollmentNo = txtSEnroll.Text.Trim();

                        // Check if the user has returned all previously issued books
                        if (HasUserReturnedAllBooks(con, enrollmentNo))
                        {
                            int issuedBookCount = GetIssuedBookCount(con, enrollmentNo);

                            // Check if the user has not reached the maximum limit (3 books)
                            if (issuedBookCount < MaximumBookLimit)
                            {
                                // Proceed with the issuing process
                                IssueBook(con, enrollmentNo);
                            }
                            else
                            {
                                MessageBox.Show($"User with Enrollment No '{enrollmentNo}' has already issued the maximum allowed books (3).", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show($"User with Enrollment No '{enrollmentNo}' has not returned all previously issued books. Cannot issue a new one.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid enrollment number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IssueBook(SqlConnection con, string enrollmentNo)
        {
            try
            {
                string bookName = txtBName.Text.Trim();

                // Check if the book exists
                if (!IsBookAvailable(con, bookName))
                {
                    MessageBox.Show($"Book '{bookName}' is not available!", "Book Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if the book is not available
                }

                // Check if the book quantity is greater than 0
                if (GetBookQuantity(con, bookName) <= 0)
                {
                    MessageBox.Show($"Book '{bookName}' is out of stock.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "INSERT INTO IRBook (std_enroll, std_name, std_dep, std_sem, std_contact, std_email, book_name, book_issue_date) " +
                                "VALUES (@EnrollmentNo, @Name, @Dep, @Sem, @Contact, @Email, @BookName, @IssueDate)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EnrollmentNo", enrollmentNo);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Dep", txtDep.Text);
                    cmd.Parameters.AddWithValue("@Sem", txtSSem.Text);
                    cmd.Parameters.AddWithValue("@Contact", txtSContact.Text);
                    cmd.Parameters.AddWithValue("@Email", txtSEmail.Text);
                    cmd.Parameters.AddWithValue("@BookName", bookName);

                    // Check for DateTimePicker value
                    DateTime issueDate = dateTimePicker1.Value;
                    if (issueDate == DateTimePicker.MinimumDateTime)
                    {
                        // If it's the minimum value, set to the current date
                        issueDate = DateTime.Now;
                    }
                    cmd.Parameters.AddWithValue("@IssueDate", issueDate);

                    cmd.ExecuteNonQuery();

                    // Decrease the book quantity in newBook table
                    UpdateBookQuantity(con, bookName);

                    MessageBox.Show("Book issued successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error issuing book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
