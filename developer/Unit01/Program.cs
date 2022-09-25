using System;
using System.Collections.Generic;

namespace Unit01
{
    class Program
    {// Program: CSE 210 Tic Tac Toe
     // Author: Jin Seo
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");
            List<string> board = newBoard();
            string thisP = "o";

            while (!gameOver(board)) {
                boardDisplay(board);
                int choice = pMove(thisP);
                moving(board, choice, thisP);
                thisP = nextP(thisP);
            }

            boardDisplay(board);
            Console.WriteLine("Good game. Thanks for playing!");
        }

        static List<string> newBoard() {
            List<string> board = new List<string>();
            
            for (int i = 1; i <= 9; i++) {
                board.Add(i.ToString());
            }

            return board;
        }

        static void boardDisplay(List<string> board) {
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
        }

        static bool winner(List<string> board, string player) {
            bool winner = false;

            if ((board[0] == player && board[1] == player && board[2] == player)
                || (board[3] == player && board[4] == player && board[5] == player)
                || (board[6] == player && board[7] == player && board[8] == player)
                || (board[0] == player && board[3] == player && board[6] == player)
                || (board[1] == player && board[4] == player && board[7] == player)
                || (board[2] == player && board[5] == player && board[8] == player)
                || (board[0] == player && board[4] == player && board[8] == player)
                || (board[2] == player && board[4] == player && board[6] == player)) {
                winner = true;
            }

            return winner; 
        }

        static bool draw(List<string> board) {
            bool digit = false;

            foreach (string value in board) {
                if (char.IsDigit(value[0])) {
                    digit = true;
                    break;
                }
            }

            return !digit;
        }

        static bool gameOver(List<string> board) {
            bool gameOver = false;

            if (winner(board, "x") || winner(board, "o") || draw(board)) {
                gameOver = true;
            }

            return gameOver;
        }

        static string nextP(string thisP) {
            string nextP = "x";

            if (thisP == "x")
            {
                nextP = "o";
            }

            return nextP;
        }

        static int pMove(string thisP) {
            Console.Write($"{thisP}'s turn to choose a square (1-9): ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        static void moving(List<string> board, int choice, string currentPlayer) {
            int index = choice - 1;

            board[index] = currentPlayer;
        }
    }
}
