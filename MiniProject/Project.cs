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
    public partial class Project : Form
    {
        private static Project l = null;
        public Project()
        {
            InitializeComponent();
            DbConnect.getInstance().ConnectionString = "Data Source=DESKTOP-TOIHAAB;Initial Catalog=ProjectA;User ID=sa;Password=java";
        }
        public string ConnectionString = "Data Source=DESKTOP-TOIHAAB;Initial Catalog=ProjectA;User ID=sa;Password=java";
        public static Project getInstance()
        {
            if (l == null)
            {
                l = new Project();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("insert into Project(Description,Title) values('{0}','{1}')", richTextBox1.Text, textBox1.Text);
                DbConnect.getInstance().exectuteQuery(query);
                MessageBox.Show("Data Inserted Successfully...");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
   
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyHome l = MyHome.getInstance();
            l.Show();
            this.Hide();
        }
    }
}
