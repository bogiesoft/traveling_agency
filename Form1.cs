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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            password.PasswordChar = '*';
            password.MaxLength = 12;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=mysql";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                MySqlCommand SelectCommand = new MySqlCommand("select * from travel.customer where emailid='" + this.username_txt.Text + "' and password='" + this.password.Text + "' ; ", myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count += 1;

                }
                if(count ==1)
                {
                    MessageBox.Show("Welcome!!!");

                    this.Hide();
                    Form3 f3 = new Form3(username_txt.Text);
                    f3.Show();
                }
                else if(count > 1)
                {
                    MessageBox.Show("Duplicate user!!");

                }
                else 
                    MessageBox.Show("InCorrect");
                myConn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
           
            f2.ShowDialog();
        }

        private void username_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DesktopLocation = new Point(400, 150);
        
        }
    }
}
