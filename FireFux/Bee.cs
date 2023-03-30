using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bee
{
    public partial class Bee : Form
    {
        int i = 0; //lưu thứ tự tab trong phiên làm việc gần nhất
        //int soTrang = 0;            // phục vụ cho đánh dấu trang 
        //Class_DanhDau[] danhDauTrang = new Class_DanhDau[100];
        //ListBox listBoxLichSu = new ListBox();      // danh sách lưu lịch sử 
        //ListBox listBoxMarked = new ListBox();         // danh sách lưu đánh dấu trang 
        public Bee()
        {
            InitializeComponent();
        }
        //string text;
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
            webBrowser1.Size = tabControl1.Size;
            webBrowser1.Navigate("https://www.google.com");
            webBrowser1.DocumentCompleted += webBrowser1_DocumentCompleted;
            toolStripTextBox1.Text= "https://" + "google.com";
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
            tabControl1.SelectedTab.Text = webBrowser1.DocumentTitle;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
        // Xóa hết tất cả các tab hiện có và tạo 1 tab mới
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            i = 0;
            tabControl1.TabPages.Add("New Tab");
            webBrowser1 = new WebBrowser();
            webBrowser1.Size = tabControl1.Size;
            webBrowser1.DocumentCompleted += webBrowser1_DocumentCompleted;
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Dock = DockStyle.Fill;
            webBrowser1.Visible = true;
            webBrowser1.Navigate("http://" + "google.com");
            toolStripTextBox1.Text = "http://" + "google.com";
            tabControl1.TabPages.Add("+");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Tag = i.ToString();
            tabControl1.SelectedTab.Controls.Add(webBrowser1);
            i++;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void toolStripTextBox1_Click(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
                if (web != null)
                {
                    web.Navigate(toolStripTextBox1.Text);
                }
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
