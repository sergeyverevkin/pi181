using System;
using System.Collections.Generic;

namespace pi018_20191026_Classes.OX
{
  public class CGame
  {
    #region public properties
    /// <summary>
    /// Статус игры
    /// </summary>
    public EGameStatus Status { get; private set; }
    /// <summary>
    /// Победитель
    /// </summary>
    public CPlayer Winner { get; private set; }
    /// <summary>
    /// Игрок текущего хода
    /// </summary>
    public int CurrentPlayer { get; private set; }

    /// <summary>
    /// Поля
    /// </summary>
    public List<CField> Fields { get; private set; }
    /// <summary>
    /// Игроки
    /// </summary>
    public List<CPlayer> Players { get; private set; }
    /// <summary>
    /// Количество смежных клеток в одном направлении для победы
    /// </summary>
    public int WinSize { get; private set; }
    /// <summary>
    /// Количество клеток - размерность поля
    /// </summary>
    public int Size { get; private set; }
    #endregion

    #region constructors

    public CGame()
    {
      Fields = new List<CField>();
      Players = new List<CPlayer>();
      Status = EGameStatus.NewGame;
    }

    #endregion

    #region public methods
    /// <summary>
    /// Начать новую игру
    /// </summary>
    /// <param name="iSize"></param>
    /// <param name="sPlayer1"></param>
    /// <param name="sPlayer2"></param>
    public void NewGame(
      int iSize,
      int iWinSize,
      string sPlayer1,
      string sPlayer2)
    {
      WinSize = iWinSize;
      Size = iSize;

      Fields.Clear();
      Players.Clear();

      Players.Add(new CXPlayer(sPlayer1));
      Players.Add(new COPlayer(sPlayer2));

      for (int iX = 0; iX < Size; iX++) {
        for (int iY = 0; iY < Size; iY++) {
          Fields.Add(new CField(iX, iY));
        }
      }

      CurrentPlayer = 0;
      Winner = null;
      Status = EGameStatus.Game;
    }

    public void Click(
      int iX, int iY, int iPlayer = -1)
    {
      if (iPlayer == -1)
      {
        iPlayer = CurrentPlayer;
      }
      if (iPlayer != CurrentPlayer)
      {
        return;
      }
      CField pField = h_GetField(iX, iY);
      if (pField == null) {
        return;
      }

      pField.Owner = Players[CurrentPlayer];
      h_CheckWin();
      if (Status == EGameStatus.Game) {
        h_NextTurn();
      }
    }

    #endregion

    #region private methods

    private void h_CheckWin()
    {
      CPlayer pCurPl = null;
      int iCounter = 0;
      bool bHasEmpty = false;
      for (int iX = 0; iX < Size; iX++) {

        iCounter = 0;
        pCurPl = null;

        for (int iY = 0; iY < Size; iY++) {
          CField pField = h_GetField(iX, iY);
          if (pField == null && pField.Owner == null) {
            iCounter = 0;
            continue;
          }
          if (pField.Owner == null) {
            bHasEmpty = true;
            iCounter = 0;
            pCurPl = null;
            continue;
          }

          if (pCurPl == pField.Owner) {
            iCounter++;
            if (iCounter >= WinSize) {
              Winner = pCurPl;
              Status = EGameStatus.GameOver;
            }
          }
          else {
            pCurPl = pField.Owner;
            iCounter = 1;
          }
        }
      }

      if (!bHasEmpty) {
        Winner = null;
        Status = EGameStatus.GameOver;
      }
    }



    private void h_NextTurn()
    {
      CurrentPlayer++;
      if (CurrentPlayer >= Players.Count) {
        CurrentPlayer = 0;
      }
    }


    private CField h_GetField(int iX, int iY)
    {
      foreach (CField p in Fields) {
        if (p.X == iX && p.Y == iY) {
          return p;
        }
      }

      return null;
    }

    #endregion

  }
}
