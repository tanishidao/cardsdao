using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class CardImageHelper : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteAtlas CardAtlas;

    public Sprite GetCardSprite(Card card = null)
    {
        var cardNum = 0;

        if (card == null)
        {
            cardNum = 54;
        }
        else
        {
            cardNum = card.Number + ((int)card.CardSuit * 13) - 1;
        }

        var cardSprite = CardAtlas.GetSprite($"Card_{cardNum}");
        return cardSprite;
    }
}
