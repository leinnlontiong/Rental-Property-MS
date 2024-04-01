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
    public partial class Form1 : Form
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

        public Form1()
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fr3 = new SignUpForm();
            this.Hide();
            fr3.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_username.Text) || string.IsNullOrEmpty(tb_password.Text) || string.IsNullOrEmpty(tb_pin.Text))
            {
                MessageBox.Show("Enter login information", "Error");
            }
            else
            {
                try
                {
                    con.Open();
                    sql = "Select * from landlord WHERE username = '" + tb_username.Text + "' and password ='" + tb_password.Text + "' and pin= '" + tb_pin.Text + "'; ";
                    cmd = new MySqlCommand(sql, con);
                    da = new MySqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successful");
                        this.Hide();
                        Main main = new Main();
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Login Information! Try again.", "Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();

                }
            }
        }



        private void tb_password_Enter(object sender, EventArgs e)
        {
            if (tb_password.Text == "Password")
            {
                tb_password.Text = "";
                tb_password.ForeColor = Color.Black;
            }
        }

        private void tb_username_Enter(object sender, EventArgs e)
        {
            if (tb_username.Text == "Username")
            {
                tb_username.Text = "";
                tb_username.ForeColor = Color.Black;
            }
        }
        private void tb_pin_Enter(object sender, EventArgs e)
        {
            if (tb_pin.Text == "PIN")
            {
                tb_pin.Text = "";
                tb_pin.ForeColor = Color.Black;
            }
        }

        private void tb_username_Leave(object sender, EventArgs e)
        {
            if (tb_username.Text == "")
            {
                tb_username.Text = "Username";
                tb_username.ForeColor = Color.Silver;
            }
        }

        private void tb_password_Leave(object sender, EventArgs e)
        {
            if (tb_password.Text == "")
            {
                tb_password.Text = "Password";
                tb_password.ForeColor = Color.Silver;
            }
        }
        private void tb_pin_Leave(object sender, EventArgs e)
        {
            if (tb_pin.Text == "")
            {
                tb_pin.Text = "PIN";
                tb_pin.ForeColor = Color.Silver;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            { tb_password.UseSystemPasswordChar = false; }

            else
            { tb_password.UseSystemPasswordChar = true; }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            { tb_pin.UseSystemPasswordChar = false; }
            else
            { tb_pin.UseSystemPasswordChar = true; }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void tb_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            { e.Handled = true; }
        }

        private void tb_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            { e.Handled = true; }
        }
    }
}
        

    
