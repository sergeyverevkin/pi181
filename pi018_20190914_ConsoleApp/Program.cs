// https://github.com/sergeyverevkin/pi181/

#region usings
using System;
using System.Collections;
using System.Collections.Generic;
#endregion

namespace pi018_20190914_ConsoleApp
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
      int iCount = 10;
      int jj = 0;
      for (
        int ii = 0;   // #1, инициализатор цикла
        ii < iCount;  // #2, проверка условия выполнения цикла (while)
        ii++          // #3, блок выполнения после завершения итерации 
        ) { // #4, тело цикла

        if (ii == 3) {
          continue; // перейти к следующей итерации
        }
        if (ii == 5) {
          break; // прекратить выполнение цикла
        }

        // постинкремент = {int result = jj; jj = jj + 1; return result; }
        Console.WriteLine(jj++);
        // прединкремент = {jj = jj + 1; return jj }
        Console.WriteLine(++jj);

      }
      #endregion

      #region incorrect for usage 
      // вечный цикл
      // for (;;) {}
      //for (
      //  ;   // #1, инициализатор цикла
      //  ;  // #2, проверка условия выполнения цикла (while)
      //     // #3, блок выполнения после завершения итерации 
      //  ) { // #4, тело цикла

      //}

      //
      //int jjj = 100;
      //for (
      //  Console.WriteLine("1");
      //  jjj-- > 90;
      //  Console.WriteLine(jjj));

      // for (int jjj = 0; jjj < 10; Console.WriteLine(jjj++));
      #endregion

      #region while

      // while
      int kk = 0;   // #1
      while (kk < 30) { // #2
        // #4, тело цикла
        kk++; // #3
      }

      // do .. while
      int mm = 0;   // #1
      do { // #2
        // #4, тело цикла
        mm++; // #3
      } while (mm < 40);


      while (true) {
        // вечный цикл
      }
      #endregion

      h_DemoStaticArray();

      h_DemoArrayList();

      h_DemoList();

      #region foreach
      #endregion

    }

    private static void h_DemoArrayList()
    {
      #region 2# Нетипизированный индексированный список
      ArrayList arList1 =
        new ArrayList() { 1, 2, 3 };
      ArrayList arList2 =
        new ArrayList() { 1, 2, 3 };
      arList1.Add("11q");
      arList1.Add(12);
      arList1.Add(value: null);
      //arList2.Clear();
      arList2.Remove(
        obj: "sd2"
      );
      arList2.RemoveAt(
        index: 0
      );
      arList2[2] = 3;
      arList2.Insert(
        index: 0,
        value: "asd" 
      );

      int iMax = int.MinValue;
      for (
        int ii = 0;
        ii < arList1.Count;
        ii++) {

        object o = arList1[ii];
        if (!(o is int)) {
          continue;
        }
        int oo = (int)o;
        if (oo > iMax) {
          iMax = oo;
        }
      }
      Console.WriteLine(iMax);
      #endregion

      //int iMax = int.MinValue;
      //for (
      //  int ii = 0;
      //  ii < arList1.Count;
      //  ii++) {
      //  if (arList1[ii] > iMax) {
      //    iMax = arList1[ii];
      //  }
      //}
      //Console.WriteLine(iMax);

    }


    private static void h_DemoList()
    {
      #region 3# Типизированный индексированный список
      List<string> arList1 =
        new List<string>() 
        {
          "123", "Asd", "ddddd"
        };
      arList1.Add("11q");
      arList1.Add("12");
      arList1.Remove("11q");
      arList1.RemoveAt(1);

      arList1.Insert(
        index: 0,
        item: "asd"
      );
      #endregion

      int iMax = int.MinValue;
      for (
        int ii = 0;
        ii < arList1.Count;
        ii++) {

        if (arList1[ii].Length > iMax) {
          iMax = arList1[ii].Length;
        }

      }

      Console.WriteLine(iMax);

    }

    private static void h_DemoStaticArray()
    {
      #region 1# Статические массивы
      int[] ar1; // указатель на массив
      // int iSize = sizeof(int);
      // int iD = default(int);
      ar1 = new int[2];
      // 00 00 00 00 00 00 00 00
      // ___________ ___________
      // ar1[0]      ar1[1]
      ar1[0] = 100;

      int[] ar2 = new int[2] {
        1, 2
      };

      int[] ar3 = new[] {
        1, 2, 3, 45, 665
      };
      #endregion

      /*
      int iMax = int.MinValue;
      for (
        int ii = 0; 
        ii < ar3.Length; 
        ii++) {
        if (ar3[ii] > iMax) {
          iMax = ar3[ii];
        }
      }
      Console.WriteLine(iMax);



      Console.WriteLine("Введите размерность массива");
      string sLine = Console.ReadLine();
      int iCount;
      if (int.TryParse(
        sLine, 
        out iCount)) {
        int[] arUsers = new int[iCount];
      }
      */
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
