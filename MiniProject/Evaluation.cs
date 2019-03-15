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
    public partial class Evaluation : Form
    {
        private static Evaluation l = null;
        public Evaluation()

        {
            InitializeComponent();
            DbConnect.getInstance().ConnectionString = "Data Source=DESKTOP-TOIHAAB;Initial Catalog=ProjectA;User ID=sa;Password=java";
        }
        public static Evaluation getInstance()
        {
            if (l == null)
            {
                l = new Evaluation();
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
                String name = textBox1.Text;
                String totalmarks = textBox2.Text;
                String totalweightage = textBox3.Text;
                String cmd = String.Format("INSERT INTO Evaluation(Name,TotalMarks,TotalWeightage) values('{0}','{1}','{2}' )", name, totalmarks, totalweightage);
                int rows = DbConnect.getInstance().exectuteQuery(cmd);
                MessageBox.Show(String.Format("{0} rows affected", rows));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyHome h = MyHome.getInstance();
            h.Show();
            this.Hide();
        }
    }
}
