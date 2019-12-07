using System;

namespace pi018_20191026_Classes.Keyboard
{
  public class MyKeyboard: Keyboard
  {
    #region constructors
    /// <summary>
    /// Констуктор
    /// </summary>
    public MyKeyboard() : 
      base("HP", 1)
    {
      h_Fill();
    }

    #endregion

    #region private methods

    private void h_Fill()
    {
      Keys.Add(new Key(EKeyType.Normal, "1", "!"));
      Keys.Add(new Key(EKeyType.Normal, "2", "@"));
      Keys.Add(new Key(EKeyType.CapsLock, "CapsLock", String.Empty));
      // TODO...

    }

    #endregion
  }
}