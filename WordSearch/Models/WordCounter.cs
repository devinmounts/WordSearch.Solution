﻿using System;
using System.Collections.Generic;
using System Linq;

namespace WordSearch.Models
{
    public class WordCounter
    {
        private int _result;
        private string _targetWord;
        private List<string> _testList = new List<string> { };

        public void WordCounter(string targetWord = "")
        {
            _targetWord = targetWord;
        }
    }
}
