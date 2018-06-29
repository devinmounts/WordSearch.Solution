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
            WordCounter testCounter = new WordCounter(testTarget);

            //Act

            string result = testCounter.GetTargetWord();

            //Assert
            Assert.AreEqual(testTarget, result);
        }

        [TestMethod]
        public void SetTargetWord_SetNewTargetWord_String()
        {
            //Arrange
            string testTarget = "the";
            WordCounter testCounter = new WordCounter(testTarget);

            //Act
            string newTestTarget = "cat";
            testCounter.SetTargetWord(newTestTarget);
            string result = testCounter.GetTargetWord();

            //Assert
            Assert.AreEqual(newTestTarget, result);
        }

        [TestMethod]
        public void SetTargetWord_SetNewTargetWordToLower_String()
        {
            //Arrange
            string testTarget = "the";
            WordCounter testCounter = new WordCounter(testTarget);

            //Act
            string newTestTarget = "CAT";
            testCounter.SetTargetWord(newTestTarget);
            string result = testCounter.GetTargetWord();

            //Assert
            Assert.AreEqual("cat", result);
        }
    }
}
