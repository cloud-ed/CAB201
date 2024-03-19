using System.Runtime.CompilerServices;

namespace SecuritySystem
{
    class GuardBear : Obstacle
    {
        private char dir;
        public GuardBear(Point point, char direction) : base(point)
        {
            dir = direction;
        }


        public override bool InObstacle(Point point)
        {
            int x = point.x;
            int y = point.y;
            return InObstacle(x, y);
        }

        public override bool InObstacle(int x, int y)
        {
            switch (dir)
            {
                case 'n':
                    if (x == pos.x && y <= pos.y) { return true; }
                    else { break; }
                case 's':
                    if (x == pos.x && y >= pos.y) { return true; }
                    else { break; };
                case 'e':
                    if (y == pos.y && x >= pos.x) { return true; }
                    else { break; }
                case 'w':
                    if (y == pos.y && x <= pos.x) { return true; }
                    else { break; }
            }
            return false;
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
                        map.PlotPoint(point, 'b');
                    }
                }
            }
        }
    }
}
