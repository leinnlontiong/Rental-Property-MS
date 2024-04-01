using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RPUMS.HOME_PANELS
{
    public partial class Payment : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=rpums;sslMode=none;Convert Zero Datetime=True");
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        string sql;
        string status;

        public Payment()
        {
            InitializeComponent();
            displayData();
        }

        public void displayData()
        {
            //displays datagrid
            con.Open();
            da = new MySqlDataAdapter("select * from payment", con);
            dt = new DataTable();
            da.Fill(dt);
            dgv_payment.DataSource = dt;
            con.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                sql = "select * from payment";
                cmd = new MySqlCommand(sql, con);
                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_payment.DataSource = dt;


                //remove duplicates from datagrid
                DataTable dtremoveduplicate = new DataTable();
                da.Fill(dtremoveduplicate);
                dgv_payment.DataSource = dtremoveduplicate;
                DataView dview = new DataView(dtremoveduplicate);
                string[] arrcolumns = { "payment_id", "tenant_id", "status", "balance", "due" };
                dtremoveduplicate = dview.ToTable(true, arrcolumns);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            dtp_due.Format = DateTimePickerFormat.Short;
            dtp_due.Value = DateTime.Today;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            status = "Paid";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            status = "Unpaid";
        }

        private void btn_addPaE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_tid.Text) || string.IsNullOrEmpty(tb_balance.Text))
            {
                MessageBox.Show("Input proper information", "Error");
                return;
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into payment (tenant_id, status, balance, due) values (@tenant_id, @status, @balance, @due)", con);
                cmd.Parameters.AddWithValue("@tenant_id", tb_tid.Text);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@balance", tb_balance.Text);
                cmd.Parameters.AddWithValue("@due", dtp_due.Value);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Information Successfully Added");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { con.Close(); }
            Payment_Load(sender, e);
        }

        private void btn_updatePaE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_tid.Text) || string.IsNullOrEmpty(tb_balance.Text))
            {
                MessageBox.Show("Input proper information", "Error");
                return;
            }
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE payment SET tenant_id = @tenant_id, status = @status, balance = @balance, due = @due WHERE payment_id = @payment_id", con);
                cmd.Parameters.AddWithValue("@tenant_id", tb_tid.Text);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@balance", tb_balance.Text);
                cmd.Parameters.AddWithValue("@due", dtp_due.Value);
                cmd.Parameters.AddWithValue("@payment_id", lbl_ID.Text);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Information successfully updated");
                }
                else
                {
                    MessageBox.Show("No rows updated");
                }
            }
            catch (Exception ex)
            {MessageBox.Show("Error updating information: " + ex.Message);}
            finally { con.Close(); }
            Payment_Load(sender, e);
        }

        private void tb_balance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { e.Handled = true; }
        }

        private void tb_search_TextChanged_1(object sender, EventArgs e)
        {   
            if (cob_filter.Text == "Payment ID")
            {
                da = new MySqlDataAdapter("select payment_id, tenant_id, status, balance, due from payment where payment_id like '" + tb_search.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_payment.DataSource = dt;
            }
            else if (cob_filter.Text == "Tenant ID")
            {
                da = new MySqlDataAdapter("select payment_id, tenant_id, status, balance, due from payment where tenant_id like '" + tb_search.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_payment.DataSource = dt;
            }
            else if (cob_filter.Text == "Status")
            {
                da = new MySqlDataAdapter("select payment_id, tenant_id, status, balance, due from payment where status like '" + tb_search.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_payment.DataSource = dt;
            }
            else if (cob_filter.Text == "Balance")
            {
                da = new MySqlDataAdapter("select payment_id, tenant_id, status, balance, due from payment where balance like '" + tb_search.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_payment.DataSource = dt;
            }
            else if (cob_filter.Text == "Due")
            {
                da = new MySqlDataAdapter("select payment_id, tenant_id, status, balance, due from payment where due like '" + tb_search.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_payment.DataSource = dt;
            }
        }

        private void dgv_payment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_ID.Text = dgv_payment.CurrentRow.Cells[0].Value.ToString();
            tb_tid.Text = dgv_payment.CurrentRow.Cells[1].Value.ToString();
            tb_balance.Text = dgv_payment.CurrentRow.Cells[3].Value.ToString();
            string dueDateString = dgv_payment.CurrentRow.Cells[4].Value.ToString();
            DateTime dueDate = DateTime.Parse(dueDateString);
            dtp_due.Value = dueDate;
            string status = dgv_payment.CurrentRow.Cells[2].Value.ToString();
            if (status == "Paid")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            else
            {
                radioButton2.Checked = true;
                radioButton1.Checked = false;
            }

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                sql = "select * from payment";
                cmd = new MySqlCommand(sql, con);
                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_payment.DataSource = dt;


                //remove duplicates from datagrid
                DataTable dtremoveduplicate = new DataTable();
                da.Fill(dtremoveduplicate);
                dgv_payment.DataSource = dtremoveduplicate;
                DataView dview = new DataView(dtremoveduplicate);
                string[] arrcolumns = { "payment_id", "tenant_id", "status", "balance", "due" };
                dtremoveduplicate = dview.ToTable(true, arrcolumns);

                cob_filter.Text = string.Empty;
                tb_search.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            dtp_due.Format = DateTimePickerFormat.Short;
            dtp_due.Value = DateTime.Today;
        }

        private void dgv_payment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lbl_ID.Text = string.Empty;
            tb_tid.Clear();
            tb_balance.Clear();
            dtp_due.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void tb_tid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { e.Handled = true; }
            if (char.IsDigit(e.KeyChar))
            {
                if (tb_tid.Text.Length == 2)
                    e.Handled = true;
            }
        }
    }
}
