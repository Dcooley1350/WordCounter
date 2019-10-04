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
      newCounter = newCounter(keyString,stringToCheck);
    }
    [TestCleanup]
    public void TearDown()
    {
      newCounter = null;
    }
  }
}   



