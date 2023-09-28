using CollectionsAndExceptions.Extensions;
using System.Xml.Linq;

namespace CollectionsAndExceptions.Classes;

public class PeriodicTable
{
    List<Element> elements = new();

    Queue<Element> q = new();
    public Element NewElement { get; set; } = new();

    public void Add()
    {
        if (!NewElement.Check()) return;

        q.Enqueue((Element)NewElement.Clone());
        elements.Add(NewElement);

        NewElement.Name = "Changed value";
    }

    public Element? Get()
    {
        if (q.Count == 0) return null;

        var cloedList = elements.CloneList();

        NewElement.Name = "New value";

        return q.Dequeue();
    }
}
