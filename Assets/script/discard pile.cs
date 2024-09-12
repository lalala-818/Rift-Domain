using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Discardpile : MonoBehaviour
{
    public Dictionary<int, Card> discardPile = new Dictionary<int, Card>();
public void AddCard(Card card)
    {
        discardPile.Add(card.cardID, card);
    }

    public Card GetCard(int cardID)
    {
        if (discardPile.ContainsKey(cardID))
        {
            return discardPile[cardID];
        }
        else
        {
            return null;
        }
    }

    public void RemoveCard(int cardID)
    {
        discardPile.Remove(cardID);
    }
    public void Clear()
    {

    }
}
