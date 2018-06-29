using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordSearch.Models;

namespace WordSearch.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetTargetWord_ReturnTargetWord_String()
        {
            //Arrange
            string testTarget = "the";

            //Act
            WordCounter testCounter = new WordCounter(testTarget);
            string result = testCounter.GetTargetWord();

            //Assert
            Assert.AreEqual(testTarget, result);
        }
    }
}
