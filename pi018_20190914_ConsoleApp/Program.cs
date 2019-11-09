// https://github.com/sergeyverevkin/pi181/

#region usings
using pi018_20191026_Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
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
      // h_WriteAnyKey();
      #endregion

      // h_DemoFor();

      // h_DemoWhile();

      // h_DemoStaticArray();

      // h_DemoArrayList();

      // h_DemoList();

      // h_DemoDictionary();

      // h_TestSpeedArray();
      // h_TestSpeedHashset();
      // h_TestEncoding();
      // h_TestFileWrite();

      h_TestClasses();

      Console.ReadKey();
    }

    private static void h_TestClasses()
    {
      Site pSite1 = new TestSite();
      pSite1.Articles.RemoveAt(0);
      Console.WriteLine(pSite1);
    }

    private static void h_TestFileWrite()
    {
      string sFn = @"d:\1\1.none.txt";
      if (!File.Exists(sFn)) {
        Console.WriteLine("File is not found");
        return;
      }
      // #1.
      using (FileStream pS = File.OpenRead(sFn)) {
        pS.Seek(0, SeekOrigin.Begin);
        byte[] btContentInner = new byte[pS.Length];
        int iLen = pS.Read(btContentInner, 0, btContentInner.Length);
        //pS.Seek(5, SeekOrigin.Begin);
        // pS.Seek(0, SeekOrigin.End);
        // pS.Position;
      }
      // #2. 
      byte[] btContent = File.ReadAllBytes(sFn);

      // 2019-10-26
      // Задание: 
      // 1. из входной строки записать в файл 
      // только те символы,
      // которые есть в заданном массиве (цифры)
      // 2. при посимвольном считывании подсчитать 
      // количество повторяющихся символов, если 
      // какой-то символ встречается более 3 раз,
      // прекратить считывание.
      // 3. вывести на экран символ, встретившийся
      // более 3 раз.
    }

    private static void h_TestEncoding()
    {
      string sDir = @"d:\1\";
      string[] arFn = new[] {
        "1.none.txt",
        "2.ascii.txt",
        "3.utf8.txt",
        "4.1251.txt",
      };
      string sText = "Word is a 'слово', 2";

      File.WriteAllText(
        Path.Combine(sDir, arFn[0]), sText);
      File.WriteAllText(Path.Combine(sDir, arFn[1]), sText,
        Encoding.ASCII);
      File.WriteAllText(Path.Combine(sDir, arFn[2]), sText,
        Encoding.UTF8);
      File.WriteAllText(Path.Combine(sDir, arFn[3]), sText,
        Encoding.GetEncoding(1251));

      foreach (string sFn in arFn) {
        string sF = Path.Combine(sDir, sFn);
        string sLoadedText = File.ReadAllText(sF);
        sLoadedText = File.ReadAllText(sF, Encoding.ASCII);
        sLoadedText = File.ReadAllText(sF, Encoding.UTF8);
        sLoadedText = File.ReadAllText(sF, Encoding.GetEncoding(1251));
      }

    }

    private static void h_TestSpeedHashset()
    {
      // HashSet<int> = Dictionary<int, bool>
      int iMax = 9999900;
      int iFindCount = 99990000;
      // заполнил массив
      HashSet<int> ar = new HashSet<int>();
      for (int ii = 0; ii < iMax; ii++) {
        ar.Add(ii + 1);
      }

      DateTime dtStart = DateTime.Now;
      // поиск в массиве
      for (int ii = 0; ii < iFindCount; ii++) {
        int iNumberToFind = iMax - ii;
        if (ar.Contains(iNumberToFind)) {
          ar.Remove(iNumberToFind);
        }
      }
      DateTime dtEnd = DateTime.Now;
      Console.WriteLine($"Hashset: {dtEnd - dtStart}");
    }

    private static void h_TestSpeedArray()
    {
      int iMax = 99999;
      int iFindCount = 9999;
      // заполнил массив
      int[] ar = new int[iMax];
      for (int ii = 0; ii < iMax; ii++) {
        ar[ii] = ii + 1;
      }

      DateTime dtStart = DateTime.Now;
      // поиск в массиве
      for (int ii = 0; ii < iFindCount; ii++) {
        int iNumberToFind = iMax - ii;
        for (int jj = 0; jj < ar.Length; jj++) {
          if (ar[jj] == iNumberToFind) {
            continue;
          }
        }
      }
      DateTime dtEnd = DateTime.Now;
      Console.WriteLine($"Array: {dtEnd - dtStart}");
    }

    private static void h_DemoDictionary()
    {
      Dictionary<string, int> arRequiredWordCountDict =
        new Dictionary<string, int>();
      arRequiredWordCountDict.Clear();
      arRequiredWordCountDict.Add("q", 1);
      arRequiredWordCountDict.Remove("q");
      arRequiredWordCountDict.Add("word1", 1);
      arRequiredWordCountDict.Add("word2", 2);
      // arDict.Add("word1", 2);
      arRequiredWordCountDict["word3"] = 4;
      arRequiredWordCountDict["word3"] = 3;

      string sText = "word word1 word2 word5    word3";
      string[] arWords = sText.Split(
        new[] { ' ', ',' },
        StringSplitOptions.RemoveEmptyEntries
        );

      foreach (string sWord in arWords) {
        string sWordToLower = sWord.ToLower();
        if (!arRequiredWordCountDict.ContainsKey(sWordToLower)) {
          continue;
        }
        arRequiredWordCountDict[sWordToLower]--;
      }

      foreach (string sKey
        in arRequiredWordCountDict.Keys) {
        int iAbsentCount =
          arRequiredWordCountDict[sKey];
        if (iAbsentCount <= 0) {
          continue;
        }
        Console.WriteLine($"{{{ sKey }}} = { iAbsentCount } шт не хватает");
      }

      //for(int ii=0; ii<arWords.Length;ii++) {
      //  string sWord = arWords[ii];
      //  // ...
      //}

    }

    private static void h_DemoFor()
    {

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
    }

    private static void h_DemoWhile()
    {
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
