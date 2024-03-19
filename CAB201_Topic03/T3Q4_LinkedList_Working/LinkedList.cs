using System.Runtime.ExceptionServices;
using System.Xml.Schema;

namespace LinkedLists;

class LinkedList
{
    public Node first;
    public Node last;
    public Node current;
    
    // Sets first to null when first initializing a list
    public LinkedList()
    {
        first = null;
    }

    // Checks if first is null, meaning list is empty
    public bool IsEmpty()
    {
        if (first == null) return true;
        return false;
    }

    // Checks if first node is empty, if so, first node becomes the new node. Else, the next node after the last is the new node. Finally, move last node to the new last node.
    public void Add(double value)
    {
        Node newNode = new Node(value);
        if (IsEmpty())
        {
            first = newNode;
        }
        else
        {
            last.next = newNode;
        }
        last = newNode;
    }

    // Move current node to first node. While the current is not null, move along the list and add values to sum. When reach null, return sum.
    public double Sum()
    {
        double sum = 0;
        Node current = first;
        while (current != null)
        {
            sum += current.value;
            current = current.next;
        }
        return sum;
    } 
}