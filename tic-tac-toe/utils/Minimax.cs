using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe.utils
{
    internal class Minimax
    {
        private const char player = 'O';
        private const char opponent = 'X';
        private const char empty = 'N';


        private static int Evaluate(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] == board[row, 1] && board[row, 1] == board[row, 2])
                {
                    if (board[row, 0] == player)
                    {
                        return +10;
                    }
                    else if (board[row, 0] == opponent)
                    {
                        return -10;
                    }
                }
            }

            for (int col = 0; col < 3; col++)
            {
                if (board[0, col] == board[1, col] && board[1, col] == board[2, col])
                {
                    if (board[0, col] == player)
                    {
                        return +10;
                    }
                    else if (board[0, col] == opponent)
                    {
                        return -10;
                    }
                }
            }

            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                if (board[0, 0] == player)
                {
                    return +10;
                }
                else if (board[0, 0] == opponent)
                {
                    return -10;
                }
            }

            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                if (board[0, 2] == player)
                {
                    return +10;
                }
                else if (board[0, 2] == opponent)
                {
                    return -10;
                }
            }
            return 0;
        }

        private static int MiniMax(char[,] board, int depth, bool playerturn)
        {
            int score = Evaluate(board);
            if (score == 10)
            {
                return score;
            }
            if (score == -10)
            {
                return score;
            }
            if (Available_Square(board) == false) return 0;

            if (playerturn)
            {
                int best = -1000;

                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        if (board[row, col] == empty)
                        {
                            board[row, col] = player;
                            best = Math.Max(best, MiniMax(board, depth + 1, !playerturn));
                            board[row, col] = empty;
                        }
                    }
                }
                return best;
            }
            else
            {
                int best = 1000;

                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        if (board[row, col] == empty)
                        {
                            board[row, col] = opponent;
                            best = Math.Min(best, MiniMax(board, depth + 1, !playerturn));
                            board[row, col] = empty;
                        }
                    }
                }
                return best;
            }
        }

        private static bool Available_Square(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (board[row, col] == 'N') return true;
                }
            }
            return false;
        }

        public static int[] MakeBestMove(char[,] board)
        {
            int best = -1000;
            int bestrow = -1; int bestcol = -1;

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (board[row, col] == empty)
                    {
                        board[row, col] = player;
                        int val = MiniMax(board, 0, false);
                        board[row, col] = empty;
                        if (val > best)
                        {
                            bestrow = row;
                            bestcol = col;
                            best = val;
                        }
                    }
                }
            }
            return new int[] { bestrow, bestcol };


        }
    }
}

/*
 * 
 */
