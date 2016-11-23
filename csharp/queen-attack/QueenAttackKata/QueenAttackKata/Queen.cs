using System;

namespace QueenAttackKata
{
    public class Queen
    {
        public Queen(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Queens
    {
        private Queen black;
        private Queen white;

        public Queens(Queen white, Queen black)
        {
            if (white.X == black.X && white.Y == black.Y)
                throw new ArgumentException();
            this.white = white;
            this.black = black;
        }

        public bool CanAttack()
        {
            return SameRowOrColumn() || SameDiagonal();
        }

        private bool SameDiagonal()
        {
            return black.X - white.X == black.Y - white.Y 
                || black.X - white.X == white.Y - black.Y;
        }

        private bool SameRowOrColumn()
        {
            return black.X == white.X || black.Y == white.Y;
        }
    }
}
