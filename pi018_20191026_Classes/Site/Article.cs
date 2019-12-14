using System;
using System.Diagnostics.Eventing.Reader;

namespace pi018_20191026_Classes.Site
{
  /*
     * Новость
      *  - дата
      *  - тема
      *  - автор
      *  - текст
     */

  /// <summary>
  /// Новость
  /// </summary>
  public class Article
  {

    public DateTime Date;
    public EStatus Status;
    //public bool IsDeleted;
    //public bool IsModerated;
    //public bool IsArchived;
    public string Subject;
    public string Author;
    public string Text;

    public Article(
      DateTime date, 
      EStatus status,
      string subject, 
      string author, 
      string text)
    {
      Date = date;
      Status = status;
      Subject = subject;
      Author = author;
      Text = text;
    }
  }
}
