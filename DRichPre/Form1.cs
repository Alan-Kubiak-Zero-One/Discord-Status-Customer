using DiscordRPC;
using DiscordRPC.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRichPre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] Splash = { "Splash.cs", "Nice Hat !", "Splash !", "OS !", "Arduino !", "64G !", "TCP/IP !", "SUPER FAST !", "SUPER GLUE !", "Archimed And MR.Robot", "SuperDiskFormatter ! 4K Down !", "Win32DiskImager !", "UP !", "Master Boot Record !", "FAT32 !", "Dry Hands...", "Danny...", "Colored !", "Hexadecimal !", "^W^", "Cactus !", "How You Feel ?", "Micro SD !", "Raspberry Pi Zero !", "Barley Sugar !", "Canon Party !", "Beautiful Castle !", "Unix !", "Linux !", "Coded At Night !", "ExTeam !", "Softpedia !", "Powered By Coffee !", "Pshhhh...", "Beta !", "Premium !", "Alpha !", "Delta !", "TLT !", "NsaneForums.com !", "Ask Alan !", ".EXE !", "By Alan Kubiak !", "C# !", "Coffee Time ?!", "FasImaFla !", "teapot", "Dynamite !", "I love Canada !", "DemiCD", "Coded With Love !", "Bunkered !", "Exception !", "Christmas Market !", "Cubic !", "5:00 Atmosphere...", "Little Cubic TV", "It's Snacks time ?!", "New Wave !", "Drunk !", "Bubble Gum !", "MultiColor !", "Yolle !", "Nothing ?", "OK...", "Nuke !", "Compiled !", "V For Vendetta !", "vewn's cat", "?!", "Attiny85 !", "Pop The Champagne !", "Free Soft !", "My day is off... (Alan)", "Tipi !", "Sourceforged !", "Meow ! (The Judge)", "Iced Chocolate Can !", "Ubik !", "Bot !", "Colline !", "French Fries !", "Boat !", "Good Morning Starshine, The Earth Says Hello!", "Small store on the highway at 5:00 am", "French Tech !" };

        Random rand = new Random();
        public void gensplash()
        {
            int Splash1 = rand.Next(Splash.Length);


            this.textBox1.Text = Splash[Splash1];
        }
        public DiscordRpcClient client;
        bool initalized = false;

        private void button1_Click(object sender, EventArgs e)
        {
            initalized = true;
            client = new DiscordRpcClient($"{textBox3.Text}");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.Initialize();
        }
        public void CreateAndWriteID()
        {
            // Create a Text File
            string fileID = (Path.GetDirectoryName(Application.ExecutablePath) + @"\ID.txt");
            {
                FileStream fs = null;
                if (!File.Exists(fileID))
                {
                    using (fs = File.Create(fileID))
                    {

                    }
                }
            }
            if (File.Exists(fileID))
            {
                using (StreamWriter writer = new StreamWriter(fileID))
                {
                    writer.Write(textBox3.Text);
                    
                }

            }
        }
        public void CreateAndWriteStatus()
        {
            // Create a Text File
            string fileStatus = (Path.GetDirectoryName(Application.ExecutablePath) + @"\Status.txt");
            {
                FileStream fs = null;
                if (!File.Exists(fileStatus))
                {
                    using (fs = File.Create(fileStatus))
                    {

                    }
                }
            }
            if (File.Exists(fileStatus))
            {
                using (StreamWriter sw = new StreamWriter(fileStatus))
                
                    sw.Write(textBox1.Text);
                
            }
        }
        public void CreateAndWriteDetails()
        {
            // Create a Text File
            string fileDetails = (Path.GetDirectoryName(Application.ExecutablePath) + @"\Details.txt");
            {
                FileStream fs = null;
                if (!File.Exists(fileDetails))
                {
                    using (fs = File.Create(fileDetails))
                    {

                    }
                }
            }
            if (File.Exists(fileDetails))
            {
                using (StreamWriter sw = new StreamWriter(fileDetails))
                
                    sw.Write(textBox2.Text);
                
            }
        }
        public void CreateAndWriteLIMG()
        {
            // Create a Text File
            string fileLIMG = (Path.GetDirectoryName(Application.ExecutablePath) + @"\LIMG.txt");
            {
                FileStream fs = null;
                if (!File.Exists(fileLIMG))
                {
                    using (fs = File.Create(fileLIMG))
                    {

                    }
                }
            }
            if (File.Exists(fileLIMG))
            {
                using (StreamWriter sw = new StreamWriter(fileLIMG))
                
                    sw.Write(textBox4.Text);
                
            }
        }
        public void CreateAndWriteAll()
        {
            CreateAndWriteSIMG();
            CreateAndWriteLIMG();
            CreateAndWriteDetails();
            CreateAndWriteStatus();
            CreateAndWriteID();
        }
        public void CreateAndWriteSIMG()
        {
            // Create a Text File
            string fileSIMG = (Path.GetDirectoryName(Application.ExecutablePath) + @"\SIMG.txt");
            {
                FileStream fs = null;
                if (!File.Exists(fileSIMG))
                {
                    using (fs = File.Create(fileSIMG))
                    {

                    }
                }
            }
            if (File.Exists(fileSIMG))
            {
                using (StreamWriter sw = new StreamWriter(fileSIMG))
                
                    sw.Write(textBox5.Text);
                
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (initalized == false)
            {
                MessageBox.Show("You need to initialize app first!");
            }
            else
            {
                client.SetPresence(new DiscordRPC.RichPresence()
                {
                    Details = $"{textBox1.Text}",
                    State = $"{textBox1.Text}",
                    Timestamps = Timestamps.Now,
                    Assets = new Assets()
                    {
                        LargeImageKey = $"{textBox4.Text}",
                        LargeImageText = "Dev-Time Protector",
                        SmallImageKey = $"{textBox5.Text}"
                    }
                });
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VerifyAllTxt();
        }
        public void VerifyTxt1()
        {
            string fileID = (Path.GetDirectoryName(Application.ExecutablePath) + @"\ID.txt");

            if (File.Exists(fileID))
            {
                using (TextReader tr = new StreamReader(fileID))
                {
                    textBox3.Text = (tr.ReadLine());
                }
            }
        }
        public void VerifyTxt2()
        {
            string fileStatus = (Path.GetDirectoryName(Application.ExecutablePath) + @"\Status.txt");
            if (File.Exists(fileStatus))
            {
                using (TextReader tr = new StreamReader(fileStatus))
                {
                    textBox1.Text = (tr.ReadLine());
                }
            }
        }
        public void VerifyTxt3()
        {
            string fileDetails = (Path.GetDirectoryName(Application.ExecutablePath) + @"\Details.txt");
            if (File.Exists(fileDetails))
            {
                using (TextReader tr = new StreamReader(fileDetails))
                {
                    textBox2.Text = (tr.ReadLine());
                }
            }
        }
        public void VerifyTxt4()
        {
            string fileLIMG = (Path.GetDirectoryName(Application.ExecutablePath) + @"\LIMG.txt");
            if (File.Exists(fileLIMG))
            {
                using (TextReader tr = new StreamReader(fileLIMG))
                {
                    textBox4.Text = (tr.ReadLine());
                }
            }
        }
        public void VerifyTxt5()
        {
            string fileSIMG = (Path.GetDirectoryName(Application.ExecutablePath) + @"\SIMG.txt");
            if (File.Exists(fileSIMG))
            {

                using (TextReader tr = new StreamReader(fileSIMG))
                {
                    textBox5.Text = (tr.ReadLine());
                }
            }
        }
        public void VerifyAllTxt()
        {
            VerifyTxt1();
            VerifyTxt2();
            VerifyTxt3();
            VerifyTxt4();
            VerifyTxt5();
        }
        private void xuiButton1_Click(object sender, EventArgs e)
        {
            xuiFlatProgressBar1.Value = 100;
            if (initalized == false)
            {
                MessageBox.Show("You need to initialize app first");
                xuiFlatProgressBar1.Value = 0;
            }
            else
            {
                client.SetPresence(new DiscordRPC.RichPresence()
                {
                    Details = $"{textBox2.Text}",
                    State = $"{textBox1.Text}",
                    Timestamps = Timestamps.Now,
                    Assets = new Assets()
                    {
                        LargeImageKey = $"{textBox4.Text}",
                        LargeImageText = "Discord Status Customer",
                        SmallImageKey = $"{textBox5.Text}"

                    }

                });
                CreateAndWriteAll();
                    MessageBox.Show("Updated Successfully");
                label8.Visible = false;
                label9.Visible = true;
                    xuiFlatProgressBar1.Value = 0;
                }
            }
        
        private void xuiButton2_Click(object sender, EventArgs e)
        {
            xuiFlatProgressBar1.Value = 100;
            initalized = true;
            client = new DiscordRpcClient($"{textBox3.Text}");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.Initialize();
            MessageBox.Show("Initialized Successfully");
            xuiFlatProgressBar1.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/EG3KfN9");
        }
    }
}
