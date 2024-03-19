namespace SecuritySystem
{
    enum MenuOption
    {
        AddGuard = 'g',
        AddFence = 'f',
        AddSensor = 's',
        AddCamera = 'c',
        AddGuardBear = 'b',
        ShowSafeDirection = 'd',
        DisplayObstacleMap = 'm',
        FindSafePath = 'p',
        Exit = 'x'
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Obstacle> obstacles = new List<Obstacle>();
            while (true)
            {
                DisplayMenuOptions();
                Console.WriteLine("Enter code:");
                string? userInput = Console.ReadLine();
                if (userInput == null)
                {
                    Console.WriteLine("Invalid option.");
                }
                else 
                {
                    if (!char.TryParse(userInput.ToLower(), out char option))
                    {
                        Console.WriteLine("Invalid option.");
                        continue;
                    }
                    RunOption((MenuOption)option, out bool endProgram, obstacles);
                    if (endProgram)
                    {
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Displays all menu options.
        /// </summary>
        static void DisplayMenuOptions()
        {
            Console.WriteLine("Select one of the following options");
            Console.WriteLine("g) Add 'Guard' obstacle");
            Console.WriteLine("f) Add 'Fence' obstacle");
            Console.WriteLine("s) Add 'Sensor' obstacle");
            Console.WriteLine("c) Add 'Camera' obstacle");
            // The Guard Bear can only anything in a straight line in front of it (because of it's uniform blocking everything else) and it's vision can see through all objects, including fences
            Console.WriteLine("b) Add 'Guard Bear' obstacle");
            Console.WriteLine("d) Show safe directions");
            Console.WriteLine("m) Display obstacle map");
            Console.WriteLine("p) Find safe path");
            Console.WriteLine("x) Exit");
        }

        /// <summary>
        /// Runs the inputted menu option
        /// </summary>
        /// <param name="option">The inputted menu option</param>
        /// <param name="endProgram">returns endProgram = true when the program has been exited</param>
        /// <param name="obstacles">The list of obstacles created</param>
        static void RunOption(MenuOption option, out bool endProgram, List<Obstacle> obstacles)
        {
            switch (option)
            {
                case MenuOption.AddGuard:
                    Point guardPos;
                    while (true)
                    {
                        Console.WriteLine("Enter the guard's location (X,Y):");
                        if (!TryParseCoordInput(out guardPos))
                        {
                            Console.WriteLine("Invalid input.");
                        } 
                        else { break; }
                    }
                    Guard guard = new Guard(guardPos);
                    obstacles.Add(guard);
                    Console.WriteLine($"Guard added at ({guardPos.x},{guardPos.y}).");
                    break;

                case MenuOption.AddFence:
                    Point start;
                    Point end;
                    while (true)
                    {
                        while (true)
                        {
                            Console.WriteLine("Enter the location where the fence starts (X,Y):");
                            if (!TryParseCoordInput(out start))
                            {
                                Console.WriteLine("Invalid input.");
                            } 
                            else { break; }
                        }
                        while (true)
                        {
                            Console.WriteLine("Enter the location where the fence ends (X,Y):");
                            if (!TryParseCoordInput(out end))
                            {
                                Console.WriteLine("Invalid input.");
                            } 
                            else { break; }
                        }
                        if (start.x != end.x && start.y != end.y || start == end)
                        {
                            Console.WriteLine("Fences must be horizontal or vertical.");
                        } 
                        else { break; }
                    }
                    Fence fence = new Fence(start, end);
                    obstacles.Add(fence);
                    Console.WriteLine($"Fence added from ({start.x},{start.y}) to ({end.x},{end.y}).");
                    break;

                case MenuOption.AddSensor:
                    Point sensPos;
                    float sRange;
                    while (true)
                    {
                        Console.WriteLine("Enter the sensor's location (X,Y):");
                        if (!TryParseCoordInput(out sensPos))
                        {
                            Console.WriteLine("Invalid input.");
                        } 
                        else { break; }
                    }
                    while (true)
                    {
                        Console.WriteLine("Enter the sensor's range (in klicks):");
                        if (!float.TryParse(Console.ReadLine(), out sRange))
                        {
                            Console.WriteLine("Invalid input.");
                        }
                        else if (sRange <= 0.0)
                        {
                            Console.WriteLine("Invalid input.");
                        } 
                        else { break; }
                    }
                    Sensor sensor = new Sensor(sensPos, sRange);
                    obstacles.Add(sensor);
                    Console.WriteLine($"Sensor added at ({sensPos.x},{sensPos.y}) with a range of {sRange}.");
                    break;

                case MenuOption.AddCamera:
                    Point cameraPos;
                    char camDirection;
                    while (true)
                    {
                        Console.WriteLine("Enter the camera's location (X,Y):");
                        if (!TryParseCoordInput(out cameraPos))
                        {
                            Console.WriteLine("Invalid input.");
                        } 
                        else { break; }
                    }
                    while (true)
                    {
                        Console.WriteLine("Enter the direction the camera is facing (n, s, e or w):");
                        if (!char.TryParse(Console.ReadLine(), out camDirection))
                        {
                            Console.WriteLine("Invalid input.");
                        }
                        else if (char.ToLower(camDirection) != 'n' && char.ToLower(camDirection) != 's' && char.ToLower(camDirection) != 'e' && char.ToLower(camDirection) != 'w')
                        {
                            Console.WriteLine("Invalid input.");
                        } 
                        else { break; }
                    }
                    camDirection = char.ToLower(camDirection);
                    Camera camera = new Camera(cameraPos, camDirection);
                    obstacles.Add(camera);
                    string camDirName = "";
                    switch (camDirection)
                    {
                        case 'n': camDirName = "North"; break;
                        case 's': camDirName = "South"; break;
                        case 'e': camDirName = "East"; break;
                        case 'w': camDirName = "West"; break;
                    }
                    Console.WriteLine($"Camera added at ({cameraPos.x},{cameraPos.y}) facing {camDirName}.");
                    break;

                case MenuOption.AddGuardBear:
                    Point bearPos;
                    char bearDirection;
                    while (true)
                    {
                        Console.WriteLine("Enter the guard bear's location (X,Y):");
                        if (!TryParseCoordInput(out bearPos))
                        {
                            Console.WriteLine("Invalid input.");
                        }
                        else { break; }
                    }
                    while (true)
                    {
                        Console.WriteLine("Enter the direction the camera is facing (n, s, e or w):");
                        if (!char.TryParse(Console.ReadLine(), out bearDirection))
                        {
                            Console.WriteLine("Invalid input.");
                        }
                        else if (char.ToLower(bearDirection) != 'n' && char.ToLower(bearDirection) != 's' && char.ToLower(bearDirection) != 'e' && char.ToLower(bearDirection) != 'w')
                        {
                            Console.WriteLine("Invalid input.");
                        }
                        else { break; }
                    }
                    GuardBear guardBear = new GuardBear(bearPos, bearDirection);
                    obstacles.Add(guardBear);
                    string bearDirName = "";
                    switch (bearDirection)
                    {
                        case 'n': bearDirName = "North"; break;
                        case 's': bearDirName = "South"; break;
                        case 'e': bearDirName = "East"; break;
                        case 'w': bearDirName = "West"; break;
                    }
                    Console.WriteLine($"Guard Bear added at ({bearPos.x},{bearPos.y}) facing {bearDirName}.");
                    break;

                case MenuOption.ShowSafeDirection:
                    Console.WriteLine("Enter your current location (X,Y):");
                    Point cLocation;
                    while (true)
                    {
                        if (!TryParseCoordInput(out cLocation))
                        {
                            Console.WriteLine("Invalid input.");
                        } 
                        else { break; }
                    }
                    bool compromised = false;
                    foreach (Obstacle obstacle in obstacles)
                    {
                        if (obstacle.InObstacle(cLocation))
                        {
                            Console.WriteLine("Agent, your location is compromised. Abort mission.");
                            compromised = true;
                            break;
                        }
                    }
                    if (compromised == true) { break; }
                    string sDirection = GetSafeDirection(cLocation, obstacles);
                    if (sDirection.Length > 0)
                    {
                        Console.WriteLine($"You can safely take any of the following directions: {sDirection}");
                    }
                    else
                    {
                        Console.WriteLine($"You cannot safely move in any direction. Abort mission.");
                    }
                    break;

                case MenuOption.DisplayObstacleMap:
                    Point TopLeft;
                    Point BotRight;
                    while (true)
                    {
                        while (true)
                        {
                            Console.WriteLine("Enter the location of the top-left cell of the map (X,Y):");
                            if (!TryParseCoordInput(out TopLeft))
                            {
                                Console.WriteLine("Invalid map specification");
                            }
                            else { break; }
                        }
                        while (true)
                        {
                            Console.WriteLine("Enter the location of the bottom-right cell of the map (X,Y):");
                            if (!TryParseCoordInput(out BotRight))
                            {
                                Console.WriteLine("Invalid map specification");
                            }
                            else { break; }
                        }
                        if (!CheckMapValid(TopLeft, BotRight))
                        {
                            Console.WriteLine("Invalid map specification");
                        }
                        else
                        {
                            Map map = new Map(TopLeft, BotRight);
                            foreach(Obstacle ob in obstacles)
                            {
                                ob.Draw(map);
                            }
                            map.Display();
                            break;
                        }
                    }
                    break;

                case MenuOption.FindSafePath:
                    Point aLocation;
                    Point mLocation;
                    bool objectiveBlocked = false;
                    while (true)
                    {
                        Console.WriteLine("Enter your current location (X,Y):");
                        if (!TryParseCoordInput(out aLocation))
                        {
                            Console.WriteLine("Invalid input.");
                        }
                        else { break; }
                    }
                    while (true)
                    {
                        Console.WriteLine("Enter the location of the mission objective (X,Y):");
                        if (!TryParseCoordInput(out mLocation))
                        {
                            Console.WriteLine("Invalid input.");
                        }
                        else { break; }
                    }
                    if (aLocation == mLocation)
                    {
                        Console.WriteLine("Agent, you are already at the objective.");
                        break;
                    }
                    foreach (Obstacle ob in obstacles)
                    {
                        if (ob.InObstacle(mLocation)) 
                        { 
                            Console.WriteLine("The objective is blocked by an obstacle and cannot be reached.");
                            objectiveBlocked = true;
                            break;
                        }
                    }
                    if (objectiveBlocked) { break; }
                    string directions = "";
                    Console.WriteLine("The following path will take you to the objective:");
                    try
                    {
                        directions = GetDirectionsToObjective(aLocation, mLocation, obstacles);
                    } catch (NavigationException ex) { Console.WriteLine(ex.Message); break; }
                    Console.WriteLine(directions);
                    break;

                case MenuOption.Exit:
                    Console.WriteLine("Exiting Program.");
                    endProgram = true;
                    return;

                default: 
                    Console.WriteLine("Invalid input."); 
                    break;
            }
            endProgram = false;
        }

        /// <summary>
        /// Attempts to parse the user's input into a co-ordinate of the format (X,Y).
        /// </summary>
        /// <param name="point"></param>
        /// <returns>Returns true if successfully parsed user input into co-ordinates</returns>
        static bool TryParseCoordInput(out Point point)
        {
            string[] coords;
            while (true)
            {
                point = new Point(0,0);
                string? userInput = Console.ReadLine();
                if (userInput == null) { return false; }
                coords = userInput.Split(',');
                if (coords.Length != 2 || coords == null) { return false; }
                else if (!int.TryParse(coords[0], out int x))
                {
                    return false;
                }
                else if (!int.TryParse(coords[1], out int y))
                {
                    return false;
                }
                else { point = new Point(x, y); return true; }
            }
        }

        /// <summary>
        /// Gets safe directions from the point provided
        /// </summary>
        /// <param name="location"></param>
        /// <param name="obstacles">A list of obstacles created</param>
        /// <returns>A string containing the directions from the provided point that are not in an obstacle, in the form of cardinal directions represented by capitalized letters</returns>
        static string GetSafeDirection(Point location, List<Obstacle> obstacles)
        {
            bool North = true;
            bool South = true;
            bool East = true;
            bool West = true;
            foreach (Obstacle obstacle in obstacles)
            {
                if (obstacle.InObstacle(location.x, location.y - 1))
                {
                    North = false;
                }
                if (obstacle.InObstacle(location.x, location.y + 1))
                {
                    South = false;
                }
                if (obstacle.InObstacle(location.x + 1, location.y))
                {
                    East = false;
                }
                if (obstacle.InObstacle(location.x - 1, location.y))
                {
                    West = false;
                }
            }
            string safeDirections = "";
            if (North == true) { safeDirections += "N"; }
            if (South == true) { safeDirections += "S"; }
            if (East == true) { safeDirections += "E"; }
            if (West == true) { safeDirections += "W"; }
            return safeDirections;
        }

        /// <summary>
        /// Checks if the map is a valid map, meaning the bottom right co-ordinates are greater then the top left co-ordinates.
        /// </summary>
        /// <param name="TopLeft"></param>
        /// <param name="BotRight"></param>
        /// <returns>True if the map is valid</returns>
        static bool CheckMapValid(Point TopLeft, Point BotRight)
        {
            if (BotRight.x < TopLeft.x || BotRight.y < TopLeft.y) { return false; }
            return true;
        }

        /// <summary>
        /// Gets safe directions to the objective and returns the directions.
        /// </summary>
        /// <param name="agentLocation"></param>
        /// <param name="objectiveLocation"></param>
        /// <param name="obstacles">A list of obstacles created</param>
        /// <returns>A string containing the directions from the Agent Location to the Objective Location in the form of cardinal directions represented by capitalized letters</returns>
        static string GetDirectionsToObjective(Point agentLocation, Point objectiveLocation, List<Obstacle> obstacles)
        {
            string directions = "";
            // Using Hashset instead of List because it ensures that every value is unique, and therefore cannot accidentally re-visit a place that is visited
            HashSet<Point> visited = new HashSet<Point>();
            // Dictionary stores locations and next locations (similar to a linked list) so it can backtrack and plot out the path
            Dictionary<Point, Point> mappedPoints = new Dictionary<Point, Point>();
            // Add the objective location to visited
            visited.Add(objectiveLocation);
            // Assuming the grid would be at most a 50x50, if the agent was in the top right of the grid (50,0) and the objective was in the bottom left (0,50), due to the solution I created this would require a diamond to be formed around the objective to find the agent.
            // For each tile diagonally it requires 2 iterations of searching to reach, therefore it would require (maxGridsize - 1) * 2 iterations to reach the maxGridSize if it were diagonal of the starting location.
            const int maxGridSize = 50;
            int maxVisitedLocations = 1;
            int iterations = (maxGridSize - 1) * 2;
            // Starts from the start location being visited then iterates out until it reaches the maximum grid size (each iteration visits 4 more tiles then the last, so it is added incremented by 4 every time and added to the total)
            for (int i = 1; i < iterations; i++)
            {
                int temp = 4 * i;
                maxVisitedLocations += temp;
            }
            // Goes until it reaches the agentLocation and backtracks to find the path or reaches the maxVisitedLocations or is not able to get to the agentLocation
            List<Point> currentLocation = new List<Point> { objectiveLocation };
            while (visited.Count < maxVisitedLocations)
            {
                List<Point> points = new List<Point> { };
                foreach (Point p in currentLocation)
                {
                    // If it has reached agentLocation, backtrack to form the path to objectiveLocation
                    if (p == agentLocation)
                    {
                        Point backtrack = p;
                        while (backtrack != objectiveLocation)
                        {
                            Point parent = mappedPoints[backtrack];
                            if (parent.y < backtrack.y) { directions += "N"; }
                            else if (parent.y > backtrack.y) { directions += "S"; }
                            else if (parent.x > backtrack.x) { directions += "E"; }
                            else { directions += "W"; }
                            backtrack = parent;
                        }
                        return directions;
                    }
                    // Gets the current safe directions from where they are currently
                    string safeDirections = GetSafeDirection(p, obstacles);
                    // Loops through each direction that is safe and checks if it has been visited, else visit it and add to list, hashset and dictionary
                    foreach (char dir in safeDirections)
                    {
                        Point nextLocation = CalculateNextLocation(p, dir);
                        if (visited.Contains(nextLocation)) { }
                        else
                        {
                            points.Add(nextLocation);
                            mappedPoints.Add(nextLocation, p);
                            visited.Add(nextLocation);
                        }
                    }
                }
                // Update currentLocation to recorded points
                currentLocation = points;
            }
            // Returns not safe when can't reach agentLocation (out of the max assumed bounds (maxVisitedLocations) or can't physically reach the agentLocation
            throw new NavigationException("There is no safe path to the objective.");
        }

        /// <summary>
        /// Gets a new location moved to the direction specified.
        /// </summary>
        /// <param name="currentLocation"></param>
        /// <param name="dir">A cardinal direction represented by a capitalzed letter</param>
        /// <returns>A new Point 1 klick in the direction specified</returns>
        static Point CalculateNextLocation(Point currentLocation, char dir)
        {
            switch (dir)
            {
                case 'N':
                    return new Point(currentLocation.x, currentLocation.y - 1);
                case 'S':
                    return new Point(currentLocation.x, currentLocation.y + 1);
                case 'E':
                    return new Point(currentLocation.x + 1, currentLocation.y);
                case 'W':
                    return new Point(currentLocation.x - 1, currentLocation.y);
                default:
                    return currentLocation;
            }
        }
    }

    class NavigationException : Exception
    {
        public NavigationException() : base() { }
        public NavigationException(string message) : base(message) { }
        public NavigationException(string message, Exception? innerException) : base(message, innerException) { }
    }
}