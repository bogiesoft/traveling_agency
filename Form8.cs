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
using System.IO;

namespace travel
{
    public partial class Form8 : Form
    {
        string usermain,bk;
        string fare;
       
        public Form8(string username,string ffare,string database)
        {
            InitializeComponent();
            textBox4.PasswordChar = '*';
            usermain = username;
            fare = ffare;
            bk = database;
        }
        
        int rnumber,rcompare;
        private void Form8_Load(object sender, EventArgs e)
        {
            this.DesktopLocation = new Point(450, 110);
            textBox1.ForeColor = Color.DarkGray;
            textBox2.ForeColor = Color.LightGray;
            payfare.Text = fare.ToString();

            Random r = new Random();
            rnumber = r.Next(1, 9);
            string constring = "datasource=localhost;port=3306;username=root;password=mysql";
            string Query = "select * from travel.captcha where idcaptcha  = '" + rnumber + "'; ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    byte[] imgg = (byte[])(myReader["img"]);
                    if (imgg == null)
                        pictureBox1.Image = null;
                    else
                    {
                        MemoryStream mstream = new MemoryStream(imgg);
                        pictureBox1.Image = System.Drawing.Image.FromStream(mstream);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if(textBox2.Text=="Name of Card Holder")
            {
                textBox2.Text = "";
            }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Name of Card Holder";
            }

        }
         
        private void button1_Click(object sender, EventArgs e)
        {

            string constring = "datasource=localhost;port=3306;username=root;password=mysql";
            string Query;
            if("flightbk"==bk)
            {
                 Query = "select * from travel.captcha where ckey = '" + textBox5.Text + "';update travel.flightbk set paymentstatus = '" + "Confirmed" + "';";
            }
            else
            {
                Query = "select * from travel.captcha where ckey = '" + textBox5.Text + "';update travel.hotelbk set paymentstatus = '" + "Confirmed" + "';";
            
            }
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    rcompare = Int32.Parse(myReader.GetString("idcaptcha"));
                    
                 }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if(rnumber==rcompare)
            {
                MessageBox.Show("Payment is Sucessfull");
                this.Hide();
                Form3 f3 = new Form3(usermain);
                f3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Entered alphabet is not correct!!! Please try again.");
            }
            
          
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            rnumber=r.Next(1,9);
            string constring = "datasource=localhost;port=3306;username=root;password=mysql";
            string Query = "select * from travel.captcha where idcaptcha  = '" + rnumber + "'; ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    byte[] imgg = (byte[])(myReader["img"]);
                    if (imgg == null)
                        pictureBox1.Image = null;
                    else
                    {
                        MemoryStream mstream = new MemoryStream(imgg);
                        pictureBox1.Image = System.Drawing.Image.FromStream(mstream);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "      -       -       -       ")
            {
                textBox1.Text = "";
            }
        }
        
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "      -       -       -       ";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
