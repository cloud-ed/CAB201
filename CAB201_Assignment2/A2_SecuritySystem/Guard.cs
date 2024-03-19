namespace SecuritySystem
{
    class Guard : Obstacle
    {
        public Guard(Point point) : base(point) { }

        public override bool InObstacle(Point point)
        {
            int x = point.x;
            int y = point.y;
            return InObstacle(x, y);
        }

        public override bool InObstacle(int x, int y)
        {
            if (x == pos.x && y == pos.y)
            {
                return true;
            }
            return false;
        }

        public override void Draw(Map map)
        {
            Point localPos = pos.MakeLocal(map);
            map.PlotPoint(localPos, 'g');
        }
    }
}
