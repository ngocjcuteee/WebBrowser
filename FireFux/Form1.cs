using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireFux
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com");
            webBrowser1.DocumentCompleted += webBrowser1_DocumentCompleted;
        }
        
        private void Form1_Resize(object sender, EventArgs e)
        {
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        
        // back button

        private void toolStripButton1_Click(object sender, EventArgs e) // back button
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        WebBrowser webTab = null;
        private void btnNewtab_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "New tab";
            tabControl1.Controls.Add(tab);
            tabControl1.SelectTab(tabControl1.TabCount - 1);
            webTab = new WebBrowser() { ScriptErrorsSuppressed = true };
            webTab.Parent = tab;
            webTab.Dock = DockStyle.Fill;
            webTab.Navigate("https://www.google.com");
            toolStripTextBox1.Text = ("https://www.google.com");
            webTab.DocumentCompleted += webTab_DocumentCompleted;
        }
        private void webTab_DocumentCompleted (object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = webTab.DocumentTitle;
        }

        private void toolStripTextBox1_Click(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
                if (web!= null)
                {
                    web.Navigate(toolStripTextBox1.Text);
                }
            }
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = webBrowser1.DocumentTitle;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            //tabcontrol1.tabpages.remove(tabcontrol1.selectedtab);\
            
        }
    }
}
