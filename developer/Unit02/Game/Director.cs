using System;
using System.Collections.Generic;

namespace Unit02.Game
{
    public class Director {
        int[] _cards = {0, 0};
        bool _isPlaying = true;
        int _totalScore = 300;

        public void startGame() {
            while (_isPlaying) {
                guess();
                doOutputs();
                playAgain();
            }
        }

        public void guess() {
            for (int i = 0; i < 2; i++)
            {
                Card card = new Card();
                int a = card.draw();
                _cards[i] = a;
            }
            string answer = "l";
            if (_cards[1] > _cards[0]) {
                answer = "h";
            }
            else if (_cards[0] == _cards[1]) {
                answer = "n";
            }

            Console.WriteLine("The card is: " + _cards[0]);
            Console.Write("Higher or lower? [h/l] ");
            string hOrL = Console.ReadLine();
            if (hOrL == answer) {
                _totalScore += 100;
            }
            else if (answer == "n") {
                _totalScore += 0;
            }
            else {
                _totalScore -= 70;
            }


            if (_totalScore < 0) {
                _totalScore = 0;
            }
        }

        public void doOutputs() {
            Console.WriteLine("Next card was: " + _cards[1]);
            Console.WriteLine("Your score is: " + (_totalScore));
            if (_totalScore == 0) {
                Console.WriteLine("Game Over");
                _isPlaying = false;
            }
        }

        public void playAgain() {
            if (_isPlaying) {
                Console.Write("Play again?: [y/n] ");
                string playAgain = Console.ReadLine();
                if (playAgain == "y") {
                    _isPlaying = true;
                    Console.WriteLine();
                }
                else if (playAgain == "n") {
                    _isPlaying = false;
                }
            }
        }
    }

    class Card {
        public Card() {

        }
        public int draw(){
            Random random = new Random();
            int _value = random.Next(1, 13);
            return _value;
        }
    }
}
