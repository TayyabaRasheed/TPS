using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class StdRecords : Form
    {
        private static StdRecords l = null;
        public StdRecords()
        {
            InitializeComponent();
            DbConnect.getInstance().ConnectionString = "Data Source=DESKTOP-TOIHAAB;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=java";
        }
        
        public static StdRecords getInstance()
        {
            if (l == null)
            {
                l = new StdRecords();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }

        private void StdRecords_Load(object sender, EventArgs e)
        {
            String cmd = "Select * from Person";
            var reader = DbConnect.getInstance().getData(cmd);

            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                Student std = new Student();
                std.ID = (int)reader.GetValue(0);
                std.firstname = reader.GetString(1);
                std.lastname = reader.GetString(2);
                std.contact = reader.GetString(3);
                std.email = reader.GetString(4);
                std.dob = reader.GetDateTime(5);
                std.gender = (int)reader.GetValue(6);
                students.Add(std);
            }
            dataGridView1.DataSource = students;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyHome l = MyHome.getInstance();
            l.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
