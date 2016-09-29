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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            passwordtxt.PasswordChar = '*';
            cpasswordtxt.PasswordChar = '*';
        }
        string gender;
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (passwordtxt.Text == cpasswordtxt.Text)
            {
                string constring = "datasource=localhost;port=3306;username=root;password=mysql";
                string Query = "insert  into travel.customer (idcustomer,name,password,address,mobileno,emailid,dob,gender) values(NULL,'" + this.nametxt.Text + "','" + this.passwordtxt.Text + "','" + this.addtxt.Text + "','" + this.mobnotxt.Text + "','" + this.emailidtxt.Text + "','" + this.dateTimePicker1.Text + "','" + gender + "');insert into travel.flightbk (bookingid,username) values(NULL,'" + this.emailidtxt.Text + "'); insert into travel.hotelbk (idhotelbk,username) values(NULL,'" + this.emailidtxt.Text + "');";
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
                    
                    MessageBox.Show("Now you have Successfully Signed UP!!!!");
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else 
            {
                MessageBox.Show("Confirm Password doesn't Match");
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;


            }
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.DesktopLocation = new Point(400, 150);
            Point p = new Point(400, 150);
            Size s = new Size(500, 500);
            this.DesktopBounds = new Rectangle(p, s);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }
    }
}
