using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCard0 : MonoBehaviour
{
    List<Card> playerDeck;

    // Start is called before the first frame update
    void Start()
    {
        playerDeck = Deck.GetDeck();
        var shuffleDeck = Deck.ShuffleDeck(playerDeck);
        playerDeck = shuffleDeck;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            var playerCard = Deck.GetCard(playerDeck);
            Debug.Log($"{playerCard.CardSuit}{playerCard.Number}");
        }
    }
}
