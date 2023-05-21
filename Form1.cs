using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Diagnostics;

namespace MCPCompiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cleanUp();
        }

        public void cleanUp()
        {
            string pcname = Environment.UserName.ToString();
            string work = @"C:\Users\" + pcname + @"\Documents\WORK\";
            if (Directory.Exists(work))
            {
                Directory.Delete(work, true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // By Tengoku @2022

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please specify a name!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {



                Thread.Sleep(500);

                string clientname = textBox1.Text;

                string pcname = Environment.UserName.ToString();
                string file = @"C:\Users\" + pcname + @"\Desktop\" + clientname + ".jar";
                string exportDestination = @"C:\Users\" + pcname + @"\Documents\";
                string work = @"C:\Users\" + pcname + @"\Documents\WORK\";
                FileInfo f = new FileInfo(file);
                f.MoveTo(Path.ChangeExtension(file, ".zip"));
                Thread.Sleep(1000);
                Directory.CreateDirectory(work);
                string newFile = @"C:\Users\" + pcname + @"\Desktop\" + clientname + ".zip";
                File.Move(newFile, work + @clientname + @".zip");
                Thread.Sleep(500);
                ZipFile.ExtractToDirectory(work + @clientname + ".zip", work + @clientname);
                Thread.Sleep(1000);
                using (WebClient wc = new WebClient())
                {
                    // netty
                    wc.DownloadFile(
                        new System.Uri("https://github.com/TwistVibed/MCPCompilerAssets/raw/main/netty.zip"),
                        "C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\netty.zip"
                    );
                }
                using (WebClient wc = new WebClient())
                {
                    // pack.png
                    wc.DownloadFile(
                        new System.Uri("https://github.com/TwistVibed/MCPCompilerAssets/raw/main/pack.png"),
                        "C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\pack.png"
                    );
                }
                ZipFile.ExtractToDirectory("C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\netty.zip", "C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\io");
                Thread.Sleep(500);
                File.Delete("C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\netty.zip");
                File.Delete("C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\Start.class");
                File.Delete("C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + ".zip");
                System.IO.DirectoryInfo di = new DirectoryInfo("C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\META-INF\\");


                foreach (FileInfo file2 in di.GetFiles())
                {
                    file2.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
                Directory.Delete("C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\META-INF\\");

                // downloading and unzipping mc assets


                using (WebClient wc = new WebClient())
                {
                    // blockstates
                    wc.DownloadFile(
                        new System.Uri("https://github.com/TwistVibed/MCPCompilerAssets/raw/main/blockstates.zip"),
                        "C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\blockstates.zip"
                    );
                }
                using (WebClient wc = new WebClient())
                {
                    // font
                    wc.DownloadFile(
                        new System.Uri("https://github.com/TwistVibed/MCPCompilerAssets/raw/main/font.zip"),
                        "C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\font.zip"
                    );
                }
                using (WebClient wc = new WebClient())
                {
                    // lang
                    wc.DownloadFile(
                        new System.Uri("https://github.com/TwistVibed/MCPCompilerAssets/raw/main/lang.zip"),
                       "C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\lang.zip"
                    );
                }
                using (WebClient wc = new WebClient())
                {
                    // models
                    wc.DownloadFile(
                        new System.Uri("https://github.com/TwistVibed/MCPCompilerAssets/raw/main/models.zip"),
                        "C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\models.zip"
                    );
                }
                using (WebClient wc = new WebClient())
                {
                    // shaders
                    wc.DownloadFile(
                        new System.Uri("https://github.com/TwistVibed/MCPCompilerAssets/raw/main/shaders.zip"),
                       "C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\shaders.zip"
                    );
                }
                using (WebClient wc = new WebClient())
                {
                    // texts
                    wc.DownloadFile(
                        new System.Uri("https://github.com/TwistVibed/MCPCompilerAssets/raw/main/texts.zip"),
                        "C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\texts.zip"
                    );
                }
                using (WebClient wc = new WebClient())
                {
                    // textures
                    wc.DownloadFile(
                        new System.Uri("https://github.com/TwistVibed/MCPCompilerAssets/raw/main/textures.zip"),
                        "C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\textures.zip"
                    );
                }

                Thread.Sleep(500);
                ZipFile.ExtractToDirectory("C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\blockstates.zip", "C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\blockstates");
                ZipFile.ExtractToDirectory("C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\font.zip", "C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\font");
                ZipFile.ExtractToDirectory("C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\lang.zip", "C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\lang");
                ZipFile.ExtractToDirectory("C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\models.zip", "C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\models");
                ZipFile.ExtractToDirectory("C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\shaders.zip", "C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\shaders");
                ZipFile.ExtractToDirectory("C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\texts.zip", "C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\texts");
                ZipFile.ExtractToDirectory("C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\textures.zip", "C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\textures");
                Thread.Sleep(250);
                File.Delete("C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\blockstates.zip");
                File.Delete("C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\font.zip");
                File.Delete("C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\lang.zip");
                File.Delete("C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\models.zip");
                File.Delete("C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\shaders.zip");
                File.Delete("C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\texts.zip");
                File.Delete("C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\assets\\minecraft\\textures.zip");

                Thread.Sleep(1000);

                //zipping and converting to a jar

                ZipFile.CreateFromDirectory("C:\\Users\\" + pcname + "\\Documents\\WORK\\" + clientname + "\\", "C:\\Users\\" + pcname + "\\Documents\\" + clientname + ".zip");

                Thread.Sleep(1000);

                string compiledjar = "C:\\Users\\" + pcname + "\\Documents\\" + clientname + ".zip";

                FileInfo f2 = new FileInfo(compiledjar);
                f2.MoveTo(Path.ChangeExtension(compiledjar, ".jar"));

                string finaljar = "C:\\Users\\" + pcname + "\\Documents\\" + clientname + ".jar";


                Thread.Sleep(1000); 

                label2.Text = "Export finished! Go into your documents folder for the jar file.";
            }
        }
    }
}
