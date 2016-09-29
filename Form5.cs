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
    public partial class Form5 : Form
    {
        string usermain;
        public Form5(string username)
        {
            InitializeComponent();
            usermain = username;
            timer1.Start();
        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3(usermain);
            f3.ShowDialog();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.DesktopLocation = new Point(300, 130);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            string constring = "datasource=localhost;port=3306;username=root;password=mysql";
            string Query = "update travel.hotelbk set location='" + this.dwhere.Text + "',checkin='" + this.dateTimePicker1.Text + "',checkout='" + this.dateTimePicker2.Text + "',bookingtime='" + this.label7.Text + "',nofr='" + this.nofr.Text + "',adultr1='" + this.adultr1.Text + "',childrenr1='" + this.childrenr1.Text + "',typer1='" + this.typer1.Text + "',bedr1='" + this.bedr1.Text + "',adultr2='" + this.adultr2.Text + "',childrenr2='" + this.childrenr2.Text + "',typer2='" + this.typer2.Text + "',bedr2='" + this.bedr2.Text + "',adultr3='" + this.adultr3.Text + "',childrenr3='" + this.childrenr3.Text + "',typer3='" + this.typer3.Text + "',bedr3='" + this.bedr3.Text + "',adultr4='" + this.adultr4.Text + "',childrenr4='" + this.childrenr4.Text + "',typer4='" + this.typer4.Text + "',bedr4='" + this.bedr4.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {

                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Form7 f7 = new Form7(usermain,dwhere.Text);
            f7.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.label7.Text = dateTime.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nofr.SelectedIndex+1 == 1)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
    

            } if (nofr.SelectedIndex+1 == 2)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
      

            } if (nofr.SelectedIndex+1 == 3)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = false;

            } if (nofr.SelectedIndex+1 == 4)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
               
       
            } 
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
