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

namespace OnetapCfgManager
{
    public partial class OnetapCfgs : Form
    {
        private string cfg;
        private string filepath;
        private string clipboard;

        public OnetapCfgs()
        {
            InitializeComponent();

            //Get the Cfgs and put them in an array.
            DirectoryInfo d = new DirectoryInfo(@"C:\Program Files (x86)\Steam\steamapps\common\Counter-Strike Global Offensive");//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.cfg"); //Getting Text files
            int str = 0;

            //Get the number of files.
            foreach (FileInfo file in Files)
            {
                str++;
            }
            str = str - 1;
            //add the array to the list box
            for (int x = 0; x <= str; x++)
            {
                listBox1.Items.Add(Files[x]);
            }

        }
        private void refreshcfgs()
        {
            listBox1.Items.Clear();
            //Get the Cfgs and put them in an array.
            DirectoryInfo d = new DirectoryInfo(@"C:\Program Files (x86)\Steam\steamapps\common\Counter-Strike Global Offensive");//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.cfg"); //Getting Text files
            int str = 0;

            //Get the number of files.
            foreach (FileInfo file in Files)
            {
                str++;
            }
            str = str - 1;
            //add the array to the list box
            for (int x = 0; x <= str; x++)
            {
                listBox1.Items.Add(Files[x]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            cfg = listBox1.SelectedItem.ToString();
            filepath = @"C:\Program Files (x86)\Steam\steamapps\common\Counter-Strike Global Offensive\" + cfg;
            textBox1.Text = cfg;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String myPath = filepath;
            File.Delete(myPath);
            refreshcfgs();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cspath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Counter-Strike Global Offensive\\";
            string newfile = cspath + textBox1.Text;
            File.Move(filepath, newfile);
            refreshcfgs();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clipboard = listBox1.SelectedItem.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cspath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Counter-Strike Global Offensive\\";
            string newfile = cspath + textBox1.Text;
            File.Copy(filepath, newfile);
            refreshcfgs();
        }
    }
}
