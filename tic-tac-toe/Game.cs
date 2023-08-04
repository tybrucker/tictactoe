using tic_tac_toe.utils;

namespace tic_tac_toe
{
    public partial class Game : Form
    {
        private bool gamestate = true;

        public Random randy = new();
        private const bool X = true;
        private const bool O = false;

        private Player player1 = new(X);
        private Player player2 = new(O);
        private bool turn = X;

        private bool pve = false;
        private bool hardmode = false;

        public Game()
        {
            InitializeComponent();
        }

        private void Square_Click(object sender, EventArgs e)
        {
            if (gamestate)
            {
                var sqr = (Square)sender;
                if (!sqr.played)
                {
                    if (turn)
                    {
                        player1.Plays(sqr);
                    }
                    else
                    {
                        player2.Plays(sqr);
                    }
                    if (Check_For_Win())
                    {
                        return;
                    }
                    turn = !turn;
                    if (pve)
                    {
                        AutoPlay();
                        if (Check_For_Win())
                        {
                            return;
                        }
                        turn = !turn;
                    }
                }
                
            }
        }

        private void Rdo_pvp_CheckedChanged(object sender, EventArgs e)
        {
            pve = false;
            Newgame_Function();
        }

        private void Rdo_pve_CheckedChanged(object sender, EventArgs e)
        {
            pve = true;
            Newgame_Function();
        }

        private void Newgame_Click(object sender, EventArgs e)
        {
            Newgame_Function();
        }

        private void Check_hardmode_CheckedChanged(object sender, EventArgs e)
        {
            hardmode = !hardmode;
        }

        private bool Check_For_Win()
        {
            if (Check1() || Check2() || Check3() || Check4() || Check5() || Check6() || Check7() || Check8())
            {
                Win_Function();
                return true;
            }
            if (!Available_Square())
            {
                Catscratch();
                return true;
            }
            return false;
        }

        private void Win_Function()
        {
            gamestate = false;
            if (turn == X)
            {
                winbox.Text = "Winner:\n  Player 1";
            }
            else
            {
                winbox.Text = "Winner:\n  Player 2";
            }

            winbox.Visible = true;

        }

        private void Catscratch()
        {
            gamestate = false;
            winbox.Text = "Nobody\nWins";
            winbox.Visible = true;
        }

        private void AutoPlay()
        {
            if (hardmode)
            {
                int[] move = Minimax.MakeBestMove(Translate());
                Square sqr = GetSquare(move[0], move[1]);
                player2.Plays(sqr);
            }
            else
            {
                RandSqr();
            }

        }

        private void RandSqr()
        {
            TableLayoutControlCollection squares = GameGrid.Controls;
            int randint = randy.Next(squares.Count);
            Square random_square = (Square)squares[randint];
            if (!random_square.played)
            {
                player2.Plays(random_square);
            }
            else
            {
                if (Available_Square())
                {
                    RandSqr();
                }
            }
        }

        private char[,] Translate()
        {
            char[,] board = new char[3, 3];
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = GetSquare(row, col).piece;
                }
            }
            return board;
        }

        private bool Available_Square()
        {
            TableLayoutControlCollection controls = GameGrid.Controls;
            foreach (Square square in controls)
            {
                if (!square.played)
                {
                    return true;
                }
            }
            return false;
        }

        private void Newgame_Function()
        {
            TableLayoutControlCollection squares = GameGrid.Controls;
            foreach (Square square in squares)
            {
                square.Reset();
            }
            gamestate = true;
            GameGrid.Visible = true;
            winbox.Visible = false;
            turn = X;
        }

        private Square GetSquare(int row, int col)
        {
            return (Square)GameGrid.GetControlFromPosition(col, row);
        }

        private bool Check1()
        {
            if (square_tl.piece != 'N')
            {
                if (square_tl.piece == square_tm.piece && square_tm.piece == square_tr.piece)
                {
                    return true;
                }
            }
            return false;
        }

        private bool Check2()
        {
            if (square_mm.piece != 'N')
            {
                if (square_ml.piece == square_mm.piece && square_mm.piece == square_mr.piece)
                {
                    return true;
                }
            }
            return false;
        }

        private bool Check3()
        {
            if (square_br.piece != 'N')
            {
                if (square_br.piece == square_bm.piece && square_bm.piece == square_bl.piece)
                {
                    return true;
                }
            }
            return false;
        }

        private bool Check4()
        {
            if (square_tl.piece != 'N')
            {
                if (square_tl.piece == square_ml.piece && square_ml.piece == square_bl.piece)
                {
                    return true;
                }
            }
            return false;
        }

        private bool Check5()
        {
            if (square_mm.piece != 'N')
            {
                if (square_tm.piece == square_mm.piece && square_mm.piece == square_bm.piece)
                {
                    return true;
                }
            }
            return false;
        }

        private bool Check6()
        {
            if (square_br.piece != 'N')
            {
                if (square_br.piece == square_mr.piece && square_mr.piece == square_tr.piece)
                {
                    return true;
                }
            }
            return false;
        }

        private bool Check7()
        {
            if (square_mm.piece != 'N')
            {
                if (square_tl.piece == square_mm.piece && square_mm.piece == square_br.piece)
                {
                    return true;
                }
            }
            return false;
        }

        private bool Check8()
        {
            if (square_mm.piece != 'N')
            {
                if (square_tr.piece == square_mm.piece && square_mm.piece == square_bl.piece)
                {
                    return true;
                }
            }
            return false;
        }


    }
}