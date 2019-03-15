using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MiniProject
{
    public partial class Advisor : Form
    {
        private static Advisor l = null;
        public Advisor()
        {
            InitializeComponent();
            DbConnect.getInstance().ConnectionString = "Data Source=DESKTOP-TOIHAAB;Initial Catalog=ProjectA;User ID=sa;Password=java";
        }
        public static Advisor getInstance()
        {
            if (l == null)
            {
                l = new Advisor();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }

        private void Advisor_Load(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try

            {

                String str = "Data Source=DESKTOP-TOIHAAB;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=java";
                String query = "INSERT INTO Advisor (Id,Designation,Salary)VALUES(('" + Convert.ToInt32(textBox1.Text) + "'),(select Id from Lookup where Lookup.Value ='" + comboBox1.Text + "'),('" + Convert.ToDecimal(textBox2.Text) + "'));";
                SqlConnection connect = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, connect);
                connect.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data insert successfully");


                connect.Close();
                Advisor ad = new Advisor();
                this.Hide();
                ad.Show();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyHome h = MyHome.getInstance();
            h.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int key = Convert.ToInt32(textBox1.Text);
                String str = "Data Source=DESKTOP-TOIHAAB;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=java";
                String query = "Update Advisor Set Designation = (select Id from Lookup where Lookup.Value ='" + comboBox1.Text + "'),Salary=('" + Convert.ToDecimal(textBox2.Text) + "')where Id = '" + Convert.ToInt32(textBox1.Text) + "';";
                SqlConnection connect = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, connect);
                connect.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data is Updated successfully");
                connect.Close();
                Advisor ad = new Advisor();
                this.Hide();
                ad.Show();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

        }
    }
}
