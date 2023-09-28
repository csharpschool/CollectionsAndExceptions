namespace CollectionsAndExceptions.Classes;

public class Card
{
    public int Value { get; set; }
    public Suits Suit { get; set; }

    public Card(int value, Suits suit) => (Value, Suit) = (value, suit);
}
