namespace tic_tac_toe.utils
{
    internal class Player
    {
        private bool piece;

        public Player(bool piece)
        {
            if (piece)
            {
                this.piece = true;
            }
            else
            {
                this.piece = false;
            }
        }

        public void Plays(Square sqr)
        {
            if (piece)
            {
                sqr.ActivateX();
            }
            else
            {
                sqr.ActivateO();
            }
        }
    }
}
