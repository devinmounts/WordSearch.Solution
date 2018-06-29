using System;
using System.Collections.Generic;
using System.Linq;

namespace WordSearch.Models
{
    public class WordCounter
    {
        private int _result;
        private string _targetWord;
        private string[] _comparePhrase;

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

        public void SetSplitCompareString(string newComparePhrase)
        {
            string[] splitPhrase = newComparePhrase.ToLower().Split(' ');
            _comparePhrase = splitPhrase;
        }

        public string[] GetComparePhrase()
        {
            return _comparePhrase;
        }

        public int GetResult()
        {
            return _result;
        }

        public void SetResult(int score)
        {
            
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
                int i = 0;
                foreach (string word in inputPhrase)
                {
                    if (inputWord == inputPhrase[i])
                    {
                        score += 1;
                    }
                    i++;               
                }
                return score;
            }
        }
  
    }
}
