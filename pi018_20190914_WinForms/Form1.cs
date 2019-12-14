using pi018_20191026_Classes;
using System;
using System.Drawing;
using System.Windows.Forms;
using pi018_20191026_Classes.Site;

namespace pi018_20190914_WinForms
{
  public partial class Form1 : Form
  {
    private Site _site;
    private KeyboardForm _keyboardForm;

    public Form1()
    {
      InitializeComponent();
      _site = new TestSite();

      textBox1.Tag = label2;

    }

    private void btnStart_Click(object sender, EventArgs e)
    {
      labSiteName.Text = _site.Address;
      lvNews.Items.Clear();
      foreach(Article p in _site.Articles) {
        ListViewItem lviItem = lvNews.Items.Add(p.Date.ToString());
        if (p.Status.HasFlag(EStatus.Deleted)) {
          lviItem.BackColor = Color.Coral;
        }
        if (p.Status.HasFlag(EStatus.Archived))
        {
          lviItem.ForeColor = Color.DarkGray;
        }
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

    private void btnForm_Click(object sender, EventArgs e)
    {
      using (BlockForm pBlockForm = new BlockForm())
      {
        DialogResult pResult = pBlockForm.ShowDialog();
        switch (pResult)
        {
          case DialogResult.None:
            break;
          case DialogResult.OK:
            break;
          case DialogResult.Cancel:
            break;
        }
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (_keyboardForm != null) return;
      _keyboardForm = new KeyboardForm(textBox1);
      _keyboardForm.Show(this);
    }

    private void textBox1_KeyUp(
      object sender, 
      KeyEventArgs e)
    {
      TextBox tb = (sender as TextBox);
      try {
        _site.Version = tb.Text;
        _site.Check();
        // все нормально, ошибок нет
        if (tb.Tag != null) {
          (tb.Tag as Label).Visible = false;
        } else
        {
          tb.BackColor = Color.White;
        }
      }
      catch (CInputDataException pE)
      {
        if (tb.Tag != null)
        {
          (tb.Tag as Label).Text = pE.Message;
          (tb.Tag as Label).Visible = true;
        }
        else
        {
          tb.BackColor = Color.Red;
        }
      }
    }
  }
}
