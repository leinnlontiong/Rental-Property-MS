using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPUMS.HOME_PANELS
{
    public partial class Unit : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=rpums;sslMode=none");
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        string sql;
        public Unit()
        {
            InitializeComponent();
            displayData();
        }

        public void displayData()
        {
            //displays datagrid
            con.Open();
            da = new MySqlDataAdapter("select * from unit", con);
            dt = new DataTable();
            da.Fill(dt);
            dgv_unit.DataSource = dt;
            con.Close();
        }


        private void Unit_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                sql = "select * from unit";
                cmd = new MySqlCommand(sql, con);
                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_unit.DataSource = dt;


                //remove duplicates from datagrid
                DataTable dtremoveduplicate = new DataTable();
                da.Fill(dtremoveduplicate);
                dgv_unit.DataSource = dtremoveduplicate;
                DataView dview = new DataView(dtremoveduplicate);
                string[] arrcolumns = { "unit_id", "status", "type","unit", "monthly_rent"};
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_updateU_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cob_status.Text) || string.IsNullOrEmpty(tb_rent.Text))
            { MessageBox.Show("Input proper information", "Error"); }
            else
            {
                try
                {
                    con.Open();
                    sql = "update unit set status= '" + cob_status.Text +"' , monthly_rent='"+tb_rent.Text+"' where unit_id= '" + lbl_ID.Text + "'";
                    cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Information Succesfully Updated.");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { con.Close(); }
                Unit_Load(sender, e);
            }
        }

        private void dgv_unit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_ID.Text = dgv_unit.CurrentRow.Cells[0].Value.ToString();
            cob_status.Text = dgv_unit.CurrentRow.Cells[1].Value.ToString();
            lbl_type.Text = dgv_unit.CurrentRow.Cells[2].Value.ToString();
            lbl_no.Text = dgv_unit.CurrentRow.Cells[3].Value.ToString();
            tb_rent.Text = dgv_unit.CurrentRow.Cells[4].Value.ToString();
        }

        private void tb_search_TextChanged_1(object sender, EventArgs e)
        {
            if (cob_filter.Text == "Unit ID")
            {
                da = new MySqlDataAdapter("select unit_id, status, type, unit, monthly_rent from unit where unit_id like '" + tb_search.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_unit.DataSource = dt;
            }
            else if (cob_filter.Text == "Status")
            {
                da = new MySqlDataAdapter("select unit_id, status, type, unit, monthly_rent from unit where status like '" + tb_search.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_unit.DataSource = dt;
            }
            else if (cob_filter.Text == "Type")
            {
                da = new MySqlDataAdapter("select unit_id, status, type, unit, monthly_rent from unit where type like '" + tb_search.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_unit.DataSource = dt;
            }
            else if (cob_filter.Text == "Unit")
            {
                da = new MySqlDataAdapter("select unit_id, status, type, unit, monthly_rent from unit where unit like '" + tb_search.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_unit.DataSource = dt;
            }
            else if (cob_filter.Text == "Monthly Rent")
            {
                da = new MySqlDataAdapter("select unit_id, status, type, unit, monthly_rent from unit where monthly_rent like '" + tb_search.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_unit.DataSource = dt;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                sql = "select * from unit";
                cmd = new MySqlCommand(sql, con);
                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_unit.DataSource = dt;


                //remove duplicates from datagrid
                DataTable dtremoveduplicate = new DataTable();
                da.Fill(dtremoveduplicate);
                dgv_unit.DataSource = dtremoveduplicate;
                DataView dview = new DataView(dtremoveduplicate);
                string[] arrcolumns = { "unit_id", "status", "type", "unit", "monthly_rent" };
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

        private void tb_rent_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_ID.Text = string.Empty;
            cob_status.Items.Clear();
            lbl_type.Text = string.Empty;
            lbl_no.Text = string.Empty;
            tb_rent.Clear();
        }

        private void cob_filter_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
