using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BlueSkyez_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("c:Program Files (x86)/Minecraft Launcher/MinecraftLauncher.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bsmedia.ultralimeteam.repl.co/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("c:");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://blueskyez-patchnotes.ultralimeteam.repl.co/");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("");
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            
        }

       

        private void button3_Click_3(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/gtMdRFav7y");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/AppData/Roaming/.minecraft/Mods");
     

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://blueskyez-launcher.ultralimeteam.repl.co/");
            Close();
        }

        private void Settings_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("https://bssettings.ultralimeteam.repl.co/");

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
    }
}


   
   
      





