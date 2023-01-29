using System.IO;
using Newtonsoft.Json;
using System.Collections;
using System.Text.Json.Nodes;

namespace ScreenShotApp2
{
    public partial class Form1 : Form
    {
        public string directory1;
        public string directory;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // pobranie lokalizacji do zapisania screen shota
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == DialogResult.OK)
            {
                textBoxDisplay.Text = diag.SelectedPath;
                directory1 = diag.SelectedPath;
            }
            else
            {
                textBoxDisplay.Text = "You didn't choose a folder";
            }
            // zapisanie lokalizacji do pliku variables.json w
            // C:\Users\User\source\repos\ScreenShotApp2\ScreenShotApp2\bin\Debug\net7.0-windows\
            Variables1 variables1 = new Variables1()
            {
                directory = directory1
            };
            string strResultJson = string.Empty;
            strResultJson = JsonConvert.SerializeObject(variables1);
            File.WriteAllText(@"variables.json", strResultJson);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string strResultJson = string.Empty;
            strResultJson = File.ReadAllText(@"variables.json");
            Variables1 resultVariables = JsonConvert.DeserializeObject<Variables1>(strResultJson);
            Console.WriteLine(resultVariables.directory);
            //Variables1 variables = new Variables1()
            //{
            //    directory1 = directory

            //};
            //strResultJson = JsonConvert.SerializeObject(variables);
            



            this.Hide();
            SendKeys.Send("{PRTSC}");
            if (Clipboard.GetImage() != null)
            {
                Image myImage = Clipboard.GetImage();
                pictureBox1.Image = myImage;

            }

            Image copy = pictureBox1.Image;
            string inc2 = "";
            this.Show();
            if (resultVariables.directory != null)
            {
                string directory2 = "";
                directory2 = resultVariables.directory.ToString();
                textBoxDisplay.Text = directory2;
                copy.Save(directory2 + "\\ScreenShot_" + inc2 + ".png");

                //Variables1 resultVariables = JsonConvert.DeserializeObject<Variables1>(strResultJson);
                //Console.WriteLine(resultVariables.ToString());

                Variables1 variables = new Variables1()
                {
                    z = Int32.Parse(inc2),
                    directory = directory2
                };

                strResultJson = JsonConvert.SerializeObject(variables);
                File.WriteAllText(@"variables.json", strResultJson);
                Console.WriteLine("stored!");
            }

        }
    }
}