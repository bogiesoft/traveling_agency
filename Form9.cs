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
    public partial class Form9 : Form
    {
        string usermain;
        public Form9(string username)
        {
            InitializeComponent();
            usermain = username;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            this.DesktopLocation = new Point(450, 110);
            string constring = "datasource=localhost;port=3306;username=root;password=mysql";
            string Query = "select * from travel.customer where  emailid = '" + usermain + "'; ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    string  name = myReader.GetString("name");
                    string  username = myReader.GetString("emailid");
                    string  mobileno = myReader.GetString("mobileno");
                    string  gender = myReader.GetString("gender");
                    string  dob = myReader.GetString("dob");
                    string  address = myReader.GetString("address");
                    l1.Text = name;
                    l2.Text = username;
                    l3.Text = gender;
                    l4.Text = dob;
                    l5.Text = mobileno;
                    l6.Text = address;


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
            Form3 f3 = new Form3(usermain);
            f3.Show();
        }
    }
}
