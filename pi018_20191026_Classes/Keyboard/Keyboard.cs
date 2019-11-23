using System.Collections.Generic;

namespace pi018_20191026_Classes.Keyboard
{
  /// <summary>
  /// Клавиатура
  ///  - производитель;
  ///  - тип клавиатуры(отдельная, встроенная, цифровая);
  ///  - CapsLock
  ///  - клавиша[]
  /// </summary>
  public class Keyboard
  {
    #region properties
    /// <summary>
    /// производитель
    /// </summary>
    public string Producer { get; set; }

    /// <summary>
    /// тип клавиатуры( 1 = отдельная, 2 = встроенная, 3 = цифровая);
    /// </summary>
    public int KeyboardType { get; set; }

    /// <summary>
    /// включен ли CapsLock
    /// </summary>
    public bool CapsLockState { get; private set; }

    /// <summary>
    /// клавиши
    /// </summary>
    public List<Key> Keys { get; private set; }

    #endregion

    #region constructors
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="sProducer"></param>
    /// <param name="iKeyboardType"></param>
    public Keyboard(string sProducer, int iKeyboardType)
    {
      Producer = sProducer;
      KeyboardType = iKeyboardType;
      CapsLockState = false;
      Keys = new List<Key>();
    }

    #endregion

  }
}