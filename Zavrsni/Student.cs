using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nemiro.OAuth;
using Nemiro.OAuth.LoginForms;
using System.IO;
using System.Net;

namespace Zavrsni
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        public string sub;
        private void button1_Click(object sender, EventArgs e)
        {
            Dropbox d = new Dropbox();
            d.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 pocetak = new Form3();
            this.Hide();
            pocetak.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Test t = new Test();
            t.ime = sub;
            t.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SpeechConverter s = new SpeechConverter();
            s.predmet = sub;
            s.ShowDialog();
        }
        private string CurrentPath = "";

        private void Student_Load(object sender, EventArgs e)
        {
            label3.Text = "You can chose one of five subjects for learning.\n Each subject has it's own materials, audio lessons\n and test. Good luck with learning! ";
            if (String.IsNullOrEmpty(Properties.Settings.Default.AccessToken))
            {
                this.GetAccessToken();
            }
            else
            {
                this.GetFiles();
            }


        }
        private void GetAccessToken()
        {
            var login = new DropboxLogin("f6fccine8tpofxh", "i0jzdcw5f5pfdbu");
            login.Owner = this;
            login.ShowDialog();

            if (login.IsSuccessfully)
            {
                Properties.Settings.Default.AccessToken = login.AccessToken.Value;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("nesto nije u redu");
            }

        }

        private void GetFiles()
        {
            OAuthUtility.GetAsync
           (
                "https://api.dropboxapi.com/1/metadata/auto/",

                new HttpParameterCollection
                {
                    { "path", this.CurrentPath },
                    {"access_token", "4R1jRPt73cAAAAAAAAAAC-F5PtU-7nmVVpVTYRg29qm3PzM1lybcpeIf8oChOauJ"}
                },
                callback: GetFiles_Result
            );

        }
        private void GetFiles_Result(RequestResult result)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<RequestResult>(GetFiles_Result), result);
                return;
            }
            if (result.StatusCode == 200)
            {
                comboBox1.Items.Clear();
                
                comboBox1.DisplayMember = "path";

                foreach (UniValue file in result["contents"])
                {
                    
                    comboBox1.Items.Add(file);
                }
                
                //if (this.CurrentPath != "")
                //{
                //    comboBox1.Items.Insert(0, UniValue.ParseJson("{path: '..' }"));
                //}

            }
            else
            {
                MessageBox.Show("You don't have connection to internet.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           string ind = comboBox1.SelectedIndex.ToString();

            if (ind == "0")
            {
                sub = "Biology";
            }
            if (ind == "1")
            {
                sub = "Chemistry";
            }
            if (ind == "2")
            {
                sub = "History";
            }
            if (ind == "3")
            {
                sub = "Mathematics";
            }
            if (ind == "4")
            {
                sub = "Physics";
            }
            label2.Text = "Selected subject is " + sub;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            GoogleDrive G = new GoogleDrive();
            G.ShowDialog();
        }
    }
}
