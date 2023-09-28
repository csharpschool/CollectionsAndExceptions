namespace CollectionsAndExceptions.Classes;

public enum Suits
{
    Hearts, Spades, Diamonds, Clubs
}

public class Deck
{
    private List<Card> _cards = new();
    public List<Card> Cards { get; init; } = new();

    /*public Deck()
    {
        CreateDeck();
    }*/

    /*public void Filter(string suit)
    {
        Cards.Clear();
        Cards.AddRange(_cards.Where(c => c.Suit == suit).ToList());
    }*/
    public void Filter(Suits suit)
    {
        Cards.Clear();
        Cards.AddRange(_cards.Where(c => c.Suit == suit).ToList());
    }

    public void CreateDeck()
    {
        try
        {
            foreach (var suit in Enum.GetValues<Suits>())
                for (int i = 2; i <= 14; i++)
                    _cards.Add(new Card(i, suit));
            
            Cards.AddRange(_cards);
        }
        catch
        {
            throw;
        }
    }
}
