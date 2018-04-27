using System;

namespace WordCounter
{
  public class WordCounter
  {
    public int CountWordsTest(string Word, string[] InputStringArray)
    {
      int WordCounter=0;
      string LowerCaseWord = Word.ToLower();

      if(Word != "")
      {
        for(var i=0; i < InputStringArray.Length; i++)
        {
          string LowerCaseStringArray = InputStringArray[i].ToLower();
          if(LowerCaseStringArray.Contains(LowerCaseWord))
          {
            WordCounter++;
          }
        }
        return WordCounter;
      } else {
        return WordCounter;
      }
    }


  // End of Class
 }
}
