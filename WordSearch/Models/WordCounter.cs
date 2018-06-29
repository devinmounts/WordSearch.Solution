using System;
using System.Collections.Generic;
using System.Linq;

namespace WordSearch.Models
{
    public class WordCounter
    {
        private int _result;
        private string _targetWord;
        //private string[] _comparePhrase;
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

        public string[] SplitCompareString(string newComparePhrase)
        {
            string[] splitPhrase = newComparePhrase.ToLower().Split(' ');
            return splitPhrase;
        }

        public int CheckSplitPhrase(string targetWord, string targetPhrase)
        {
            
            SetTargetWord(targetWord);
            string inputWord = GetTargetWord();
            string[] inputPhrase = SplitCompareString(targetPhrase);

            if (!inputPhrase.Contains(inputWord))
            {
                return _result = 0;
            }
            else
            {
                
                foreach(string word in inputPhrase)  
                {
                    if (inputWord == inputPhrase[i])
                    {
                        return _result += 1;
                    }
                }
            }
            return _result;
        }
  
    }
}
