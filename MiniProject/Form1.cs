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
    public partial class Form1 : Form
    {
        private static Form1 l = null;
        public Form1()
        {
            InitializeComponent();
            DbConnect.getInstance().ConnectionString = "Data Source=DESKTOP-TOIHAAB;Initial Catalog=ProjectA;User ID=sa;Password=java";
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TOIHAAB;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=java");
        public int studendID { get; set; }
        public static Form1 getInstance()
        {
            if (l == null)
            {
                l = new Form1();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void cleartextBox()
        {
            studendID = 0;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MyHome l = MyHome.getInstance();
            l.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyHome h = MyHome.getInstance();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String firstname = textBox1.Text;
                String lastname = textBox2.Text;
                String contact = textBox3.Text;
                String email = textBox4.Text;
                DateTime db = dateTimePicker1.Value;
                
                int gender;
                if (radioButton1.Checked == true)
                {
                    gender = 1;
                }
                else
                {
                    gender = 2;
                }


                String cmd = String.Format("INSERT INTO Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender) values('{0}','{1}','{2}','{3}','{4}','{5}' )", firstname, lastname, contact, email, db, gender);
                int rows = DbConnect.getInstance().exectuteQuery(cmd);
                MessageBox.Show(String.Format("{0} rows affected", rows));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DbConnect.getInstance().closeConnection();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (studendID > 0)
            {
                SqlCommand cmd = new SqlCommand("Update Person SET FirstName= @FirstName,LastName=@LastName,Contact=@Contact,Email=@Email,DateOfBirth=@DateOfBirth,Gender=@Gender where Id=@ID ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FirstName", textBox1.Text);
                cmd.Parameters.AddWithValue("@LastName", textBox2.Text);
                cmd.Parameters.AddWithValue("@Contact", textBox3.Text);
                cmd.Parameters.AddWithValue("@Email", textBox4.Text);
                cmd.Parameters.AddWithValue("@ID", this.studendID);
                cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value);
                int gender;
                if (radioButton1.Checked == true)
                {
                    gender = 1;
                }
                else
                {
                    gender = 2;
                }
                cmd.Parameters.AddWithValue("@Gender", gender);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("The Record is Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                cleartextBox();
            }
            else
            {
                MessageBox.Show("Wil you please Select a Student for updation", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (studendID > 0)
            {
                SqlCommand cmd = new SqlCommand("Delete Person where Id=@ID ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.studendID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                cleartextBox();
            }
            else
            {
                MessageBox.Show("Select a Student to Delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
