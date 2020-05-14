using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using NumToWord;

namespace NumToWord.Tests
{
  [TestClass]
  public class NumChecks
  {
    [TestMethod]
    public void NumberToWord_CheckIfNumberBelowTwentyReturnsProperWordValue_Nineteen()
    {
      // Arrange
      NumToWord numbah = new NumToWord();
      // Act
      NumToWord.FillDictionaries();
      NumToWord.NumberToWord(19);
      // Assert
      Assert.AreEqual("Nineteen", NumToWord.Word);
    }
  }
}