using System;
using WordCounter.Models;

namespace WordCounter
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("To check a sentence or paragraph to see if it contains a keyword, first enter a single keyword:");
            string keyWord = Console.ReadLine();
            keyWord = Program.Script(keyWord);
            System.Console.WriteLine("Next, enter the sentence or paragraph that you would like to check:");
            string keySentence = Console.ReadLine();
            Counter newCounter = new Counter(keyWord, keySentence);
            newCounter.ToLowerCase();
            string[] newArray = newCounter.ToArray();
            newCounter.RemovePunctuation(newArray);
            newCounter.ReturnError();
            newCounter.CountOccurances();
            System.Console.WriteLine(newCounter.WordCount);
        }
        public static string Script(string word)
        {
            while(!Counter.SingleWord(word))
            {
            Console.WriteLine("To check a sentence or paragraph to see if it contains a keyword, first enter a single keyword:");
            word = Console.ReadLine();
            }
            return word;
        }
    }
}