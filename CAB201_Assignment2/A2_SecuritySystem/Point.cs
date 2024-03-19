namespace SecuritySystem
{
    class Point
    {
        public int x { get; private set; }
        public int y { get; private set; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Turns the point into the localised version of co-ordinates relative to the inputted map's dimensions.
        /// </summary>
        /// <param name="map"></param>
        /// <returns>A localised version of the Point</returns>
        public Point MakeLocal(Map map)
        {
            x = x - map.GetTopX();
            y = y - map.GetTopY();
            return new Point(x, y);
        }

        public static bool operator == (Point? left, Point? right)
        {
            if (object.ReferenceEquals(left, right))
            {
                return true;
            }
            if (object.ReferenceEquals(left, null) || object.ReferenceEquals(right, null))
            {
                return false;
            }
            if (left.x == right.x && left.y == right.y) { return true; }
            return false;
        }

        public override bool Equals(object? obj)
        {
            var other = obj as Point;
            if (other == null)
            {
                return false;
            }
            return this.x == other.x && this.y == other.y;
        }

        public override int GetHashCode()
        {
            return x.GetHashCode() ^ y.GetHashCode();
        }

        public bool Equals(Point other)
        {
            return this == other;
        }

        public static bool operator != (Point left, Point right)
        {
            return !(left == right);
        }
    }
}
