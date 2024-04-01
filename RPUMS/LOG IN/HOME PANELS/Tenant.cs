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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace RPUMS.HOME_PANELS
{
    public partial class Tenant : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=rpums;sslMode=none");
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        string sql;
        string gender;
        public Tenant()
        {
            InitializeComponent();
            displayData();
        }
        public void displayData()
        {
            //displays datagrid
            con.Open();
            da = new MySqlDataAdapter("select * from tenant", con);
            dt = new DataTable();
            da.Fill(dt);
            dgv_tenant.DataSource = dt;
            con.Close();
        }

        private void Tenant_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                sql = "select * from tenant";
                cmd = new MySqlCommand(sql, con);
                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_tenant.DataSource = dt;


                //remove duplicates from datagrid
                DataTable dtremoveduplicate = new DataTable();
                da.Fill(dtremoveduplicate);
                dgv_tenant.DataSource = dtremoveduplicate;
                DataView dview = new DataView(dtremoveduplicate);
                string[] arrcolumns = { "tenant_id", "name", "unit_id" , "age", "gender", "contactno", "email"};
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
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void btn_addTE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_name.Text) || string.IsNullOrEmpty(tb_contact.Text) || string.IsNullOrEmpty(tb_email.Text))
            { MessageBox.Show("Input proper information", "Error"); }
            else if (tb_contact.Text.Length < 11)
            { MessageBox.Show("Input proper contact details", "Error"); }
            else
            {
                try
                {
                    con.Open();
                    sql = ("insert into tenant (name, unit_id, age, gender, contactno, email) values ('" + tb_name.Text + "' , '"+ tb_uid.Text+"', '" + cob_age.Text + "' , '" + gender + "' , '" + tb_contact.Text + "' , '" + tb_email.Text + "')");
                    cmd = new MySqlCommand(sql, con);
                    da = new MySqlDataAdapter(cmd);
                    dt = new DataTable();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Information Succesfully Added");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { con.Close(); }
                Tenant_Load(sender, e);
            }
        }

        private void btn_updateTE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_name.Text) || string.IsNullOrEmpty(cob_age.Text) || string.IsNullOrEmpty(tb_contact.Text) || string.IsNullOrEmpty(tb_email.Text))
            { MessageBox.Show("Input proper information", "Error"); }
            else if (tb_contact.Text.Length < 11)
            { MessageBox.Show("Input proper contact details", "Error"); }
            else
            {
                try
                {
                    con.Open();
                    sql = "update tenant set name= '" + tb_name.Text + "' , unit_id= '"+tb_uid.Text+"' , age='" + cob_age.Text + "' , gender= '" + gender + "' , contactno= '" + tb_contact.Text + "' , email= '" + tb_email.Text + "' where tenant_id= '" + lbl_ID.Text + "'";
                    cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Information Succesfully Updated.");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { con.Close(); }
                Tenant_Load(sender, e);
            }
        }

        private void btn_deleteTD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_name.Text) || string.IsNullOrEmpty(cob_age.Text) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(tb_contact.Text) || string.IsNullOrEmpty(tb_email.Text))
            { MessageBox.Show("Input proper information", "Error"); }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        sql = "delete from tenant where tenant_id= '" + lbl_ID.Text + "'";
                        cmd = new MySqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Information Succesfully Deleted.");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    finally { con.Close(); }
                    Tenant_Load(sender, e);
                }
            }
        }

        private void dgv_tenant_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_ID.Text = dgv_tenant.CurrentRow.Cells[0].Value.ToString();
            tb_name.Text = dgv_tenant.CurrentRow.Cells[1].Value.ToString();
            cob_age.Text = dgv_tenant.CurrentRow.Cells[2].Value.ToString();
            tb_uid.Text = dgv_tenant.CurrentRow.Cells[3].Value.ToString();
            tb_contact.Text = dgv_tenant.CurrentRow.Cells[5].Value.ToString();
            tb_email.Text = dgv_tenant.CurrentRow.Cells[6].Value.ToString();
            string gender = dgv_tenant.CurrentRow.Cells[4].Value.ToString();
            if (gender=="Male")
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

        private void tb_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { e.Handled = true; }
            if (char.IsDigit(e.KeyChar))
            {
                if (tb_contact.Text.Length == 11)
                    e.Handled = true;
            }
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            if (cob_filter.Text == "Tenant ID")
            {
                da = new MySqlDataAdapter("select tenant_id, name, age, unit_id, gender, contactno, email from tenant where tenant_id like '" + tb_search.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_tenant.DataSource = dt;
            }
            else if (cob_filter.Text == "Name")
            {
                da = new MySqlDataAdapter("select tenant_id, name, age, unit_id, gender, contactno, email from tenant where name like '" + tb_search.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_tenant.DataSource = dt;
            }
            else if (cob_filter.Text == "Age")
            {
                da = new MySqlDataAdapter("select tenant_id, name, age, unit_id, gender, contactno, email from tenant where age like '" + tb_search.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_tenant.DataSource = dt;
            }
            else if (cob_filter.Text == "Unit ID")
            {
                da = new MySqlDataAdapter("select tenant_id, name, age, unit_id, gender, contactno, email from tenant where unit_id like '" + tb_search.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_tenant.DataSource = dt;
            }
            else if (cob_filter.Text == "Gender")
            {
                da = new MySqlDataAdapter("select tenant_id, name, age, unit_id, gender, contactno, email from tenant where gender like '" + tb_search.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_tenant.DataSource = dt;
            }
            else if (cob_filter.Text == "Contact No.")
            {
                da = new MySqlDataAdapter("select tenant_id, name, age, unit_id, gender, contactno, email from tenant where contactno like '" + tb_search.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_tenant.DataSource = dt;
            }
            else if (cob_filter.Text == "Email")
            {
                da = new MySqlDataAdapter("select tenant_id, name, age, unit_id, gender, contactno, email from tenant where email like '" + tb_search.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_tenant.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_ID.Text = string.Empty;
            tb_name.Clear();
            tb_uid.Clear();
            cob_age.Items.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            tb_contact.Clear();
            tb_email.Clear();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                sql = "select * from tenant";
                cmd = new MySqlCommand(sql, con);
                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_tenant.DataSource = dt;


                //remove duplicates from datagrid
                DataTable dtremoveduplicate = new DataTable();
                da.Fill(dtremoveduplicate);
                dgv_tenant.DataSource = dtremoveduplicate;
                DataView dview = new DataView(dtremoveduplicate);
                string[] arrcolumns = { "tenant_id", "name", "unit_id", "age", "gender", "contactno", "email" };
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
        }

        private void tb_uid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { e.Handled = true; }
            if (char.IsDigit(e.KeyChar))
            {
                if (tb_contact.Text.Length == 2)
                    e.Handled = true;
            }
        }
    }
}
