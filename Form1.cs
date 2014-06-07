using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;
using System.Web;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            downloadBrowser.Navigate("www.youtube-mp3.org");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            String url = youtube_url.Text.ToString();
            String [] end = url.Split('=');
            try
            {
                webBrowser1.Navigate("http://i3.ytimg.com/vi/" + end[1] + "/default.jpg");
                webBrowser1.Visible = true;
                String[] title = GetTitle(url).Split('"');
                label1.Text = title[1];
                try
                {
                    if (downloadBrowser.ReadyState == WebBrowserReadyState.Complete)
                    {
                        downloadBrowser.Document.GetElementById("youtube-url").SetAttribute("value", youtube_url.Text);
                        downloadBrowser.Document.GetElementById("submit").InvokeMember("click");
                        download.Enabled = true;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to convert file");
                }
               
            }
            catch (Exception)
            {
                MessageBox.Show("Not a valid youtube link");
                label1.Text = "Error reading link, make sure you copied it correctly";
            }
        }


        private void download_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            
            try
            {
                HtmlElement download_link = downloadBrowser.Document.GetElementById("dl_link");
                
                HtmlElementCollection links = download_link.GetElementsByTagName("a");

                System.Collections.IEnumerator nums = links.GetEnumerator();
                
                String link = "";
                
                while(nums.MoveNext())
                {
                    HtmlElement hold = (HtmlElement)nums.Current;
                    if(hold.GetAttribute("href").Contains("?ab="))
                        link = hold.GetAttribute("href");
                }
                /*
                for (int i = 0; i < 4; i++)
                {
                    if (links[i].GetAttribute("href").Contains("?ab"))
                    {
                        link = links[i].GetAttribute("href");
                    }
                    else
                    {
                        label1.Text = "unable to find link";
                    }
                }
                */
                youtube_url.Text = link;
                downloadBrowser.Navigate(link);
                client.DownloadFileAsync(new Uri(link), "test.mp3");
                //youtube_url.Text = link;
                //System.Diagnostics.Process.Start(link);
                //MessageBox.Show("downloaded file");
                
                
                
                
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to download file");
            }

            
        }

        public string GetTitle(string url)
        {
            WebClient client = new WebClient();
            String xmlformat = client.DownloadString("http://www.youtube.com/oembed?url=" + url);
            String[] hold = xmlformat.Split(':');
            for (int i = 0; i < hold.Length - 1; i++)
            {
                if (hold[i].Contains("title"))
                    return hold[i + 1];
            }
            return "Could not find title";
        }

        public void clear()
        {
            youtube_url.Text = "Enter another url to convert";
            label1.Text = "Video Title";
            //webBrowser1.GoHome();
            //downloadBrowser.GoHome();
            downloadBrowser.Navigate("http://www.youtube-mp3.org");
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void New_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
