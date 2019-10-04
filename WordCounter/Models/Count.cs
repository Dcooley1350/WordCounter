using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class Counter
  {
    public string MasterWord { get; set; }
    public string MasterSentence { get; set;}
    public List<string> MasterList { get; set; }
    public char[] Punctuation { get; }
    public int WordCount { get; set; }


    public Counter(string masterWord, string masterSentence)
    {
      MasterWord = masterWord;
      MasterSentence = masterSentence;
      MasterList = new List<string>{};
      Punctuation = new char[]{',','.','(',')','!','?'};
      WordCount = 0;
    }
    public bool SingleWord()
    {
      string[] stringArray = MasterWord.Split(" ");
      if (stringArray.Length != 1)
      {
        MasterWord = "";
        return false;
      }
      else
      {
        return true;
      }
    }
    public void ToLowerCase()
    {
      MasterWord = MasterWord.ToLower();
      MasterSentence = MasterSentence.ToLower();
    }
    public string[] ToArray()
    {
      return MasterSentence.Split(" ");
    }
    public void RemovePunctuation(string[] stringArray)
    {
      foreach(string item in stringArray)
      {
        string[] newItem = item.Split(Punctuation);
        foreach(string foo in newItem)
        {
          if(foo != "." && foo != "," && foo !=  "(" && foo !=  ")" && foo !=  "!" && foo !=  "?" && foo !=" " && foo != "")
          {
            MasterList.Add(foo);
          }
        }
      }
    }
    public string ReturnError()
    {
      if(MasterList.Contains(MasterWord))
      {
        return "Occurances of your keyword in the sentence:";
      }
      else
      {
        return "The sentence does not contain your keyword. Idiot.";
      }
    }
    public void CountOccurances()
    {
      foreach(string item in MasterList)
      {
        if(item == MasterWord)
        {
          WordCount++;
        }
      }
    }
  }
}