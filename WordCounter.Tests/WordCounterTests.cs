using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounterApp;
using WordCounterApp.Models;
using System;

namespace WordCounterApp.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void MatchOneLetter_One()
    {
      string Word = "a";
      string[] InputStringArray = new string[] {"a"};
      WordCounter testWordCounter = new WordCounter(Word, InputStringArray);
      Assert.AreEqual(1, testWordCounter.CountWords(Word, InputStringArray));
    }
    [TestMethod]
    public void MatchOneLetterLongerList_One()
    {
      string Word = "a";
      string[] InputStringArray = new string[] {"a", "I"};
      WordCounter testWordCounter = new WordCounter(Word, InputStringArray);
      Assert.AreEqual(1, testWordCounter.CountWords(Word, InputStringArray));
    }
    [TestMethod]
    public void MatchTwoLetters_One()
    {
      string Word = "in";
      string[] InputStringArray = new string[] {"an","in"};
      WordCounter testWordCounter = new WordCounter(Word, InputStringArray);
      Assert.AreEqual(1, testWordCounter.CountWords(Word, InputStringArray));
    }
    [TestMethod]
    public void MatchOneLetterCapitalization_One()
    {
      string Word = "i";
      string[] InputStringArray = new string[] {"a","I"};
      WordCounter testWordCounter = new WordCounter(Word, InputStringArray);
      Assert.AreEqual(1, testWordCounter.CountWords(Word, InputStringArray));
    }
    [TestMethod]
    public void MatchSixLetterCapitalization_One()
    {
      string Word = "iNSidE";
      string[] InputStringArray = new string[] {"a","inside"};
      WordCounter testWordCounter = new WordCounter(Word, InputStringArray);
      Assert.AreEqual(1, testWordCounter.CountWords(Word, InputStringArray));
    }
    [TestMethod]
    public void NoInput_Zero()
    {
      string Word = "";
      string[] InputStringArray = new string[] {""};
      WordCounter testWordCounter = new WordCounter(Word, InputStringArray);
      Assert.AreEqual(0, testWordCounter.CountWords(Word, InputStringArray));
    }
    [TestMethod]
    public void PartialMatch_Zero()
    {
      string Word = "a";
      string[] InputStringArray = new string[] {"an"};
      WordCounter testWordCounter = new WordCounter(Word, InputStringArray);
      Assert.AreEqual(0, testWordCounter.CountWords(Word, InputStringArray));
    }
    [TestMethod]
    public void NoMatches_Zero()
    {
      string Word = "outside";
      string[] InputStringArray = new string[] {"a","an","in","inside"};
      WordCounter testWordCounter = new WordCounter(Word, InputStringArray);
      Assert.AreEqual(0, testWordCounter.CountWords(Word, InputStringArray));
    }
    [TestMethod]
    public void IncorrectInputNumber_Zero()
    {
      string Word = "5";
      string[] InputStringArray = new string[] {"a"};
      WordCounter testWordCounter = new WordCounter(Word, InputStringArray);
      Assert.AreEqual(0, testWordCounter.CountWords(Word, InputStringArray));
    }

    //Other test cases for incorrect input will be handled on the front-end

  //End of TestClass
  }
}
