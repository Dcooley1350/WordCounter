using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Counter
  {
    public string MasterWord { get; set; }
    public string MasterSentence { get; set;}
    public List<string> MasterList { get; set; }
    public int WordCount { get; set; }

    public Counter(string masterWord, string masterSentence)
    {
      MasterWord = masterWord;
      MasterSentence = masterSentence;
      MasterList = new List<string>{};
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
  }
}