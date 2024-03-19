namespace SecuritySystem
{
    internal class Map
    {
        private char[,] map; 
        private Point TopLeft { get; }
        private Point BotRight { get; }

        public Map(Point TopLeft, Point BotRight)
        {
            this.TopLeft = TopLeft;
            this.BotRight = BotRight;
            int xLength = BotRight.x - TopLeft.x + 1;
            int yLength = BotRight.y - TopLeft.y + 1;
            map = new char[yLength, xLength];

            for (int i = 0; i < xLength; i++)
            {
                for (int j = 0; j < yLength; j++)
                {
                    PlotPoint(i, j);
                }
            }
        }

        /// <summary>
        /// Plots a point at the specified location with the specified character.
        /// </summary>
        /// <param name="x">The X value of the point</param>
        /// <param name="y">The Y value of the point</param>
        /// <param name="c">Character used to plot the point, defaults to '.'</param>
        public void PlotPoint(int x, int y, char c = '.')
        {
            if (!ContainPoint(x, y)) { return; }
            map[y, x] = c;
        }

        /// <summary>
        /// Plots a point at the specified location with the specified character.
        /// </summary>
        /// <param name="point"></param>
        /// <param name="c">Character used to plot the point, defaults to '.'</param>
        public void PlotPoint(Point point, char c = '.')
        {
            int x = point.x;
            int y = point.y;
            PlotPoint(x, y, c);
        }

        /// <summary>
        /// Displays the map.
        /// </summary>
        /// <param name="TopLeft">The top left point of the map</param>
        /// <param name="BotRight">The bottom right point of the map</param>
        public void Display()
        {
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    Console.Write(map[y, x]);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Checks if the point is within the boundaries of the map.
        /// </summary>
        /// <param name="x">The X value of the point</param>
        /// <param name="y">The Y value of the point</param>
        /// <returns></returns>
        public bool ContainPoint(int x, int y)
        {
            return (x < map.GetLength(1) && y < map.GetLength(0) && x >= 0 && y >= 0);
        }

        /// <summary>
        /// Gets the X co-ordinate of the top left point of the map.
        /// </summary>
        /// <returns>The X value of the top left point</returns>
        public int GetTopX()
        {
            return TopLeft.x;
        }

        /// <summary>
        /// Gets the Y co-ordinate of the top left point of the map.
        /// </summary>
        /// <returns>The Y value of the top left point</returns>
        public int GetTopY()
        {
            return TopLeft.y;
        }

        /// <summary>
        /// Gets the X co-ordinate of the bottom right point of the map.
        /// </summary>
        /// <returns>The X value of the bottom right point</returns>
        public int GetBottomX()
        {
            return BotRight.x;
        }

        /// <summary>
        /// Gets the Y co-ordinate of the bottom right point of the map.
        /// </summary>
        /// <returns>The Y value of the bottom right point</returns>
        public int GetBottomY()
        {
            return BotRight.y;
        }
    }
}
