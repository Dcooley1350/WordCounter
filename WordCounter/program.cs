using System;
using WordCounter.Models;

namespace WordCounter
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("To check a sentence or paragraph to see if it contains a keyword, first enter a keyword:");
            string keyWord = Console.ReadLine();
            System.Console.WriteLine("Next, enter the sentence or paragraph that you would like to check:");
            string keySentence = Console.ReadLine();
            Counter newCounter = new Counter(keyWord,keySentence);
            newCounter.SingleWord();
            newCounter.ToLowerCase();
            string[] newArray = newCounter.ToArray();
            newCounter.RemovePunctuation(newArray);
            newCounter.ReturnError();
            newCounter.CountOccurances();
            System.Console.WriteLine(newCounter.WordCount);
        }
    }
}