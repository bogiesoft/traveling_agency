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
    public partial class Form7 : Form
    {
        string usermain,location,name,fare,address,contactinfo;
        public Form7(string username,string dwhere)
        {
            InitializeComponent();
            usermain = username;
            location = dwhere;
            
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.DesktopLocation = new Point(150, 50);
            radioButton1.Checked = true;
            radioButton3.Checked = true;

            string constring = "datasource=localhost;port=3306;username=root;password=mysql";
            string Query = "select * from travel.hoteldb where  location = '" + location + "'; ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while(myReader.Read())
                {
                    string snameh1 = myReader.GetString("nameh1");
                    string sdescriptionh1 = myReader.GetString("descriptionh1");
                    string saddressh1 = myReader.GetString("addressh1");
                    string scontactinfoh1 = myReader.GetString("contactinfoh1");
                    string sfareprh1 = myReader.GetString("fareprh1");
                    nameh1.Text = snameh1;
                    descriptionh1.Text = sdescriptionh1;
                    addressh1.Text = saddressh1;
                    contactinfoh1.Text = scontactinfoh1;
                    fareprh1.Text = sfareprh1;
                    string snameh2 = myReader.GetString("nameh2");
                    string sdescriptionh2 = myReader.GetString("descriptionh2");
                    string saddressh2 = myReader.GetString("addressh2");
                    string scontactinfoh2 = myReader.GetString("contactinfoh2");
                    string sfareprh2 = myReader.GetString("fareprh2");
                    nameh2.Text = snameh2;
                    descriptionh2.Text = sdescriptionh2;
                    addressh2.Text = saddressh2;
                    contactinfoh2.Text = scontactinfoh2;
                    fareprh2.Text = sfareprh2;

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void descriptionh2_Click(object sender, EventArgs e)
        {

        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=mysql";
            string Query = "select * from travel.hoteldb where  location = '" + location + "'; ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while(myReader.Read())
                {
                    byte[] imgg = (byte[])(myReader["h1img1"]);
                    if(imgg==null)
                        pictureBox1.Image=null;
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=mysql";
            string Query = "select * from travel.hoteldb where  location = '" + location + "'; ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while(myReader.Read())
                {
                    byte[] imgg = (byte[])(myReader["h1img2"]);
                    if(imgg==null)
                        pictureBox1.Image=null;
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
             string constring = "datasource=localhost;port=3306;username=root;password=mysql";
            string Query = "select * from travel.hoteldb where  location = '" + location + "'; ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while(myReader.Read())
                {
                    byte[] imgg = (byte[])(myReader["h2img1"]);
                    if(imgg==null)
                        pictureBox1.Image=null;
                    else
                    {
                        MemoryStream mstream = new MemoryStream(imgg);
                        pictureBox2.Image = System.Drawing.Image.FromStream(mstream);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
             string constring = "datasource=localhost;port=3306;username=root;password=mysql";
            string Query = "select * from travel.hoteldb where  location = '" + location + "'; ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while(myReader.Read())
                {
                    byte[] imgg = (byte[])(myReader["h2img2"]);
                    if(imgg==null)
                        pictureBox1.Image=null;
                    else
                    {
                        MemoryStream mstream = new MemoryStream(imgg);
                        pictureBox2.Image = System.Drawing.Image.FromStream(mstream);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            string constring = "datasource=localhost;port=3306;username=root;password=mysql";
            string Query = "update travel.hotelbk set hotelname='" + name + "', totalfare = '" + fare + "',address = '" + address + "',contactinfo = '" + contactinfo + "';";
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
            Form8 f8 = new Form8(usermain,fare,"hoteldb");
            f8.ShowDialog();
        }

        private void descriptionh1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            name = nameh1.Text;
            fare = fareprh1.Text;
            address = addressh1.Text;
            contactinfo = contactinfoh1.Text;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            name = nameh2.Text;
            fare = fareprh2.Text;
            address = addressh2.Text;
            contactinfo = contactinfoh2.Text;
        }
    }
}
