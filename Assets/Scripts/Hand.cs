using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class Hand : MonoBehaviour
{
    public LinkedList<Card> AvaibleCards;
    private short cardCount;
    public CardDealer CardDealer;
    public float cardGap = 0;

    private LinkedList<GameObject> cardInstances;
    public GameObject CardPrefab;
    public short MaxCards;

    public Button Btn;


    private void Start()
    {
        //AvaibleCards = new LinkedList<Card>();
        cardInstances = new LinkedList<GameObject>();
    }

    private void Update()
    {
    }

    /// <summary>
    ///     Takes card from cardDeaker, add it to 'hand' and render it
    /// </summary>
    public void DrawCard()
    {
        // TODO: Handle message to inform player about the reachment of 'MaxCards'

        if (cardCount >= MaxCards) return;

        var card = CardDealer.GiveCard();

        CardPrefab.GetComponent<CardDisplay>().card = (HeroCard) card;

        //var cardInstance = Instantiate(CardPrefab, transform);
        cardInstances.AddLast(Instantiate(CardPrefab, transform));

        AlignCards();

        cardCount++;
    }

    private void AlignCards()
    {
        float newPos = 0;
        var inLen = cardInstances.Count;

        // TODO: Algorithm is not adaptive
        switch (inLen % 2)
        {
            //even
            case 0:
                newPos = (-inLen / cardGap) - (inLen / 2 - 1);
                break;
            //odd
            case 1:
                newPos = (-inLen / cardGap) - (inLen / 2 - .5f);
                break;
            default:
                break;
        }

        foreach (var cardInstance in cardInstances)
        {
            var localPosition = cardInstance.GetComponentInChildren<RectTransform>().localPosition;
            cardInstance.GetComponentInChildren<RectTransform>().localPosition = new Vector3(newPos, 0, 0);
            newPos += cardGap;
        }
    }
}