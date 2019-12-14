using System;

namespace pi018_20191026_Classes.Site
{
  public class CVersionInputDataException : 
    CInputDataException
  {
    /// <summary>
    /// .ctor
    /// </summary>
    public CVersionInputDataException(): base("Неверная версия")
    {
    }
  }
}