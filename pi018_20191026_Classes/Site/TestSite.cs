#region usings

using System;

#endregion

namespace pi018_20191026_Classes.Site
{
  /// <summary>
  /// Тестовый сайт с новостями
  /// </summary>
  public class TestSite: Site
  {
    #region constructor
    public TestSite(): base("https://news.ru")
    {
      h_CreateTestSite();
    }
    #endregion


    #region private methods
    private void h_CreateTestSite()
    {
      Article pArticle1 = new Article() {
        Author = "Грибов С.П."
      };
      pArticle1.Date = new DateTime(2018, 01, 01);
      pArticle1.Subject = "Новость нового года";
      pArticle1.Text = "Сегодня наступил новый год";

      Article pArticle2 = new Article();
      pArticle2.Author = "Грибов С.П.";
      pArticle2.Date = new DateTime(2019, 01, 01);
      pArticle2.Subject = "Новость нового года";
      pArticle2.Text = "Сегодня снова наступил новый год";

      this.Articles.Add(pArticle1);
      this.Articles.Add(pArticle1);
      this.Articles.Add(pArticle2);
    }
    #endregion

  }
}
