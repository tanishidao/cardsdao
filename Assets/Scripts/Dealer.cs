using System.Collections.Generic;
using UnityEngine;

public class Dealer : MonoBehaviour
{
    private List<Card> GameDeck = new List<Card>();//new list<型の変数>

    private void Awake()
    {
        GameStart();
    }

    public List<Card> GetPlayerDeck()
    {
        var playerDeck = new List<Card>();
        for (int i = 0; i < CardHelper.CardMax; i++)
        {
            if (i % 2 == 0) ///剰余演算子　余りをだす、偶数番目
            {
                playerDeck.Add(GameDeck[i]);//addするリスト（remove[番号]-1とか大きいのはエラー
            }

        }


        return playerDeck;
    }

    public List<Card> GetCPUDeck()
    {
        var cpuDeck = new List<Card>();
        for (int i = 0; i < CardHelper.CardMax; i++)
        {
            if (i % 2 != 0)///!=は右辺と違うとき0じゃゃないとき
            {
                cpuDeck.Add(GameDeck[i]);
            }

        }
        return cpuDeck;

    }

    public void GameStart()
    {
        GameDeck = Deck.GetDeck();
        GameDeck = Deck.ShuffleDeck(GameDeck); ///Lsit.where はさがすやつ
   
    
    }
    public bool GameEnd(List<Card>playerDeck)
    {
        return playerDeck.Count == 0;
    }
}

