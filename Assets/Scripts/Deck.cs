using System;
using System.Collections.Generic;
using System.Linq;

public class Deck 
{
    /// <summary>
    /// 昇順のdeckをゲットする
    /// </summary>
    /// <returns></returns>
    public static List<Card>GetDeck()
    {
        var deck = new List<Card>();

        for(int i = 0; i<CardHelper.CardMax; i++)
        {
            deck.Add(new Card(CardHelper.CardSuitJudge(i), CardHelper.CardNumJudge(i)));
        }
        return deck;
    }

    public static List<Card>ShuffleDeck(List<Card>deck)
    {
        var shuffleDeck = deck.OrderBy(cardops => Guid.NewGuid()).ToList();
        return shuffleDeck;
    }

    /// <summary>
    /// カードをdeckの中から取得
    /// </summary>
    /// <param name="deck"></param>
    /// <returns></returns>
    public static Card GetCard(List<Card>deck)
    {
        var card = deck.First();
        deck.RemoveAt(0);
        return card;
    }
}
