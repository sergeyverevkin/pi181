using System;
using System.Runtime.Serialization.Formatters;

namespace pi018_20191026_Classes.Site
{
  public class CInputDataException : Exception
  {
    protected CInputDataException(string sMessage): base(sMessage)
    {
    }
  }
}