using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardStack : MonoBehaviour
{
    public Card[] awaibleCards = new Card[2];
    public LinkedList<Card> cards = new LinkedList<Card>();
    
    private void Start()
    {
        CreateDeck();
    }

    private void CreateDeck()
    {
        for (int i = 0; i < 5; i++)
        {
            var index = Mathf.RoundToInt(Random.value * awaibleCards.Length) - 1;
            if (index < 0)
                index = 0;

            cards.AddLast(awaibleCards[index]);
        }
    }
}
