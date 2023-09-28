using CollectionsAndExceptions.Classes;

namespace CollectionsAndExceptions.Exceptions;

public class ElementException : Exception
{
    public Element? Element { get; init; }

    public ElementException(Element? element, string mesage) : base(mesage) => Element = element;
    
}
