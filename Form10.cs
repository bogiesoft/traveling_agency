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
    public partial class Form10 : Form
    {
        string usermain;
        public Form10(string username)
        {
            InitializeComponent();
            usermain = username;
            fillcombo();
            check();
        }

        void check()
        {
            if (usermain == "saurabh29")
            {
                comboBox1.Visible = true;
            }
            else
            {
                comboBox1.Visible = false;
            }
        }
        void fillcombo()
        {
            string constring = "datasource=localhost;port=3306;username=root;password=mysql";
            string Query = "select * from travel.customer; ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    string sname = myReader.GetString("emailid");
                    comboBox1.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form10_Load(object sender, EventArgs e)
        {
            this.DesktopLocation = new Point(380, 150);
            string constring = "datasource=localhost;port=3306;username=root;password=mysql";
            string Query = "select * from travel.flightbk where  username  = '" + usermain + "'; ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    username.Text = usermain;
                    string striptype = myReader.GetString("triptype"); triptype.Text = striptype;
                    string sdfrom = myReader.GetString("dfrom"); dfrom.Text = sdfrom;
                    string sdto = myReader.GetString("dto"); dto.Text = sdto;
                    string sdeparture = myReader.GetString("departure"); departure.Text = sdeparture;
                    string streturn = myReader.GetString("treturn"); treturn.Text = streturn;
                    string sclasss = myReader.GetString("class"); classs.Text = sclasss;
                    string stimming = myReader.GetString("timming"); timming.Text = stimming;
                    string sairline = myReader.GetString("airline"); airline.Text = sairline;
                    string sbookingtime = myReader.GetString("bookingtime"); bookingtime.Text=sbookingtime;
                    string stotalfare = myReader.GetString("totalfare"); totalfare.Text = stotalfare;
                    string sp1 = myReader.GetString("p1"); p1.Text = sp1;
                    string sp2 = myReader.GetString("p2"); p2.Text = sp2;
                    string sp3 = myReader.GetString("p3"); p3.Text = sp3;
                    string sp4 = myReader.GetString("p4"); p4.Text = sp4;
                    string sp5 = myReader.GetString("p5"); p5.Text = sp5;
                    string sp6 = myReader.GetString("p6"); p6.Text = sp6;
                    string sp1_age = myReader.GetString("p1_age"); p1_age.Text = sp1_age;
                    string sp2_age = myReader.GetString("p2_age"); p2_age.Text = sp2_age;
                    string sp3_age = myReader.GetString("p3_age"); p3_age.Text = sp3_age;
                    string sp4_age = myReader.GetString("p4_age"); p4_age.Text = sp4_age;
                    string sp5_age = myReader.GetString("p5_age"); p5_age.Text = sp5_age;
                    string sp6_age = myReader.GetString("p6_age"); p6_age.Text = sp6_age;
                    string sp1_gender = myReader.GetString("p1_gender"); p1_gender.Text = sp1_gender;
                    string sp2_gender = myReader.GetString("p2_gender"); p2_gender.Text = sp2_gender;
                    string sp3_gender = myReader.GetString("p3_gender"); p3_gender.Text = sp3_gender; 
                    string sp4_gender = myReader.GetString("p4_gender"); p4_gender.Text = sp4_gender; 
                    string sp5_gender = myReader.GetString("p5_gender"); p5_gender.Text = sp5_gender; 
                    string sp6_gender = myReader.GetString("p6_gender"); p6_gender.Text = sp6_gender;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string constring1 = "datasource=localhost;port=3306;username=root;password=mysql";
            string Query1 = "select * from travel.hotelbk where  username  = '" + usermain + "'; ";
            MySqlConnection conDataBase1 = new MySqlConnection(constring1);
            MySqlCommand cmdDataBase1 = new MySqlCommand(Query1, conDataBase1);
            MySqlDataReader myReader1;
            try
            {
                conDataBase1.Open();
                myReader1 = cmdDataBase1.ExecuteReader();
                while (myReader1.Read())
                {
                    string shotelname = myReader1.GetString("hotelname"); hotelname.Text = shotelname;
                    string saddress = myReader1.GetString("address"); address.Text = saddress;
                    string scontactinfo = myReader1.GetString("contactinfo"); contactinfo.Text = scontactinfo;
                    string slocation = myReader1.GetString("location"); location.Text = slocation;
                    string sbookingtime1 = myReader1.GetString("bookingtime"); bookingtime1.Text = sbookingtime1;
                    string stotalfare1 = myReader1.GetString("totalfare"); totalfare1.Text = stotalfare1;
                    string scheckin = myReader1.GetString("checkin"); checkin.Text = scheckin;
                    string scheckout = myReader1.GetString("checkout"); checkout.Text = scheckout;
                    string sadultr1 = myReader1.GetString("adultr1"); adultr1.Text = sadultr1;
                    string schildrenr1 = myReader1.GetString("childrenr1"); childrenr1.Text = schildrenr1;
                    string styper1 = myReader1.GetString("typer1"); typer1.Text = styper1;
                    string sbedr1 = myReader1.GetString("bedr1"); bedr1.Text = sbedr1;
                    string sadultr2 = myReader1.GetString("adultr2"); adultr2.Text = sadultr2;
                    string schildrenr2 = myReader1.GetString("childrenr2"); childrenr2.Text = schildrenr2;
                    string styper2 = myReader1.GetString("typer2"); typer2.Text = styper2;
                    string sbedr2 = myReader1.GetString("bedr2"); bedr2.Text = sbedr2;
                    string sadultr3 = myReader1.GetString("adultr3"); adultr3.Text = sadultr3;
                    string schildrenr3 = myReader1.GetString("childrenr3"); childrenr3.Text = schildrenr3;
                    string styper3 = myReader1.GetString("typer3"); typer3.Text = styper3;
                    string sbedr3 = myReader1.GetString("bedr3"); bedr3.Text = sbedr3;
                    string sadultr4 = myReader1.GetString("adultr4"); adultr4.Text = sadultr4;
                    string schildrenr4 = myReader1.GetString("childrenr4"); childrenr4.Text = schildrenr4;
                    string styper4 = myReader1.GetString("typer4"); typer4.Text = styper4;
                    string sbedr4 = myReader1.GetString("bedr4"); bedr4.Text = sbedr4;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3(usermain);
            f3.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            usermain = comboBox1.Text;
            string constring = "datasource=localhost;port=3306;username=root;password=mysql";
            string Query = "select * from travel.flightbk where  username  = '" + usermain + "'; ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    username.Text = usermain;
                    string striptype = myReader.GetString("triptype"); triptype.Text = striptype;
                    string sdfrom = myReader.GetString("dfrom"); dfrom.Text = sdfrom;
                    string sdto = myReader.GetString("dto"); dto.Text = sdto;
                    string sdeparture = myReader.GetString("departure"); departure.Text = sdeparture;
                    string streturn = myReader.GetString("treturn"); treturn.Text = streturn;
                    string sclasss = myReader.GetString("class"); classs.Text = sclasss;
                    string stimming = myReader.GetString("timming"); timming.Text = stimming;
                    string sairline = myReader.GetString("airline"); airline.Text = sairline;
                    string sbookingtime = myReader.GetString("bookingtime"); bookingtime.Text = sbookingtime;
                    string stotalfare = myReader.GetString("totalfare"); totalfare.Text = stotalfare;
                    string sp1 = myReader.GetString("p1"); p1.Text = sp1;
                    string sp2 = myReader.GetString("p2"); p2.Text = sp2;
                    string sp3 = myReader.GetString("p3"); p3.Text = sp3;
                    string sp4 = myReader.GetString("p4"); p4.Text = sp4;
                    string sp5 = myReader.GetString("p5"); p5.Text = sp5;
                    string sp6 = myReader.GetString("p6"); p6.Text = sp6;
                    string sp1_age = myReader.GetString("p1_age"); p1_age.Text = sp1_age;
                    string sp2_age = myReader.GetString("p2_age"); p2_age.Text = sp2_age;
                    string sp3_age = myReader.GetString("p3_age"); p3_age.Text = sp3_age;
                    string sp4_age = myReader.GetString("p4_age"); p4_age.Text = sp4_age;
                    string sp5_age = myReader.GetString("p5_age"); p5_age.Text = sp5_age;
                    string sp6_age = myReader.GetString("p6_age"); p6_age.Text = sp6_age;
                    string sp1_gender = myReader.GetString("p1_gender"); p1_gender.Text = sp1_gender;
                    string sp2_gender = myReader.GetString("p2_gender"); p2_gender.Text = sp2_gender;
                    string sp3_gender = myReader.GetString("p3_gender"); p3_gender.Text = sp3_gender;
                    string sp4_gender = myReader.GetString("p4_gender"); p4_gender.Text = sp4_gender;
                    string sp5_gender = myReader.GetString("p5_gender"); p5_gender.Text = sp5_gender;
                    string sp6_gender = myReader.GetString("p6_gender"); p6_gender.Text = sp6_gender;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string constring1 = "datasource=localhost;port=3306;username=root;password=mysql";
            string Query1 = "select * from travel.hotelbk where  username  = '" + usermain + "'; ";
            MySqlConnection conDataBase1 = new MySqlConnection(constring1);
            MySqlCommand cmdDataBase1 = new MySqlCommand(Query1, conDataBase1);
            MySqlDataReader myReader1;
            try
            {
                conDataBase1.Open();
                myReader1 = cmdDataBase1.ExecuteReader();
                while (myReader1.Read())
                {
                    string shotelname = myReader1.GetString("hotelname"); hotelname.Text = shotelname;
                    string saddress = myReader1.GetString("address"); address.Text = saddress;
                    string scontactinfo = myReader1.GetString("contactinfo"); contactinfo.Text = scontactinfo;
                    string slocation = myReader1.GetString("location"); location.Text = slocation;
                    string sbookingtime1 = myReader1.GetString("bookingtime"); bookingtime1.Text = sbookingtime1;
                    string stotalfare1 = myReader1.GetString("totalfare"); totalfare1.Text = stotalfare1;
                    string scheckin = myReader1.GetString("checkin"); checkin.Text = scheckin;
                    string scheckout = myReader1.GetString("checkout"); checkout.Text = scheckout;
                    string sadultr1 = myReader1.GetString("adultr1"); adultr1.Text = sadultr1;
                    string schildrenr1 = myReader1.GetString("childrenr1"); childrenr1.Text = schildrenr1;
                    string styper1 = myReader1.GetString("typer1"); typer1.Text = styper1;
                    string sbedr1 = myReader1.GetString("bedr1"); bedr1.Text = sbedr1;
                    string sadultr2 = myReader1.GetString("adultr2"); adultr2.Text = sadultr2;
                    string schildrenr2 = myReader1.GetString("childrenr2"); childrenr2.Text = schildrenr2;
                    string styper2 = myReader1.GetString("typer2"); typer2.Text = styper2;
                    string sbedr2 = myReader1.GetString("bedr2"); bedr2.Text = sbedr2;
                    string sadultr3 = myReader1.GetString("adultr3"); adultr3.Text = sadultr3;
                    string schildrenr3 = myReader1.GetString("childrenr3"); childrenr3.Text = schildrenr3;
                    string styper3 = myReader1.GetString("typer3"); typer3.Text = styper3;
                    string sbedr3 = myReader1.GetString("bedr3"); bedr3.Text = sbedr3;
                    string sadultr4 = myReader1.GetString("adultr4"); adultr4.Text = sadultr4;
                    string schildrenr4 = myReader1.GetString("childrenr4"); childrenr4.Text = schildrenr4;
                    string styper4 = myReader1.GetString("typer4"); typer4.Text = styper4;
                    string sbedr4 = myReader1.GetString("bedr4"); bedr4.Text = sbedr4;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
