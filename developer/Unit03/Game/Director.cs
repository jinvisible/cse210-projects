using System;
using System.Collections.Generic;

namespace Unit03.Game {
    public class Director {
        private bool _isPlaying = true;
        private string input = "";
         private int attempt = 5;
        private RandomWords _randomWords = new RandomWords();
        private DrawJumper _drawJumper = new DrawJumper();
        public Director() {
        }
        public void startGame() {
            while (_isPlaying) {
                DoOutputs();
                DoUpdates();
                if (_isPlaying == false) {
                    break;
                }
                GetInputs();
            }
        }

        private void GetInputs() {
            Console.Write("Guess a letter [a-z]: ");
            input = Console.ReadLine();
            Console.WriteLine();
        }

        private void DoOutputs() {
            _randomWords.DrawWord(input);
            Console.WriteLine();
            attempt = _randomWords.Attempt(input, attempt);
            _drawJumper.ShowJumper(attempt);
        }

        private void DoUpdates() {
            _isPlaying = _drawJumper.GameOver(attempt, _isPlaying);
            _isPlaying = _randomWords.Correct(_isPlaying);
        }
    }
}