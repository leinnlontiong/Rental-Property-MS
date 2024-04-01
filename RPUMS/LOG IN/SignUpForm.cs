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
using MySql.Data.MySqlClient;

namespace RPUMS
{
    public partial class SignUpForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=rpums;sslMode=none");
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        string sql;
        public SignUpForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts
        }
        private const int cGrip = 16;
        private const int cCaption = 32;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }

                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFullname.Text) || string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrEmpty(tbPassword.Text) || string.IsNullOrEmpty(tb_pin.Text))
            {
                MessageBox.Show("Input proper information", "error");
            }
            else if (tb_pin.Text.Length < 6)
            { MessageBox.Show("PIN must be 6 digits", "Error"); }
            else
            {
                try
                {
                    con.Open();
                    sql = ("INSERT into landlord (name, username, password, pin) values ('"+tbFullname.Text+"', '"+tbUsername.Text+"', '"+tbPassword.Text+"', '"+tb_pin.Text+"')");
                    cmd = new MySqlCommand(sql, con);
                    da = new MySqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registered Succesfully");
                    Main main = new Main();
                    this.Hide();
                    main.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { con.Close(); }
            }
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_pin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { e.Handled = true; }
            if (char.IsDigit(e.KeyChar))
            {
                if (tb_pin.Text.Length == 6)
                    e.Handled = true;
            }
        }

        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            { e.Handled = true; }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            { e.Handled = true; }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            { tbPassword.UseSystemPasswordChar = false; }

            else
            { tbPassword.UseSystemPasswordChar = true; }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            { tb_pin.UseSystemPasswordChar = false; }
            else
            { tb_pin.UseSystemPasswordChar = true; }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }
    }
}
