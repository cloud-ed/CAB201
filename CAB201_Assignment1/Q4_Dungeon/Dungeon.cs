namespace DungeonTask;

class Dungeon
{
    public Room FirstRoom;
    public Room LastRoom;

    public Dungeon()
    {
        FirstRoom = null;
    }
    // Check if first room is empty, if so, dungeon is empty
    public bool IsEmpty()
    {
        if (FirstRoom == null) return true;
        return false;
    }

    // When adding a room, check if first room is empty, if so, new room is first room, else append it to the room after last
    public void AddRoom(string Enemy)
    {
        Room newRoom = new Room(Enemy);
        if (IsEmpty())
        {
            FirstRoom = newRoom;
        }
        else
        {
            LastRoom.NextRoom = newRoom;
        }
        LastRoom = newRoom;
    }

    // Reverse room order
    public void Reverse()
    {
        Room PrevRoom = null;
        Room current = FirstRoom;
        Room tempNext = null;
        while (current != null)
        {
            tempNext = current.NextRoom;
            current.NextRoom = PrevRoom;
            PrevRoom = current;
            current = tempNext;
        }
        FirstRoom = PrevRoom;
    }

    // Display each enemy going down the list of rooms until reach null (end of dungeon)
    public void Display()
    {
        Room current = FirstRoom;
        while (current != null)
        {
            Console.WriteLine(current.Enemy);
            current = current.NextRoom;
        }
        return;
    }
}