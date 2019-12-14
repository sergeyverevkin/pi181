#region usings

using System;
using System.Collections.Generic;

#endregion

namespace pi018_20191026_Classes.Site
{
  /*
   * Сайт
   *  - адрес
   *  - новости[]
   *  
   */
  /// <summary>
  /// Сайт с новостями
  /// </summary>
  public class Site: System.Object
  {
    #region fields
    public string Address;
    public string Version;
    public List<Article> Articles;
    #endregion

    #region properties
    public int ArticleCount
    {
      get {
        int iCount = 0;
        foreach(Article pA in Articles) {
          if (pA.Date <= DateTime.Now) {
            iCount++;
          }
        }
        return iCount;
      }
      //set {
      //}
    }
    #endregion

    #region constructor
    public Site(string sAddress)
    {
      Address = sAddress;
      Articles = new List<Article>();
    }
    #endregion

    #region public methods
    /// <summary>
    /// Проверка версии
    /// </summary>
    public void Check()
    {
      foreach (char ch in Version) {
        if (!Char.IsDigit(ch) && ch != '.') {
          throw new CVersionInputDataException();
        }
      }

      if (ArticleCount == 0)
      {
        throw new CNoArticlesInputDataException();
      }
    }
    #endregion

    #region overrides
    public override string ToString()
    {
      return $"Site [{ Address }]: { ArticleCount } articles";
    }
    #endregion

  }
}
