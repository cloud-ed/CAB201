namespace IterativeMethods;
public delegate string MapDelegate(string s);
public delegate bool Predicate(string s);
public delegate void Action(string s);
interface IIterable
{
    /// <summary>
    /// Returns a new iterable with the results of applying the map delegate to each element in the iterable.
    /// </summary>
    /// <param name="map">The map delegate that can be applied to each string in the iterable.</param>
    /// <returns>A new iterable with the results of applying the map delegate to each element in the iterable.</returns>
    IIterable Map(MapDelegate map);

    /// <summary>
    /// Returns a new iterable with the elements that satisfy the predicate.
    /// </summary>
    /// <param name="filter">The predicate that can be applied to each string in the iterable.
    /// Strings that satisfy the predicate will be included in the new iterable, while strings
    /// that do not satisfy the predicate will be excluded.</param> 
    /// <returns>A new iterable with the elements that satisfy the predicate.</returns>
    IIterable Filter(Predicate filter);

    /// <summary>
    /// Applies the action to each element in the iterable.
    /// </summary>
    /// <param name="action">The action that can be applied to each string in the iterable.</param>
    void ForEach(Action action);

    /// <summary>
    /// Adds a string to the iterable.
    /// </summary>
    void Add(string s);

    /// <summary>
    /// Removes a string from the iterable.
    /// </summary>
    void Remove(string s);
}