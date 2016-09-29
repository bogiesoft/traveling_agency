using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace travel
{
    public partial class Form3 : Form
    {
        string usermain;
        public Form3(string username)
        {
            InitializeComponent();
            usermain = username;
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("You have successfully Loged Out!!!");
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5= new Form5(usermain);
            f5.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4(usermain);
            f4.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.time_lbl.Text = dateTime.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.DesktopLocation = new Point(250, 150);
            label3.Text = usermain;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f9 = new Form9(usermain);
            f9.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 f10 = new Form10(usermain);
            f10.Show();
        }
    }
}
