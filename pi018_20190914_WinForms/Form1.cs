using pi018_20191026_Classes;
using System;
using System.Windows.Forms;

namespace pi018_20190914_WinForms
{
  public partial class Form1 : Form
  {
    private Site _site;

    public Form1()
    {
      InitializeComponent();
      _site = new TestSite();
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
      labSiteName.Text = _site.Address;
      lvNews.Items.Clear();
      foreach(Article p in _site.Articles) {
        ListViewItem lviItem = lvNews.Items.Add(p.Date.ToString());
        lviItem.SubItems.Add(p.Author);
        lviItem.SubItems.Add(p.Subject);
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (_site.ArticleCount > 0) {
        _site.Articles.RemoveAt(0);
      }
    }
  }
}
