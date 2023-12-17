using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_test_2
{
    public partial class frmworkingspace : Form
    {
        private string connstring = String.Format("Host={0};Port={1};" +
                                                  "User Id={2};Password={3};Database={4};",
                                                  "localhost", 5432, "postgres", "7601", "postgres");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private int rowIndex = -1;

        bool exit = true;
        public frmworkingspace()
        {
            InitializeComponent();
        }
        private void frmworkingspace_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            Select();
            txbID.Enabled = txbTitle.Enabled = txbAuthor.Enabled = txbGenre.Enabled = txbEpisode.Enabled = txbQuantity.Enabled = txbPrice.Enabled = txbShelf.Enabled = false;
        }
        private void Select()
        {
            try
            {
                conn.Open();
                sql = @"select * from f_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dgvListbook.DataSource = null; // reset datagridview
                dgvListbook.DataSource = dt;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void dgvListbook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                txbID.Text = dgvListbook.Rows[e.RowIndex].Cells["id"].Value.ToString();
                txbTitle.Text = dgvListbook.Rows[e.RowIndex].Cells["title"].Value.ToString();
                txbAuthor.Text = dgvListbook.Rows[e.RowIndex].Cells["author"].Value.ToString();
                txbGenre.Text = dgvListbook.Rows[e.RowIndex].Cells["genre"].Value.ToString();
                txbEpisode.Text = dgvListbook.Rows[e.RowIndex].Cells["episode"].Value.ToString();
                txbQuantity.Text = dgvListbook.Rows[e.RowIndex].Cells["quantity"].Value.ToString();
                txbPrice.Text = dgvListbook.Rows[e.RowIndex].Cells["price"].Value.ToString();
                txbShelf.Text = dgvListbook.Rows[e.RowIndex].Cells["shelf"].Value.ToString();
            }
            txbID.Enabled = txbTitle.Enabled = txbAuthor.Enabled = txbGenre.Enabled = txbEpisode.Enabled = txbQuantity.Enabled = txbPrice.Enabled = txbShelf.Enabled = false;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            rowIndex = -1;
            txbID.Enabled = txbTitle.Enabled = txbAuthor.Enabled = txbGenre.Enabled = txbEpisode.Enabled = txbQuantity.Enabled = txbPrice.Enabled = txbShelf.Enabled = true;
            txbID.Text = txbTitle.Text = txbAuthor.Text = txbGenre.Text = txbEpisode.Text = txbQuantity.Text = txbPrice.Text = txbShelf.Text = null;
            txbTitle.Select();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Please choose book to update");
                return;
            }
            txbID.Enabled = txbTitle.Enabled = txbAuthor.Enabled = txbGenre.Enabled = txbEpisode.Enabled = txbQuantity.Enabled = txbPrice.Enabled = txbShelf.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Please choose book to delete");
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from f_delete(:_id)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", int.Parse(dgvListbook.Rows[rowIndex].Cells["id"].Value.ToString()));
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Delete human successfully");
                    rowIndex = -1;
                    Select();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("delete fail. Error: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (rowIndex < 0) // insert
            {
                try
                {
                    conn.Open();
                    sql = @"select * from f_insert(:_title, :_author, :_genre, :_episode, :_quantity, :_price, :_shelf)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_title", txbTitle.Text);
                    cmd.Parameters.AddWithValue("_author", txbAuthor.Text);
                    cmd.Parameters.AddWithValue("_genre", txbGenre.Text);
                    cmd.Parameters.AddWithValue("_episode", txbEpisode.Text);
                    cmd.Parameters.AddWithValue("_quantity", txbQuantity.Text);
                    cmd.Parameters.AddWithValue("_price", txbPrice.Text);
                    cmd.Parameters.AddWithValue("_shelf", txbShelf.Text);
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Inserted successfully");
                        Select();
                    }
                    else
                    {
                        MessageBox.Show("Inserted fail");
                    }
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Inserted fail. Error: " + ex.Message);
                }
            }
            else // update
            {
                try
                {
                    conn.Open();
                    sql = @"select * from f_update(:_id, :_title, :_author, :_genre, :_episode, :_quantity, :_price, :_shelf)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id", int.Parse(dgvListbook.Rows[rowIndex].Cells["id"].Value.ToString()));
                    cmd.Parameters.AddWithValue("_title", txbTitle.Text);
                    cmd.Parameters.AddWithValue("_author", txbAuthor.Text);
                    cmd.Parameters.AddWithValue("_genre", txbGenre.Text);
                    cmd.Parameters.AddWithValue("_episode", txbEpisode.Text);
                    cmd.Parameters.AddWithValue("_quantity", txbQuantity.Text);
                    cmd.Parameters.AddWithValue("_price", txbPrice.Text );
                    cmd.Parameters.AddWithValue("_shelf", txbShelf.Text);
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Updated successfully");
                        Select();
                    }
                    else
                    {
                        MessageBox.Show("Updated fail");
                    }
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Updated fail" + ex.Message);
                }
            }
            result = 0;
            txbID.Enabled = txbTitle.Enabled = txbAuthor.Enabled = txbGenre.Enabled = txbEpisode.Enabled = txbQuantity.Enabled = txbPrice.Enabled = txbShelf.Enabled = false;
            txbID.Text = txbTitle.Text = txbAuthor.Text = txbGenre.Text = txbEpisode.Text = txbQuantity.Text = txbPrice.Text = txbShelf.Text = null;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            exit = false;
            MessageBox.Show("Loging out?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            frmLogin form = new frmLogin();
            this.Close();
            form.Show();
        }
        private void frmworkingspace_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (exit) 
            Application.Exit();
        }

        private void frmworkingspace_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit)
            if (MessageBox.Show("You're closing the program?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
        }
        private void searchingresult()
        {
            try
            {
                conn.Open();
                sql = @"Select * from f_select() where title LIKE '%" + txbTitle.Text + "%'";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dgvListbook.DataSource = null;
                dgvListbook.DataSource = dt;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ckbSearchbytitle_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSearchbytitle.Checked)
            {
                txbTitle.Enabled = true;
            }
            txbID.Text = txbTitle.Text = txbAuthor.Text = txbGenre.Text = txbEpisode.Text = txbQuantity.Text = txbPrice.Text = txbShelf.Text = null;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchingresult();
            ckbSearchbytitle.Checked = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Select();
        }
    }
}
