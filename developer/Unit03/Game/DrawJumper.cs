using System;
using System.Collections.Generic;

namespace Unit03.Game {
    public class DrawJumper {
        private string line1 = "  ---";
        private string line2 = " /   \\";
        private string line3 = " \\   /";
        private string line4 = "  \\ /";
        private string line50 = "   0";
        private string line5X = "   X";
        private string line6 = "  /|\\";
        private string line7 = "  / \\";
        private string line8 = "^^^^^^^";
        public void ShowJumper(int attempt) {
            if (attempt == 4) {
                Console.WriteLine(line1);
                Console.WriteLine(line2);
                Console.WriteLine(line1);
                Console.WriteLine(line3);
                Console.WriteLine(line4);
                Console.WriteLine(line50);
                Console.WriteLine(line6);
                Console.WriteLine(line7);
                Console.WriteLine();
                Console.WriteLine(line8);
            }
            if (attempt == 3) {
                Console.WriteLine(line2);
                Console.WriteLine(line1);
                Console.WriteLine(line3);
                Console.WriteLine(line4);
                Console.WriteLine(line50);
                Console.WriteLine(line6);
                Console.WriteLine(line7);
                Console.WriteLine();
                Console.WriteLine(line8);
            }
            if (attempt == 2) {
                Console.WriteLine(line3);
                Console.WriteLine(line4);
                Console.WriteLine(line50);
                Console.WriteLine(line6);
                Console.WriteLine(line7);
                Console.WriteLine();
                Console.WriteLine(line8);
            }
            if (attempt == 1) {
                Console.WriteLine(line4);
                Console.WriteLine(line50);
                Console.WriteLine(line6);
                Console.WriteLine(line7);
                Console.WriteLine();
                Console.WriteLine(line8);
            }
            if (attempt == 0) {
                Console.WriteLine(line5X);
                Console.WriteLine(line6);
                Console.WriteLine(line7);
                Console.WriteLine();
                Console.WriteLine(line8);
            }
        }

        public bool GameOver(int attempt, bool _isPlaying) {
            if (attempt == 0) {
                _isPlaying = false;
            }
            return _isPlaying;
        }
    }
}