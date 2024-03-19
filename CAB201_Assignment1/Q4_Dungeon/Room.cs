namespace DungeonTask;

class Room
{
    public string Enemy;
    public Room NextRoom;

    // Create rooms have enemy and refer to next room
    public Room(string Enemy)
    {
        this.Enemy = Enemy;
        NextRoom = null;
    }
}