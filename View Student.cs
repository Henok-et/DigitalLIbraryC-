using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Digital_Library
{
    public partial class ViewStudent : Form
    {
        int rowId;
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void View_Student_Load(object sender, EventArgs e)
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

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM newStudent", con))
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



        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                if (int.TryParse(dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString(), out rowId))
                {
                    panel2.Visible = true;

                    try
                    {
                        using (SqlConnection con = new SqlConnection("Data Source=_JOYS\\MSSQLSERVER2022;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True"))
                        {
                            using (SqlCommand cmd = new SqlCommand("SELECT * FROM newStudent WHERE studId=@studId", con))
                            {
                                cmd.Parameters.AddWithValue("@studId", rowId);

                                SqlDataAdapter da = new SqlDataAdapter(cmd);
                                DataSet ds = new DataSet();
                                da.Fill(ds);

                                if (ds.Tables[0].Rows.Count > 0)
                                {
                                    txtSName.Text = ds.Tables[0].Rows[0][1].ToString();
                                    txtSEnroll.Text = ds.Tables[0].Rows[0][2].ToString();
                                    txtSSem.Text = ds.Tables[0].Rows[0][4].ToString();
                                    txtSEmail.Text = ds.Tables[0].Rows[0][6].ToString();
                                    txtSContact.Text = ds.Tables[0].Rows[0][5].ToString();
                                    txtSDep.Text = ds.Tables[0].Rows[0][3].ToString();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error retrieving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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
                            cmd.CommandText = "SELECT * FROM newStudent WHERE sName LIKE @searchText OR enroll LIKE @searchText";
                            cmd.Parameters.AddWithValue("@searchText", "%" + txtSearch.Text + "%");
                        }
                        else
                        {
                            cmd.CommandText = "SELECT * FROM newStudent";
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

        private void cancel_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            panel2.Visible = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deleted. Confirm?", "Success", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("Data Source=_JOYS\\MSSQLSERVER2022;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True"))
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand("DELETE FROM newStudent WHERE studId = @StudId", con))
                        {
                            cmd.Parameters.AddWithValue("@StudId", rowId);

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


        private void Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Updated. Confirm?", "Success", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("Data Source=_JOYS\\MSSQLSERVER2022;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True"))
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand("UPDATE newStudent SET sName = @sName, enroll = @sEnroll, dep = @sDep, sem = @sSem, contact = @sContact, email = @sEmail WHERE studId = @StudId", con))
                        {
                            cmd.Parameters.AddWithValue("@StudId", rowId);
                            cmd.Parameters.AddWithValue("@sName", txtSName.Text);
                            cmd.Parameters.AddWithValue("@sEnroll", txtSEnroll.Text);
                            cmd.Parameters.AddWithValue("@sDep", txtSDep.Text);
                            cmd.Parameters.AddWithValue("@sSem", txtSSem.Text);
                            cmd.Parameters.AddWithValue("@sContact", int.Parse(txtSContact.Text));
                            cmd.Parameters.AddWithValue("@sEmail", txtSEmail.Text);

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

        private void txtSName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
