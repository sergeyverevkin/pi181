#region usings

using System;

#endregion

namespace pi018_20191026_Classes.Site
{
  /// <summary>
  /// Тестовый сайт с новостями
  /// </summary>
  public class TestSite : Site
  {
    #region constructor
    public TestSite() : base("https://news.ru")
    {
      h_CreateTestSite();
    }
    #endregion


    #region private methods
    private void h_CreateTestSite()
    {
      Article pArticle1 = new Article(
        new DateTime(2018, 01, 01),
        EStatus.Deleted | EStatus.Moderated,
        "Новость нового года",
        "Грибов С.П.",
        "Сегодня наступил новый год"
      );

      Article pArticle2 = new Article(
        new DateTime(2019, 01, 01),
        EStatus.Moderated,
        "Новость нового года",
        "Грибов С.П.",
        "Сегодня снова наступил новый год"
      );
      pArticle2.Status = EStatus.Moderated;
      Article pArticle3 = new Article(
        new DateTime(2020, 01, 01),
        EStatus.ModeratedAndArchived,
        "Новость нового года",
        "Грибов С.П.",
        "Сегодня снова снова наступил новый год"
      );

      this.Articles.Add(pArticle1);
      this.Articles.Add(pArticle2);
      this.Articles.Add(pArticle3);

    }
    #endregion

  }
}
