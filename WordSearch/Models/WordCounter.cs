using System;
using System.Collections.Generic;
using System.Linq;

namespace WordSearch.Models
{
    public class WordCounter
    {
        //private int _result;
        private string _targetWord;
        private string[] _comparePhrase;
        //private List<string> _testString = new List<string> { };

        public WordCounter(string targetWord = "")
        {
            _targetWord = targetWord;
        }

        public void SetTargetWord(string newTargetWord)
        {
            _targetWord = newTargetWord.ToLower();
        }
        public string GetTargetWord()
        {
            return _targetWord;
        }

        public string[] SplitCompareString(string comparePhrase)
        {
            string[] splitPhrase = comparePhrase.Split(' ');
            return splitPhrase;

            //public void SaveTestString(string compareString)
            //{
            //    _testString.Add(compareString.ToLower());
            //}

            //public string GetAll
        }

    }
}
