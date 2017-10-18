using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Game.Models
{
  public enum WinState {Player1Wins, Player2Wins, Draw};
  public enum Throw {Rock, Paper, Scissors};
  public static class RPS
  {
    public static Throw Convert(string playerThrow)
    {
      if (playerThrow == "Rock")
      {
        return Throw.Rock;
      }
      if (playerThrow == "Paper")
      {
        return Throw.Paper;
      }
      if (playerThrow == "Scissors")
      {
        return Throw.Scissors;
      }
      else
      {
        throw new Exception();
      }
    }
    public static WinState Play(Throw player1Throw, Throw player2Throw)
    {
      List<Throw> throws = new List<Throw> {player1Throw, player2Throw};
      if (player1Throw == player2Throw)
      {
        return WinState.Draw;
      }
      if (player1Throw == Throw.Paper && player2Throw == Throw.Rock)
      {
        return WinState.Player1Wins;
      }
      if (player1Throw == Throw.Scissors &&  player2Throw == Throw.Paper)
      {
        return WinState.Player1Wins;
      }
      if (player1Throw == Throw.Rock && player2Throw == Throw.Scissors)
      {
        return WinState.Player1Wins;
      }
      return WinState.Player2Wins;
    }
  }
}
