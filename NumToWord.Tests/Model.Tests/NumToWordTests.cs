using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using NumToWord;
using System.Text;

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
      Assert.AreEqual("Nineteen ", NumToWord.Word);
    }
    [TestMethod]
    public void NumberToWord_CheckIfNegativeNumbersAboveNegative20ParseProperWords_NegativeNineteen()
    {
      NumToWord numbah = new NumToWord();
      NumToWord.FillDictionaries();
      NumToWord.NumberToWord(-19);
      Assert.AreEqual("Negative Nineteen ", NumToWord.Word);
    }
    [TestMethod]
    public void NumberToWord_DoSingleDigitNumbersConvertCorrectly_Nine()
    {
      NumToWord numbah = new NumToWord();
      NumToWord.FillDictionaries();
      NumToWord.NumberToWord(9);
      Assert.AreEqual("Nine ", NumToWord.Word);
    }
    [TestMethod]
    public void NumberToWord_DoDoubleDigitNumbersGreaterThan19ConvertCorrectly_ThirtyFive()
    {
      NumToWord numbah = new NumToWord();
      NumToWord.FillDictionaries();
      NumToWord.NumberToWord(35);
      Assert.AreEqual("Thirty Five ", NumToWord.Word);
    }
    [TestMethod]
    public void NumberToWord_DoThreeDigitNumbersConvertCorrectly_FourHundredThirtyFive()
    {
      NumToWord numbah = new NumToWord();
      NumToWord.FillDictionaries();
      NumToWord.NumberToWord(435);
      Assert.AreEqual("Four Hundred Thirty Five ", NumToWord.Word);
    }
    [TestMethod]
    public void NumberToWord_Do4DigitNumbersConvertCorrectly_FourThousandFourHundredThirtyGive()
    {
      NumToWord numbah = new NumToWord();
      NumToWord.FillDictionaries();
      NumToWord.NumberToWord(4435);
      Assert.AreEqual("Four Thousand Four Hundred Thirty Five ", NumToWord.Word);
    }
    [TestMethod]
    public void NumberToWord_DoMillionsNumbersConvertCorrectly_TwoMillionOneHundredFourThousandFourHundredThirtyFive()
    {
      NumToWord numbah = new NumToWord();
      NumToWord.FillDictionaries();
      NumToWord.NumberToWord(2104435);
      Assert.AreEqual("Two Million One Hundred Four Thousand Four Hundred Thirty Five ", NumToWord.Word);
    }
    [TestMethod]
    public void NumberToWord_DoBillionsNumbersConvertCorrectly_OneBillionTwoMillionOneHundredFourThousandFourHundredThirtyFive()
    {
      NumToWord numbah = new NumToWord();
      NumToWord.FillDictionaries();
      NumToWord.NumberToWord(1002104435);
      Assert.AreEqual("One Billion Two Million One Hundred Four Thousand Four Hundred Thirty Five ", NumToWord.Word);
    }

  }
}