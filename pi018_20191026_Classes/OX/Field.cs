using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi018_20191026_Classes.OX
{
  public class CField
  {
    #region public properties

    /// <summary>
    /// Координата X
    /// </summary>
    public int X { get; set; }
    /// <summary>
    /// Координата Y
    /// </summary>
    public int Y { get; set; }
    /// <summary>
    /// Владелец клетки
    /// </summary>
    public CPlayer Owner { get; set; }

    #endregion

    #region Constructors

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    public CField(int x, int y)
    {
      X = x;
      Y = y;
    }


    #endregion


  }

}
