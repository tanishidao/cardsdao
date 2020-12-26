using System.Collections;
using System.Collections.Generic;


public class Card 
{
  public enum Suit
    { 
     Invalide = -1,
            club,///0
            Dia,///1
            Heart,///2
            Spade,///3
            Max
    }

    public Suit CardSuit = Suit.Invalide;
    public int Number = 0;

    public Card(Suit suit, int number)
    {
        this.CardSuit = suit;
        this.Number = number;
    }


}
