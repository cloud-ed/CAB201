namespace SecuritySystem
{
    abstract class Obstacle : IDrawable
    {
        public Point pos { get; }
        public Obstacle(Point point)
        {
            pos = point;
        }

        /// <summary>
        /// Checks if the point is within the obstacle.
        /// </summary>
        /// <param name="point"></param>
        /// <returns>True if the point is within the obstacle</returns>
        public abstract bool InObstacle(Point point);

        /// <summary>
        /// Checks if the point is within the obstacle.
        /// </summary>
        /// <param name="x">The X value of the point</param>
        /// <param name="y">The Y value of the point</param>
        /// <returns>True if the point is within the obstacle</returns>
        public abstract bool InObstacle(int x, int y);

        /// <summary>
        /// Draws the obstacle onto the map.
        /// </summary>
        /// <param name="map"></param>
        public abstract void Draw(Map map);
    }
}
