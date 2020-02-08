using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pi018_20191026_Classes.OX;

namespace pi018_20190914_WinForms
{
  public partial class OXForm : Form
  {
    private CGame m_pGame;

    public OXForm()
    {
      InitializeComponent();
      m_pGame = new CGame();
      h_Refresh();
    }

    private void h_Refresh()
    {
      switch (m_pGame.Status)
      {
        case EGameStatus.NewGame:
          tabControl1.SelectedTab = tabPage1;
          break;
        case EGameStatus.Game:
          tabControl1.SelectedTab = tabPage2;
          h_RefreshField();
          break;
        case EGameStatus.Pause:
          tabControl1.SelectedTab = tabPage2;
          break;
        case EGameStatus.GameOver:
          tabControl1.SelectedTab = tabPage1;
          if (m_pGame.Winner == null)
          {
            tabPage1.Text = "Игра закончена";
          }
          else
          {
            tabPage1.Text = "Победил " + m_pGame.Winner.Name;
          }
          break;
      }
    }

    private void h_RefreshField()
    {
      foreach (CField pField in m_pGame.Fields)
      {
        h_DrawField(pField);
      }
    }

    private void h_DrawField(CField pField)
    {
      Button pButton = null;
      foreach (object pC in tabPage2.Controls)
      {
        if (!(pC is Button)) continue;
        CField pTag = (pC as Button).Tag as CField;
        if (pTag == null) continue;
        if (pField.X == pTag.X && pField.Y == pTag.Y)
        {
          pButton = pC as Button;
        }
      }


      if (pButton == null)
      {
        const int Size = 30;
        const int Padding = 10;

        pButton = new Button();
        pButton.Parent = tabPage2;
        pButton.Size = new Size(Size, Size);
        pButton.Left = Padding + pField.X * (Size + Padding);
        pButton.Top = Padding + pField.Y * (Size + Padding);
        pButton.Tag = pField;
        pButton.Click += btnClick;
      }

      pButton.Text = 
        pField.Owner == null 
          ? " " 
          : pField.Owner.Symbol.ToString();
    }

    private void btnClick(object sender, EventArgs e)
    {
      int iPlayer = 0;
      MouseButtons p = (e as MouseEventArgs).Button;
      if ((p & MouseButtons.Middle) != 0)
      {
        iPlayer = 1;
      }
      CField pTag = (sender as Control).Tag as CField;
      if (pTag == null)
      {
        return;
      }

      m_pGame.Click(pTag.X, pTag.Y, iPlayer);
      h_Refresh();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      m_pGame.NewGame((int)numSize.Value, (int)numSize.Value, edPlayer1.Text, edPlayer2.Text);
      h_Refresh();
    }
  }
}
