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

namespace Zavrsni
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=LUBAR;Initial Catalog=LearningApp;Integrated Security=True");
            string query1 = "Select * from [User] where UserName = '" + textBox1.Text.Trim() + "' and Passw ='" + textBox2.Text.Trim() + "' and Permision = 'S'";
            string query2 = "Select * from [User] where UserName = '" + textBox1.Text.Trim() + "' and Passw ='" + textBox2.Text.Trim() + "' and Permision = 'P'";

            SqlDataAdapter sda1 = new SqlDataAdapter(query1, sqlcon);
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, sqlcon);

            DataTable dtbl1 = new DataTable();
            DataTable dtbl2 = new DataTable();

            sda1.Fill(dtbl1);
            sda2.Fill(dtbl2);
            if (dtbl1.Rows.Count == 1)
            {
                Student prva = new Student();
                this.Hide();
                prva.ShowDialog();
            }
            else
            {
                if (dtbl2.Rows.Count == 1)
                {
                    Profesor druga = new Profesor();
                    this.Hide();
                    druga.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Check your username and password.");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
