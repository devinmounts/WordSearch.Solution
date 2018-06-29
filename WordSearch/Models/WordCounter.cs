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

        public WordCounter()
        {

        }

        public WordCounter(string targetWord = "")
        {
            _targetWord = targetWord;
        }

        public WordCounter(string targetWord = "", string phrase = "")
        {
            _targetWord = targetWord;
            _comparePhrase = phrase.ToLower().Split(' ');
        }



        public void SetTargetWord(string newTargetWord)
        {
            _targetWord = newTargetWord.ToLower();
        }
        public string GetTargetWord()
        {
            return _targetWord;
        }

        //public string[] SplitCompareString(string newComparePhrase)
        //{
        //    string[] splitPhrase = newComparePhrase.ToLower().Split(' ');
        //    return splitPhrase;
        //}

        public void SetSplitCompareString(string newComparePhrase)
        {
            string[] splitPhrase = newComparePhrase.ToLower().Split(' ');
            _comparePhrase = splitPhrase;
        }

        public string[] GetComparePhrase()
        {
            return _comparePhrase;
        }


        public int CheckSplitPhrase(string targetWord, string targetPhrase)
        {
            int score = 0; 
            SetTargetWord(targetWord);
            string inputWord = GetTargetWord();
            SetSplitCompareString(targetPhrase);
            string[] inputPhrase = GetComparePhrase();
            if (!inputPhrase.Contains(inputWord))
            {
                return score = 0;
            }
            else
            {
                for (int i = 0; i <= inputPhrase.Length; i++)  
                {
                    if (inputWord == inputPhrase[i])
                    {
                        return score += 5;
                    }
                }
            }
            return score;
        }
  
    }
}
