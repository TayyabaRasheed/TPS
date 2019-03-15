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
    public partial class ProRecords : Form
    {
        private static ProRecords l = null;
        public ProRecords()
        {
            InitializeComponent();
            DbConnect.getInstance().ConnectionString = "Data Source=DESKTOP-TOIHAAB;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=java";
        }
        public static ProRecords getInstance()
        {
            if (l == null)
            {
                l = new ProRecords();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }

        private void ProRecords_Load(object sender, EventArgs e)
        {
            String cmd = "Select * from Project";
            var reader = DbConnect.getInstance().getData(cmd);

            List<Projects> project = new List<Projects>();
            while (reader.Read())
            {
                Projects pro = new Projects();
                pro.ID = (int)reader.GetValue(0);
                pro.description = reader.GetString(1);
                pro.title = reader.GetString(2);

                project.Add(pro);
            }
            dataGridView1.DataSource = project;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyHome l = MyHome.getInstance();
            l.Show();
            this.Hide();
        }
    }
}
