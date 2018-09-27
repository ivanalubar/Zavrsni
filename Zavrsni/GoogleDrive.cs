using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;


namespace Zavrsni
{
    public partial class GoogleDrive : Form
    {
        //kakva prava ima, ako je DriveFile onda može uploadati        
        static string ApplicationName = "Drive API Quickstart";

        private UserCredential makeCredential(string[] Scopes)
        {
            //podaci za prijavu
            UserCredential credential;

            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath =System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/drive-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets, Scopes, "user", CancellationToken.None,  new FileDataStore(credPath, true)).Result;

                //richTextBox1.AppendText("Credential file saved to: " + credPath);
            }
            return credential;
        }

        private void Citaj10()
        {
            string[] scopesRead = { DriveService.Scope.DriveReadonly };
            UserCredential credential = makeCredential(scopesRead);

            // Create Drive API service.
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define parameters of request.
            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.PageSize = 10;
            listRequest.Fields = "nextPageToken, files(id, name)";

            // List files.
            IList<Google.Apis.Drive.v3.Data.File> files = listRequest.Execute().Files;

            //richTextBox1.AppendText("Files:");
            //richTextBox1.Text += "Files: ";
            if (files != null && files.Count > 0)
            {
                foreach (var file in files)
                {
                    //Console.WriteLine("{0} ({1})", file.Name, file.Id);
                    //richTextBox1.AppendText(file.Name + " " + file.Id);
                    string p = file.Name + " " +  "\n";
                    richTextBox1.Text += p;
                }
            }
            else
            {
                //Console.WriteLine("No files found.");
                richTextBox1.AppendText("No files found.");
            }
            //Console.Read();


        }

        public GoogleDrive()
        {
            InitializeComponent();
        }

       

      

        private void GoogleDrive_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            //https://developers.google.com/drive/v3/web/quickstart/dotnet
            Citaj10();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            //otvoriti drive, napraviti radni folder
            //ako je link na folder:
            https://drive.google.com/drive/folders/KOPIRATI_FOLDER_ID
            //svaki folder ima ID koji se nalazi iza zadnje kose crte

            string folderId = "0B_mXKXCGW9vUWFIxWUZSQXJvNEk";

            OpenFileDialog dlg = new OpenFileDialog();
            //Filter za dijalog:
            //"Text files (*.txt)|*.txt|All files (*.*)|*.*"
            dlg.Filter = "Jpg slike|*.jpg";
            if (dlg.ShowDialog() == DialogResult.Cancel)
                return;

            //dijalog vraća punu putanju
            string fullPath = dlg.FileName;
            string fileName = Path.GetFileName(fullPath);

            //string fileName = "Desert.jpg";
            richTextBox1.Text = "";
            richTextBox1.Text = fullPath + "\n";

            /* Upload slike */

            //podaci za autorizaciju
            string[] scopesReadUpload = { DriveService.Scope.Drive };
            UserCredential credential = makeCredential(scopesReadUpload);

            //stvaranje servisa
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            //U primjerima iz tutoriala negdje zna pisati samo File pa treba dodati:
            //Google.Apis.Drive.v3.Data.

            //podaci o datoteci (kako se zove i gdje će se smjestiti)
            var fileInfo = new Google.Apis.Drive.v3.Data.File()
            {
                Name = fileName,
                Parents = new List<string>()
            };
            //u google drive-u folderi su "parents" za svaku datoteku i podfolder, ali
            //za razliku od windowsa, ovdje jedna te ista datoteka može imati više
            //roditelja(biti sadržana u više foldera)
            fileInfo.Parents.Add(folderId);

            //stvaranje zahtjeva za upload
            FilesResource.CreateMediaUpload request1;
            using (var stream = new System.IO.FileStream(fullPath, System.IO.FileMode.Open))
            {
                request1 = service.Files.Create(fileInfo, stream, "image/jpeg");
                request1.Fields = "id";
                request1.Upload();
                MessageBox.Show("Done!");
            }
            var newFile = request1.ResponseBody;
            richTextBox1.AppendText("\nUploaded!  " );
        }

        private void button3_Click(object sender, EventArgs e)
       {
           

        }
    }
}