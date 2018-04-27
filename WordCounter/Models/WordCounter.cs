using System.Collections.Generic;
using System.IO;
using System;
using WordCounterApp.Models;

namespace WordCounterApp.Models
{
  public class WordCounter
  {
    private string _word;
    private string[] _inputStringArray;

    public WordCounter(string Word, string[] InputStringArray)
    {
      _word = Word;
      _inputStringArray = InputStringArray;
    }

    public void SetWord(string newWord)
    {
      _word = newWord;
    }
    public string GetWord()
    {
      return _word;
    }
    public void SetInputStringArray(string[] newInputStringArray)
    {
      _inputStringArray = newInputStringArray;
    }
    public string[] GetInputStringArray()
    {
      return _inputStringArray;
    }

    public int CountWords(string Word, string[] InputStringArray)
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
            if(LowerCaseStringArray==LowerCaseWord)
            {
              WordCounter++;
            }
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
