using System;
using System.Collections.Generic;

namespace Unit03.Game {
    public class RandomWords {
        private string _word = "";
        private string _letter1 = "";
        private string _letter2 = "";
        private string _letter3 = "";
        private string _letter4 = "";
        private string _letter5 = "";
        private string _answer1 = "_";
        private string _answer2 = "_";
        private string _answer3 = "_";
        private string _answer4 = "_";
        private string _answer5 = "_";
        private List<string> _words = new List<string>();
        public RandomWords() {
            _words.Add("apple");
            _words.Add("class");
            _words.Add("peach");
            Random random = new Random();
            _word = _words[random.Next(_words.Count)];
            IntoLetters(_word);
        } 
        private void IntoLetters(string word) {
            _letter1 = word.Substring(0, 1);
            _letter2 = word.Substring(1, 1);
            _letter3 = word.Substring(2, 1);
            _letter4 = word.Substring(3, 1);
            _letter5 = word.Substring(4, 1);
        }
        public void DrawWord(string input) {
            if (_letter1 == input) {
                _answer1 = _letter1;
            }
            if (_letter2 == input) {
                _answer2 = _letter2;
            }
            if (_letter3 == input) {
                _answer3 = _letter3;
            }
            if (_letter4 == input) {
                _answer4 = _letter4;
            }
            if (_letter5 == input) {
                _answer5 = _letter5;
            }
            Console.WriteLine(_answer1 + " " + _answer2 + " " + _answer3 + " " + _answer4 + " " + _answer5);
        }

        public int Attempt(string input, int attempt) {
            if (!(_letter1 == input) && !(_letter2 == input) && !(_letter3 == input) && !(_letter4 == input) && !(_letter5 == input)) {
                attempt--;
            }
            return attempt;
        }

        public bool Correct(bool _isPlaying) {
            if (!(_answer1 == "_") && !(_answer2 == "_") && !(_answer3 == "_") && !(_answer4 == "_") && !(_answer5 == "_")) {
                _isPlaying = false;
            }
            return _isPlaying;
        }
    }
}