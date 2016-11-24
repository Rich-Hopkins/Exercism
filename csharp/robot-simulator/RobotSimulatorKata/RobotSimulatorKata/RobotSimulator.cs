namespace RobotSimulatorKata
{
    public class RobotSimulator
    {
        public RobotSimulator(Bearing bearing, Coordinate coordinate)
        {
            Bearing = bearing;
            Coordinate = coordinate;
        }

        public Bearing Bearing { get; set; }
        public Coordinate Coordinate { get; set; }

        public void TurnRight()
        {
            int bearing = (int) Bearing;
            bearing += 1;
            if (bearing == 4) bearing = 0;
            Bearing = (Bearing)bearing;
        }

        public void TurnLeft()
        {
            int bearing = (int) Bearing;
            bearing -= 1;
            if (bearing < 0) bearing = 3;
            Bearing = (Bearing) bearing;
        }

        private void MoveAhead()
        {
            switch (Bearing)
            {
                case Bearing.North:
                {
                    Coordinate.Y++;
                    break;
                }
                    case Bearing.South:
                {
                    Coordinate.Y--;
                    break;
                }
                    case Bearing.East:
                {
                    Coordinate.X++;
                    break;
                }
                    case Bearing.West:
                {
                    Coordinate.X--;
                    break;
                }
            }
        }

        public void Simulate(string simulation)
        {
            char[] moves = simulation.ToCharArray();
            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'L':
                    {
                        TurnLeft();
                        break;
                    }
                    case 'R':
                    {
                        TurnRight();
                        break;
                    }
                    case 'A':
                    {
                        MoveAhead();
                        break;
                    }
                }
            }
        }
    }

    public class Coordinate
    {
        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int Y { get; set; }

        public int X { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var coordinate = (Coordinate) obj;
            return coordinate.X == X && coordinate.Y == Y;
        }
    }
    public enum Bearing
    {
        North, East, South, West
    }
}
