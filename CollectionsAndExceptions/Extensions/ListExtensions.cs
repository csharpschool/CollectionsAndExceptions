using CollectionsAndExceptions.Classes;

namespace CollectionsAndExceptions.Extensions
{
    public static class ListExtensions
    {
        public static List<Element> CloneList(this List<Element> list) =>
            list.Select(element => (Element)element.Clone()).ToList();
    }
}
