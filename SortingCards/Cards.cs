using System;

namespace SortingCards;

public class Card : IComparable<Card> {
    public int rank = 0;
    public int suit = 0;

    public Card(int rank, int suit) {
        this.rank = rank;
        this.suit = suit;
    }

    public int CompareTo(Card c) {
        // CODE HERE!
        throw new NotImplementedException();
    }

    public override string ToString() {
        return $"{this.rank}, {this.suit}";
    }
}