using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class CounterTests
  {
    Counter newCounter;
    string keyString;
    string stringToCheck;
    [TestInitialize]
    public void Setup()
    {
      keyString = "Pickle";
      stringToCheck = "I pickle, you pickle, we all pickle.";
      newCounter = new Counter(keyString,stringToCheck);
    }
    [TestCleanup]
    public void TearDown()
    {
      newCounter = null;
    }
    [TestMethod]
    public void Constructor_ConstructorBuildsClassObject_Counter()
    {
      Assert.AreEqual(newCounter.GetType(),typeof(Counter));
    }
    [TestMethod]
    public void SingleWord_ChecksKeywordisoneword_True()
    {
      bool single = Counter.SingleWord(keyString);
      Assert.AreEqual(single,true);
    }
    [TestMethod]
    public void ToLowerCase_ConvertsAllInputsToLowerCase_String()
    {
      string correctKey = "pickle";
      string correctMaster = "i pickle, you pickle, we all pickle.";
      Counter correctCounter = new Counter(correctKey,correctMaster);
      newCounter.ToLowerCase();
      Assert.AreEqual(correctCounter.MasterSentence, newCounter.MasterSentence);
    }
    [TestMethod]
    public void ToArray_ChangesStringToAnArray_StringArray()
    {
      string[] correctArray = {"i","pickle,","you","pickle,","we","all","pickle."};
      newCounter.ToLowerCase();
      string[] newArray = newCounter.ToArray();
      CollectionAssert.AreEqual(newArray,correctArray);
    }
    [TestMethod]
    public void RemovePunctuation_RemovesAllPunctuationFromArray_StringArray()
    {
      List<string> correctList = new List<string>{"i","pickle","you","pickle","we","all","pickle"};
      newCounter.ToLowerCase();
      string[] newArray = newCounter.ToArray();
      newCounter.RemovePunctuation(newArray);
      bool yeet = newCounter.MasterList.SequenceEqual(correctList);
      Assert.AreEqual(true,yeet);
    }
    [TestMethod]
    public void ReturnError_ReturnErrorIfSentenceDoesNotIncludeWord_String()
    {
      string errorExpected = "Occurances of your keyword in the sentence:";
      newCounter.ToLowerCase();
      string[] newArray = newCounter.ToArray();
      newCounter.RemovePunctuation(newArray);
      string mystring = newCounter.ReturnError();
      Assert.AreEqual(mystring,errorExpected);   

    }
    [TestMethod]
    public void CountOccurances_CountsTheNumberofOccurances_int()
    {
      int expectedCount =  3;
      newCounter.ToLowerCase();
      string[] newArray = newCounter.ToArray();
      newCounter.RemovePunctuation(newArray);
      newCounter.CountOccurances();
      Assert.AreEqual(newCounter.WordCount,expectedCount);
    }
  }
}   



