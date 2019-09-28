// https://github.com/sergeyverevkin/pi181/

#region usings
using System;
#endregion

namespace ConsoleApp2
{
  internal class Program
  {
    /// <summary>
    /// Главная точка входа в консольное приложение
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
      #region comments
      // Comment
      /* multi line comment
       * is over
       */
      #endregion

      #region Console, assignment, function, return
      h_WriteAnyKey();
      #endregion

      #region for
      #endregion

      #region foreach
      #endregion

      #region while
      #endregion
    }

    /// <summary>
    /// 
    /// </summary>
    private static int h_WriteAnyKey()
    {
      int iNum1 = 2;
      int iNum2 = 3;
      int iNum3 = iNum1 + iNum2;
      Console.WriteLine(iNum3);
      Console.WriteLine("Press any key");
      Console.ReadKey();

      DateTime dt1 = DateTime.Now;
      DateTime dt2 = DateTime.Now;

      #region if-else
      //if (
      //  (iNum3 % 2 == 1)
      //  || (iNum3 == 0)
      //  ) {
      //  return iNum3;
      //}
      //else {
      //  return iNum2;
      //}
      #endregion

      #region ?:

      // ex#1
      //if (h_IsNumberOdd(iNum2)) {
      //  return iNum2;
      //} else {
      //  return iNum3;
      //}
      //return h_IsNumberOdd(iNum2) ? iNum2 : iNum3;

      // ex#2
      return
        (
          // ||   OR
          // &&   AND
          // %    MOD
          // ==   is equals
          // =    assignment
          // !=   is NOT equals
          (iNum3 % 2 == 1) || (iNum3 != 0)
          ? iNum3 // whether is true
          : iNum2 // whether is false
          );
      #endregion
    }

    private static bool h_IsNumberOdd(int iNum2)
    {
      return (iNum2 % 2 == 1);
    }
  }
}
