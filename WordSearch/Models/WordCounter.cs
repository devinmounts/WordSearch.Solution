using System;
using System.Collections.Generic;
using System.Linq;

namespace WordSearch.Models
{
    public class WordCounter
    {
        //private int _result;
        private string _targetWord;
        private List<string> _testString = new List<string> { };

        public WordCounter(string targetWord = "")
        {
            _targetWord = targetWord;
        }

        public string GetTargetWord()
        {
            return _targetWord;
        }
    }

}
