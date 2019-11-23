namespace pi018_20191026_Classes.Keyboard
{

  /// <summary>
  /// Клавиша
  /// - надпись сверху(дополнительный символ - Shift)
  /// - надпись снизу(основной символ)
  /// - состояние(сломана/исправна/плохо работает)
  /// - тип клавиши (обычная, SHIFT, CapsLock)
  /// </summary>
  public class Key
  {

    #region constructor

    public Key(EKeyType enKeyType, string chNormal, string chShift)
    {
      KeyType = enKeyType;
      Char = chNormal;
      CharForShift = chShift;
      KeyState = EKeyState.Ok;
    }

    #endregion



    #region public properties
    /// <summary>
    /// надпись сверху(дополнительный символ - Shift)
    /// </summary>
    public string CharForShift { get; set; }
    /// <summary>
    /// надпись снизу(основной символ)
    /// </summary>
    public string Char { get; set; }

    /// <summary>
    /// состояние(1 = сломана/ 2 = исправна/ 3 = плохо работает)
    /// </summary>
    public EKeyState KeyState { get; set; }

    /// <summary>
    /// тип клавиши ( 1 = обычная, 2 = SHIFT, 3 = CapsLock)
    /// </summary>
    public EKeyType KeyType { get; set; }
    #endregion
  }
}