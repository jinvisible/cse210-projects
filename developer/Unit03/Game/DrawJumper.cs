using System;
using System.Collections.Generic;

namespace Unit03.Game {
    public class DrawJumper {
        public void ShowJumper(int attempt) {
            if (attempt == 4) {
                Console.WriteLine("  ---\n /   \\\n  ---\n \\   /\n  \\ /\n   0\n  /|\\\n  / \\\n\n^^^^^^^");
            }
            if (attempt == 3) {
                Console.WriteLine(" /   \\\n  ---\n \\   /\n  \\ /\n   0\n  /|\\\n  / \\\n\n^^^^^^^");
            }
            if (attempt == 2) {
                Console.WriteLine(" \\   /\n  \\ /\n   0\n  /|\\\n  / \\\n\n^^^^^^^");
            }
            if (attempt == 1) {
                Console.WriteLine("  \\ /\n   0\n  /|\\\n  / \\\n\n^^^^^^^");
            }
            if (attempt == 0) {
                Console.WriteLine("   X\n  /|\\\n  / \\\n\n^^^^^^^");
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