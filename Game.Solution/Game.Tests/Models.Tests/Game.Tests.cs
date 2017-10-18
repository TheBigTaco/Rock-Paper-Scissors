using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Models;

namespace Game.Tests
{
  [TestClass]
  public class RPSTest
  {
    [TestMethod]
    public void Play_IfThrowsAreEqual_Draw()
    {
      Assert.AreEqual(WinState.Draw, RPS.Play(Throw.Scissors, Throw.Scissors));
    }
    [TestMethod]
    public void Play_PlayerOneThrowBeatsPlayerTwo_P1Win()
    {
      Assert.AreEqual(WinState.Player1Wins, RPS.Play(Throw.Scissors, Throw.Paper));
    }
    [TestMethod]
    public void Play_PlayerTwoThrowBeatsPlayerOne_P2Win()
    {
      Assert.AreEqual(WinState.Player2Wins, RPS.Play(Throw.Scissors, Throw.Rock));
    }
    [TestMethod]
    public void Convert_ConvertStringToValidThrow_Throw()
    {
      Assert.AreEqual(Throw.Rock, RPS.Convert("Rock"));
    }
    [TestMethod]
    [ExpectedException(typeof(Exception))]
    public void Convert_ConvertStringToInvalidThrow_Exception()
    {
      RPS.Convert("hi");
    }
  }
}
