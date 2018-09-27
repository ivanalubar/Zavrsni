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
    public partial class Profesor : Form
    {
        public Profesor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dropbox_P D = new Dropbox_P();
            D.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Details d = new Details();
            d.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 pocetak = new Form3();
            this.Hide();
            pocetak.ShowDialog();
        }

        private void Profesor_Load(object sender, EventArgs e)
        {

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
        private string CurrentPath = "";

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

        private void button4_Click(object sender, EventArgs e)
        {
            SpeechConverter s = new SpeechConverter();
            s.predmet = sub;
            s.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Test t = new Test();
            t.ime = sub;
            t.ShowDialog();
        }
        public string sub;
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
                sub = "Phisyc";
            }
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GoogleDrive GD = new GoogleDrive();
            GD.ShowDialog();
        }
    }
}
