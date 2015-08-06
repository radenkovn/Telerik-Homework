namespace MineSweeper.Classes
{
    public class Point
    {
        string name;
        int points;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        public Point() { }

        public Point(string name, int points)
        {
            this.name = name;
            this.points = points;
        }
    }
}
