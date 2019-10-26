using System.Collections.Generic;

namespace pi018_20191026_Classes
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
  public class Site
  {
    public string Address;
    public List<Article> Articles;

    public Site(string sAddress)
    {
      Address = sAddress;
    }
  }
}
