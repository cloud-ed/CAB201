namespace SecuritySystem
{
    class Fence : Obstacle
    {
        private Point endPos;
        private List<Point> points;
        public Fence(Point startPoint, Point endPoint) : base(startPoint) 
        {
            endPos = endPoint;
            points = new List<Point> { startPoint, endPoint };
            if (endPos.x == pos.x)
            {
                if (endPos.y > pos.y)
                {
                    for (int i = pos.y + 1; i < endPos.y; i++)
                    {
                        points.Add(new Point(pos.x, i));
                    }
                    return;
                }
                for (int i = endPos.y + 1; i < pos.y; i++)
                {
                    points.Add(new Point(pos.x, i));
                }
                return;
            }
            if (endPos.x > pos.x)
            {
                for (int i = pos.x + 1; i < endPos.x; i++)
                {
                    points.Add(new Point(i, pos.y));
                }
                return;
            }
            for (int i = endPos.x + 1; i < pos.x; i++)
            {
                points.Add(new Point(i, pos.y));
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
            foreach(Point p in points)
            {
                Point localPos = p.MakeLocal(map);
                map.PlotPoint(localPos, 'f');
            }
        }
    }
}
