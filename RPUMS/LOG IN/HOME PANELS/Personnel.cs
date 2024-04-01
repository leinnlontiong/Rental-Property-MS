using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPUMS.HOME_PANELS
{
    public partial class Maintenance_Personnel : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=rpums;sslMode=none");
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        string sql;
        public Maintenance_Personnel()
        {
            InitializeComponent();
            displayData();
        }
        public void displayData()
        {
            //displays datagrid
            con.Open();
            da = new MySqlDataAdapter("select * from personnel", con);
            dt = new DataTable();
            da.Fill(dt);
            dgv_personnel.DataSource = dt;
            con.Close();
        }

        private void Maintenance_Personnel_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                sql = "select * from personnel";
                cmd = new MySqlCommand(sql, con);
                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_personnel.DataSource = dt;


                //remove duplicates from datagrid
                DataTable dtremoveduplicate = new DataTable();
                da.Fill(dtremoveduplicate);
                dgv_personnel.DataSource = dtremoveduplicate;
                DataView dview = new DataView(dtremoveduplicate);
                string[] arrcolumns = { "personnel_id", "profession", "name", "contactno" };
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

        private void btn_addPeE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_profession.Text) || string.IsNullOrEmpty(tb_name.Text) || string.IsNullOrEmpty(tb_contact.Text) || string.IsNullOrEmpty(lbl_ID.Text))
            { MessageBox.Show("Input proper information", "Error"); }
            else if (tb_contact.Text.Length < 11)
            { MessageBox.Show("Input proper contact details", "Error"); }
            else
            {
                try
                {
                    con.Open();
                    sql = ("INSERT into personnel (profession,name,contactno) values ('" + tb_profession.Text + "' , '" + tb_name.Text + "' , '" + tb_contact.Text + "')");
                    cmd = new MySqlCommand(sql, con);
                    da = new MySqlDataAdapter(cmd);
                    dt = new DataTable();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Information Succesfully Added");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { con.Close(); }
                Maintenance_Personnel_Load(sender, e);
            }
        }

        private void btn_updatePeE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_profession.Text) || string.IsNullOrEmpty(tb_name.Text) || string.IsNullOrEmpty(tb_contact.Text) || lbl_ID.Text == "...")
            { MessageBox.Show("Input proper information", "Error"); }
            else if (tb_contact.Text.Length < 11)
            { MessageBox.Show("Input proper contact details", "Error"); }
            else
            {
                try
                {
                    con.Open();
                    sql = "update personnel set profession= '" + tb_profession.Text + "' , name='" + tb_name.Text + "' , contactno='" + tb_contact.Text + "' where personnel_id= '" + lbl_ID.Text + "'";
                    cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Information Succesfully Updated.");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { con.Close(); }
                Maintenance_Personnel_Load(sender, e);
            }
        }

        private void btn_deleteTD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_profession.Text) || string.IsNullOrEmpty(tb_name.Text) || string.IsNullOrEmpty(tb_contact.Text) || lbl_ID.Text == "...")
            { MessageBox.Show("Input proper information", "Error"); }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        sql = "delete from personnel where personnel_id= '" + lbl_ID.Text + "'";
                        cmd = new MySqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Information Succesfully Deleted.");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    finally { con.Close(); }
                    Maintenance_Personnel_Load(sender, e);
                }
            }
        }

        private void dgv_personnel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_ID.Text = dgv_personnel.CurrentRow.Cells[0].Value.ToString();
            tb_profession.Text = dgv_personnel.CurrentRow.Cells[1].Value.ToString();
            tb_name.Text = dgv_personnel.CurrentRow.Cells[2].Value.ToString();
            tb_contact.Text = dgv_personnel.CurrentRow.Cells[3].Value.ToString();
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

        private void tb_profession_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            { e.Handled = true; }
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            if (cob_filter.Text == "Personnel ID")
            {
                da = new MySqlDataAdapter("select personnel_id, profession, name, contactno from personnel where personnel_id like '" + tb_search.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_personnel.DataSource = dt;
            }
            else if (cob_filter.Text == "Profession")
            {
                da = new MySqlDataAdapter("select personnel_id, profession, name, contactno from personnel where profession like '" + tb_search.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_personnel.DataSource = dt;
            }
            else if (cob_filter.Text == "Name")
            {
                da = new MySqlDataAdapter("select personnel_id, profession, name, contactno from personnel where name like '" + tb_search.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_personnel.DataSource = dt;
            }
            else if (cob_filter.Text == "Contact No.")
            {
                da = new MySqlDataAdapter("select personnel_id, profession, name, contactno from personnel where contactno like '" + tb_search.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_personnel.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_ID.Text = string.Empty;
            tb_profession.Clear();
            tb_name.Clear();
            tb_contact.Clear();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                sql = "select * from personnel";
                cmd = new MySqlCommand(sql, con);
                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_personnel.DataSource = dt;


                //remove duplicates from datagrid
                DataTable dtremoveduplicate = new DataTable();
                da.Fill(dtremoveduplicate);
                dgv_personnel.DataSource = dtremoveduplicate;
                DataView dview = new DataView(dtremoveduplicate);
                string[] arrcolumns = { "personnel_id", "profession", "name", "contactno" };
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
    }
}

