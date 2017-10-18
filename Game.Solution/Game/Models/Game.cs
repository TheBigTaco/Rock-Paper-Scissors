using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Game.Models
{
  enum Throw {Rock, Paper, Scissors};
  enum WinState {Player1Wins, Player2Wins, Draw};
  public static class RPS
  {
    public static Player Player1 = new Player();
    public static Player Player2 = new Player();

    public static WinState Play(Throw player1Throw, Throw player2Throw)
    {
      return WinState.Draw;
    }
  }

  public class Player
  {
    public Throw Throw {get; set;}
  }
}
