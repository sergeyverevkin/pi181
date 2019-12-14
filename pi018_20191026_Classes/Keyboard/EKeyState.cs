namespace pi018_20191026_Classes.Keyboard
{
  /// <summary>
  /// тип клавиши ( 1 = обычная, 2 = SHIFT, 3 = CapsLock)
  /// </summary>
  public enum EKeyType: int
  {
    /// <summary>
    /// зарезервировано
    /// </summary>
    Unknown,
    /// <summary>
    /// обычная
    /// </summary>
    Normal,
    Shift,
    CapsLock,
  }
}