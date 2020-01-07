using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace YahooNews_RSS
{
    public partial class Form1 : Form
    {

        string url;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TopicSelect.Items.Add("主要");         
            TopicSelect.Items.Add("国内");         
            TopicSelect.Items.Add("国際");         
            TopicSelect.Items.Add("経済");         
            TopicSelect.Items.Add("エンタメ");     
            TopicSelect.Items.Add("スポーツ");     
            TopicSelect.Items.Add("IT");           
            TopicSelect.Items.Add("科学");         
            TopicSelect.Items.Add("地域");         
            TopicSelect.SelectedIndex = 0;
            StartBtn.Enabled = true;
            StopBtn.Enabled = false;
            TopicSelect.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (TopicSelect.SelectedIndex)
            {
                case 0:
                    url = "https://news.yahoo.co.jp/pickup/rss.xml";
                    break;
                case 1:
                    url = "https://news.yahoo.co.jp/pickup/domestic/rss.xml";
                    break;
                case 2:
                    url = "https://news.yahoo.co.jp/pickup/world/rss.xml";
                    break;
                case 3:
                    url = "https://news.yahoo.co.jp/pickup/economy/rss.xml";
                    break;
                case 4:
                    url = "https://news.yahoo.co.jp/pickup/entertainment/rss.xml";
                    break;
                case 5:
                    url = "https://news.yahoo.co.jp/pickup/sports/rss.xml";
                    break;
                case 6:
                    url = "https://news.yahoo.co.jp/pickup/computer/rss.xml";
                    break;
                case 7:
                    url = "https://news.yahoo.co.jp/pickup/science/rss.xml";
                    break;
                case 8:
                    url = "https://news.yahoo.co.jp/pickup/local/rss.xml";
                    break;
                default:
                    NewsView.Text = "対応していない操作です";
                    break;
            }
            try
            {
                StartBtn.Enabled = false;
                StopBtn.Enabled = true;
                TopicSelect.Enabled = false;

                // RSS読み込み
                XElement element = XElement.Load(url);

                //NewsView.Text = element.Value;
                
                // channelの取得
                XElement channelElement = element.Element("channel");

                //title表示
                XElement title = channelElement.Element("title");
                NewsView.Text += title.Value;
                NewsView.Text += "\r\n";



                //itemの取得
                IEnumerable<XElement> NewsItems = channelElement.Elements("item");

                foreach (XElement NewsItem in NewsItems)
                {
                    XElement NewsTitle = NewsItem.Element("title");
                    XElement Link = NewsItem.Element("link");
                    NewsView.Text += NewsTitle.Value;
                    NewsView.Text += "\r\n";
                    NewsView.Text += Link.Value;
                    NewsView.Text += "\r\n";
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewsView.Text = "";
            StartBtn.Enabled = true;
            StopBtn.Enabled = false;
            TopicSelect.Enabled = true;
        }

        private void NewsView_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }
    }
}
