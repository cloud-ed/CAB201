namespace IterativeMethods;
class Iterable : IIterable
{
    private List<string> list;
    public Iterable()
    {
        // Insert your solution here to initialise the list.
        list = new List<string>();
    }

    public void Add(string s)
    {
        // Insert your solution here to add the string to the list.
        list.Add(s);
    }

    public void Remove(string s)
    {
        // Insert your solution here to remove the string from the list.
        list.Remove(s);
    }

    public void ForEach(Action action)
    {
        // Insert your solution here to:
        // 1. For each string in the list, apply the action delegate to it.
        foreach (string s in list)
        {
            action(s);
        }
    }

    public IIterable Map(MapDelegate map)
    {
        // Insert your solution here to:
        // 1. Create a new iterable.
        // 2. For each string in the list, apply the map delegate to it, and add the result to the new iterable.
        // 3. Return the new iterable.
        Iterable results = new Iterable();
        foreach(string s in list)
        {
            map(s);
            results.Add(s);
        }
        return results;
    }

    public IIterable Filter(Predicate filter)
    {
        // Insert your solution here to:
        // 1. Create a new iterable.
        // 2. For each string in the list, apply the filter delegate to it.
        // 3. If the string satisfies the predicate, add it to the new iterable.
        // 4. Return the new iterable.
        Iterable results = new Iterable();
        foreach (string s in list)
        {
            if (filter(s))
            {
                results.Add(s);
            }
        }
        return results;
    }
}