using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;
namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void MatchOneLetter_True()
    {
      string[] expectedString = new string[] {"a"};
      string[] InputStringArray = new string[] {"a"};
      WordCounter testWordCounter = new WordCounter();
      CollectionAssert.AreEqual(expectedString, testWordCounter.CountWordsTest(InputStringArray));
    }

  //End of TestClass
  }
}
