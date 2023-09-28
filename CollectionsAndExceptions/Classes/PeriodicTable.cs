using CollectionsAndExceptions.Exceptions;
using CollectionsAndExceptions.Extensions;
using System.Xml.Linq;

namespace CollectionsAndExceptions.Classes;

public class PeriodicTable
{
    List<Element> elements = new();

    Queue<Element> q = new();
    public Element NewElement { get; set; } = new();

    public string Add()
    {
        //if (!NewElement.Check()) return;
        try
        {
            NewElement.Check();
            q.Enqueue((Element)NewElement.Clone());
            elements.Add(NewElement);

            NewElement.Name = "Changed value";
            return string.Empty;
        }
        catch (ElementException ex) when (ex.Element?.PeriodicNumber < 0) 
        {
            return $"{ex.Message} {ex.Element?.PeriodicNumber}";
        }
        catch (ElementException ex) when (ex.Element?.PeriodicNumber >= 230)
        {
            return $"{ex.Message} {ex.Element?.PeriodicNumber}";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
        finally { }
    }

    public Element? Get()
    {
        if (q.Count == 0) throw new IndexOutOfRangeException("Queue is empty.");

        var cloedList = elements.CloneList();

        NewElement.Name = "New value";

        return q.Dequeue();
    }
}
