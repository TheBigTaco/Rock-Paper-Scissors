using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Models;

namespace Game.Tests
{
  [TestClass]
  public class RPS
  {
    [TestMethod]
    public void Play_IfThrowsAreEqual_Draw()
    {
      Assert.AreEqual(WinState.Draw, RPS.Play(Throw.Scissors, Throw.Scissors));
    }
  }
}
