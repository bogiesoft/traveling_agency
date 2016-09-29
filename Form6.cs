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
    public partial class Form6 : Form
    {
        string usermain,fare;
        int np;
        public Form6(string usernamee,int pn,string ffare)
        {
            InitializeComponent();
            usermain = usernamee;
            np = pn;
            fare = ffare;
        }
        string Gender1;
        string Gender2;
        string Gender3;
        string Gender4;
        string Gender5;
        string Gender6;
      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            Gender6 = "Female";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.DesktopLocation = new Point(400, 150);
            if (np == 1)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
                groupBox6.Visible = false;
            }
            if (np == 2)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
                groupBox6.Visible = false;
            } if (np == 3)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
                groupBox6.Visible = false;
            } if (np == 4)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = false;
                groupBox6.Visible = false;
            } if (np == 5)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = false;
            } if (np == 6)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender1 = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender1 = "Female";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Gender2 = "Male";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Gender2 = "Female";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Gender3 = "Male";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Gender3 = "Female";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Gender4 = "Male";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            Gender4 = "Female";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            Gender5 = "Male";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            Gender5 = "Female";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            Gender6 = "Male";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=mysql";
           // string Query = "insert  into travel.flightbk(p1,p1_age,p1_gender,p2,p2_age,p2_gender,p3,p3_age,p3_gender,p4,p4_age,p4_gender,p5,p5_age,p5_gender,p6,p6_age,p6_gender) values('" + p1.Text + "','" + p1_age.Text + "','" + Gender1 + "','" + p2.Text + "','" + p2_age.Text + "','" + Gender2 + "','" + p3.Text + "','" + p3_age.Text + "','" + Gender3 + "','" + p4.Text + "','" + p4_age.Text + "','" + Gender4 + "','" + p5.Text + "','" + p5_age.Text + "','" + Gender5 + "','" + p6.Text + "','" + p6_age.Text + "','" + Gender6 + "') where username = '"+usermain+"';";
            string Query = "update travel.flightbk set p1='" + p1.Text + "',p1_age='" + p1_age.Text + "',p1_gender='" + Gender1 + "',p2='" + p2.Text + "',p2_age='" + p2_age.Text + "',p2_gender='" + Gender2 + "',p3='" + p3.Text + "',p3_age='" + p3_age.Text + "',p3_gender='" + Gender3 + "',p4='" + p4.Text + "',p4_age='" + p4_age.Text + "',p4_gender='" + Gender4 + "',p5='" + p5.Text + "',p5_age='" + p5_age.Text + "',p5_gender='" + Gender5 + "',p6='" + p6.Text + "',p6_age='" + p6_age.Text + "',p6_gender='" + Gender6 + "' where username = '" + usermain + "';";
             
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Hide();
                Form8 f8 = new Form8(usermain,fare,"flightdb");
                f8.ShowDialog();
          }
           
        }
    }

