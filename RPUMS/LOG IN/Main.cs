using MySql.Data.MySqlClient;
using RPUMS.HOME_PANELS;
using System;
using System.Windows.Forms;

namespace RPUMS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Home h = new Home();
            h.TopLevel = false;
            panel11.Controls.Add(h);
            h.BringToFront();
            h.Show();

            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Home h = new Home();
            h.TopLevel = false;
            panel11.Controls.Add(h);
            h.BringToFront();
            h.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_tenant_Click(object sender, EventArgs e)
        {
            Tenant t = new Tenant();
            t.TopLevel = false;
            panel11.Controls.Add(t);
            t.BringToFront();
            t.Show();
        }

        private void btn_unit_Click(object sender, EventArgs e)
        {
            Unit u = new Unit();
            u.TopLevel = false;
            panel11.Controls.Add(u);
            u.BringToFront();
            u.Show();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            Payment pa = new Payment();
            pa.TopLevel = false;
            panel11.Controls.Add(pa);
            pa.BringToFront();
            pa.Show();
        }

        private void btn_personnel_Click(object sender, EventArgs e)
        {
            Maintenance_Personnel pe = new Maintenance_Personnel();
            pe.TopLevel = false;
            panel11.Controls.Add(pe);
            pe.BringToFront();
            pe.Show();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Close();
            login.Show();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_admin_Click_1(object sender, EventArgs e)
        {
            AboutUs a = new AboutUs();
            a.TopLevel = false;
            panel11.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }
    }
}
