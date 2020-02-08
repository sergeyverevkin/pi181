namespace pi018_20191026_Classes.OX
{
  /// <summary>
  /// Игрок
  /// </summary>
  public class CPlayer
  {
    #region public properties

    /// <summary>
    /// Имя игрока
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Символ игрока
    /// </summary>
    public char Symbol { get; set; }

    #endregion

    #region constructors

    public CPlayer(string name, char symbol)
    {
      Name = name;
      Symbol = symbol;
    }

    #endregion
  }

  public class CXPlayer : CPlayer
  {
    public CXPlayer(string name) : 
      base(name, 'X')
    {
    }
  }

  public class COPlayer : CPlayer
  {
    public COPlayer(string name) :
      base(name, 'O')
    {
    }
  }

}