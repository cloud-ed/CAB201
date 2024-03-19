namespace SecuritySystem
{
    class Sensor : Obstacle
    {
        private float range;
        private List<Point> points;
        public Sensor(Point point, float range) : base(point)
        {
            points = new List<Point>();
            this.range = range;
            int roundedRange = (int)Math.Ceiling(range);
            Point topLeft = new Point(point.x - roundedRange, point.y - roundedRange);
            Point botRight = new Point(point.x + roundedRange, point.y + roundedRange);

            for (int x = topLeft.x; x < botRight.x; x++)
            {
                for (int y = topLeft.y; y < botRight.y; y++)
                {
                    if (Math.Sqrt(Math.Pow(x - point.x, 2) + Math.Pow(y - point.y, 2)) < this.range)
                    {
                        points.Add(new Point(x, y));
                    }
                }
            }
        }

        public override bool InObstacle(Point point)
        {
            int x = point.x; 
            int y = point.y;
            return InObstacle(x, y);
        }

        public override bool InObstacle(int x, int y)
        {
            foreach (Point p in points)
            {
                if (p.x == x && p.y == y) { return true; }
            }
            return false;
        }

        public override void Draw(Map map)
        {
            foreach (Point p in points)
            {
                Point localPos = p.MakeLocal(map);
                map.PlotPoint(localPos, 's');
            }
        }
    }
}
