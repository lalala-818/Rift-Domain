using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public Dictionary<int, Card> deck = new Dictionary<int, Card>();
    public Discardpile discard;
    private int nextCardId = 1;
    public void AddCard(Card card)
    {
        deck.Add(nextCardId, card);
        Debug.Log($"Added card: {card.cardName} with ID: {nextCardId}");
        nextCardId++;
    }
    public void RemoveCard(int cardId)
    {
        if (deck.ContainsKey(cardId))
        {
            Card removedCard = deck[cardId];
            deck.Remove(cardId);
            Debug.Log($"Removed card: {removedCard.cardName} with ID: {cardId}");
        }
        else
        {
            Debug.Log($"Card with ID {cardId} not found in deck.");
        }
    }
    public void Shuffle()
    {
        List<Card> cardList = new List<Card>(deck.Values);
        System.Random rng = new System.Random();
        int n = cardList.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            Card value = cardList[k];
            cardList[k] = cardList[n];
            cardList[n] = value;
        }

        deck.Clear();
        for (int i = 0; i < cardList.Count; i++)
        {
            deck.Add(i + 1, cardList[i]);
        }

    }
    public Card DrawCard()
    {
        if (deck.Count == 0)
        {
            if (discard.discardPile.Count > 0)
            {
                Debug.Log("³éÅÆ¶ÑÒÑ¿Õ£¬½«ÆúÅÆ¶ÑµÄÅÆÖØÐÂÏ´Èë³éÅÆ¶Ñ¡£");
                deck = discard.discardPile;
                discard.Clear();
                Shuffle();
            }
            else
            {
                Debug.Log("³éÅÆ¶ÑºÍÆúÅÆ¶Ñ¶¼ÒÑ¿Õ£¡");
                return null;
            }
        }


        int cardId = deck.Keys.First();
        Card drawnCard = deck[cardId];
        deck.Remove(cardId);
        return drawnCard;
    }


}

