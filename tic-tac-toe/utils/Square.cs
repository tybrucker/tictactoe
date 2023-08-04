using tic_tac_toe.Properties;

namespace tic_tac_toe.utils
{
    internal class Square : Button
    {
        public bool played = false;
        public char piece = 'N';
        public Square() : base()
        {
        }

        public void ActivateX()
        {
            Image = Resources.x;
            piece = 'X';
            played = true;
        }

        public void ActivateO()
        {
            Image = Resources.o;
            piece = 'O';
            played = true;
        }

        public void Reset()
        {
            Image = null;
            played = false;
            piece = 'N';
        }

    }
}
