using pi018_20191026_Classes.Keyboard;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace pi018_20190914_WinForms
{
  public partial class KeyboardForm : Form
  {
    #region private variables

    private TextBox m_edOriginal;
    private MyKeyboard m_keyboard;

    #endregion

    #region constructors

    public KeyboardForm(TextBox edOriginal = null)
    {
      InitializeComponent();
      m_edOriginal = edOriginal;
      m_keyboard = new MyKeyboard();

      h_FillForm();
    }

    private void h_FillForm()
    {
      const int Width = 40;
      const int Height = 20;
      const int Padding = 10;

      // panel1.
      for (int ii = 0; ii < m_keyboard.Keys.Count; ii++) {
        int iLeft = Padding + ii * (Width + Padding);
        Key pB = m_keyboard.Keys[ii];
        Button pBControl = new Button();
        pBControl.Parent = panel1;
        pBControl.Location = new Point(iLeft, Padding);
        pBControl.Width = Width;
        pBControl.Height = Height;

        switch (pB.KeyType) {
          case EKeyType.Unknown:
            break;
          case EKeyType.Normal:
            pBControl.BackColor = Color.Chartreuse;
            break;
          case EKeyType.Shift:
            pBControl.BackColor = Color.Cyan;
            break;
          case EKeyType.CapsLock:
            pBControl.BackColor = Color.BlueViolet;
            break;
          default:
            throw new ArgumentOutOfRangeException();
        }

        pBControl.Text = pB.Char;
        pBControl.Tag = pB;
        pBControl.Click += PBControlOnClick;
      }
    }

    private void PBControlOnClick(object sender, EventArgs e)
    {
      Button btn = (sender as Button);
      Key pK = (Key)btn.Tag;
      switch (pK.KeyType) {
        case EKeyType.Unknown:
          break;
        case EKeyType.Normal:
          SendSymbol(pK.Char);
          break;
        case EKeyType.Shift:
          break;
        case EKeyType.CapsLock:
          break;
        default:
          throw new ArgumentOutOfRangeException();
      }
    }

    #endregion

    private void SendSymbol(string sSymbol)
    {
      if (m_edOriginal == null) {
        return;
      }

      m_edOriginal.Text += sSymbol;
    }

  }
}
