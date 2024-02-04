using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Digital_Library
{
    public partial class ViewBook : Form
    {
        private int bid;
        private int rowId;

        public ViewBook()
        {
            InitializeComponent();
        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            ReloadDataGridView();
        }

        private void ReloadDataGridView()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=_JOYS\\MSSQLSERVER2022;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM newBook", con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                if (int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), out bid))
                {
                    rowId = e.RowIndex;
                }
            }
            panel2.Visible = true;

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=_JOYS\\MSSQLSERVER2022;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True"))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM newBook WHERE bid=@bid", con))
                    {
                        cmd.Parameters.AddWithValue("@bid", bid);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            rowId = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                            txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                            txtAuthor.Text = ds.Tables[0].Rows[0][2].ToString();
                            txtPrice.Text = ds.Tables[0].Rows[0][4].ToString();
                            txtpub.Text = ds.Tables[0].Rows[0][6].ToString();
                            txtQuantity.Text = ds.Tables[0].Rows[0][5].ToString();
                            txtPurchaseDate.Text = ds.Tables[0].Rows[0][3].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            panel2.Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=_JOYS\\MSSQLSERVER2022;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;

                        if (!string.IsNullOrEmpty(txtSearch.Text))
                        {
                            cmd.CommandText = "SELECT * FROM newBook WHERE bName LIKE @searchText OR bAuthor LIKE @searchText";
                            cmd.Parameters.AddWithValue("@searchText", "%" + txtSearch.Text + "%");
                        }
                        else
                        {
                            cmd.CommandText = "SELECT * FROM newBook";
                        }

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataSet ds = new DataSet();
                            da.Fill(ds);
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Updated. Confirm?", "Success", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("Data Source=_JOYS\\MSSQLSERVER2022;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True"))
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand("UPDATE newBook SET bName = @bName, bAuthor = @bAuthor, bPub = @bPub, bPrice = @price, BQuan = @quan WHERE bid = @bid", con))
                        {
                            cmd.Parameters.AddWithValue("@bid", bid);
                            cmd.Parameters.AddWithValue("@bName", txtName.Text);
                            cmd.Parameters.AddWithValue("@bAuthor", txtAuthor.Text);
                            cmd.Parameters.AddWithValue("@bPub", txtpub.Text);

                            cmd.Parameters.AddWithValue("@price", int.Parse(txtPrice.Text));
                            cmd.Parameters.AddWithValue("@quan", int.Parse(txtQuantity.Text));

                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Refresh the data grid view after updating the database
                    ReloadDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deleted. Confirm?", "Success", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("Data Source=_JOYS\\MSSQLSERVER2022;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True"))
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand("DELETE FROM newBook WHERE bid = @bid", con))
                        {
                            cmd.Parameters.AddWithValue("@bid", bid);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Refresh the data grid view after deleting from the database
                    ReloadDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to update the quantity field
        public void UpdateQuantityField(int updatedQuantity)
        {
            txtQuantity.Text = updatedQuantity.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
