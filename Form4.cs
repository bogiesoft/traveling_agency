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
    public partial class Form4 : Form
    {
        string usermain;
        public Form4(string username)
        {
            InitializeComponent();
            usermain = username;
            timer1.Start();
        }
        string triptype;
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3(usermain);
            f3.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            string constring = "datasource=localhost;port=3306;username=root;password=mysql";
            //string Query = "insert  into travel.flightbk (from,to,departure,noofp,totalfare) values ('" + this.comboBox1.Text + "','" + this.comboBox2.Text + "','" + this.dateTimePicker1.Text + "','" + this.comboBox3.Text + "','" + this.label7.Text + "');";
            
            //string Query = "insert  into travel.flightbk (bookingid,username,from,to,departure,noofp,totalfare) values (NULL,'" + usermain + "','" + this.comboBox1.Text + "','" + this.comboBox2.Text + "','" + this.dateTimePicker1.Text + "','" + this.comboBox3.Text + "','" + this.label7.Text + "');";
            string Query = "update travel.flightbk set triptype='" + triptype + "',dfrom = '" + this.comboBox1.Text + "', dto = '" + this.comboBox2.Text + "',departure='" + this.dateTimePicker1.Text + "',treturn='" + this.dateTimePicker2.Text + "',bookingtime='" + label8.Text + "',class='" + this.comboBox4.Text + "',timming='" + this.comboBox5.Text + "',airline='" + this.comboBox6.Text + "',noofp='" + this.comboBox3.Text + "',totalfare='" + this.label7.Text + "' where username = '" + usermain + "';";
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
            Form6 f6 = new Form6(usermain,comboBox3.SelectedIndex+1,label7.Text);
            f6.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            string[] a=new string[10]{"Agra","Banglore","Chennai","Delhi","Goa","Hyderabad","Jammu","Kolkata","Mumbai","Pune"};
            for(int i=0;i<10;i++)
            {
            if(a[i]!=comboBox1.SelectedItem.ToString())
            {
                comboBox2.Items.Add(a[i]);
                
            }
            }
            string constring = "datasource=localhost;port=3306;username=root;password=mysql";
            string Query = "select * from travel.flightdb where tlocation = '" + comboBox1.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    string t1 = myReader.GetString("t1");
                    comboBox5.Items.Add(t1);
                    string t2 = myReader.GetString("t2");
                    comboBox5.Items.Add(t2);
                    string t3 = myReader.GetString("t3");
                    comboBox5.Items.Add(t3);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a =  Int32.Parse(comboBox3.Text);
           a = a * 2500;
            label7.Text = a.ToString();

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.label8.Text = dateTime.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label10.Visible = true;
            dateTimePicker2.Visible = true;
            triptype = "Round Trip";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label10.Visible = false;
            dateTimePicker2.Visible = false;
            triptype = "One Way";
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        
    }
}
