namespace SecuritySystem
{
    class Camera : Obstacle
    {
        private char direction;
        public Camera(Point point, char direction) : base(point)
        {
            this.direction = direction;
        }

        public override bool InObstacle(Point point)
        {
            int x = point.x;
            int y = point.y;
            return InObstacle(x, y);
        }

        public override bool InObstacle(int x, int y)
        {
            int dx = Math.Abs(x - pos.x);
            int dy = Math.Abs(y - pos.y);
            switch (direction)
            {
                case 'n':
                    if (y > pos.y - dx)
                    {
                        return false;
                    }
                    break;
                case 's':
                    if (y < pos.y + dx)
                    {
                        return false;
                    }
                    break;
                case 'e':
                    if (x < pos.x + dy)
                    {
                        return false;
                    }
                    break;
                case 'w':
                    if (x > pos.x - dy)
                    {
                        return false;
                    }
                    break;
            }
            return true;
        }

        public override void Draw(Map map)
        {
            for (int y = map.GetTopY(); y <= map.GetBottomY(); y++)
            {
                for (int x = map.GetTopX(); x <= map.GetBottomX(); x++)
                {
                    if (InObstacle(x, y))
                    {
                        Point point = new Point(x, y);
                        point = point.MakeLocal(map);
                        map.PlotPoint(point, 'c');
                    }
                }
            }
        }
    }
}
