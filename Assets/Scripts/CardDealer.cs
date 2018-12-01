using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDealer : MonoBehaviour
{

    public CardStack cardStack;
    public GameObject card;
    public Hand hand;

    private GameObject drawedCard;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    //Debug.Log(GiveCard());
        //    //card.GetComponent<CardDisplay>().card = (HeroCard)DrawCard();
        //    //drawedCard = Instantiate(card, cardStack.transform);
        //    //drawedCard.GetComponent<Rigidbody>().position = new Vector3(0, 0, 0);
        //    //StartCoroutine(PlaceCard());
        //}
    }

    public Card GiveCard()
    {
        if (cardStack.cards.Count == 0)
        {
            //TODO: Change return to something other than 'null'
            return null;
        }

        var value = cardStack.cards.First.Value;
        cardStack.cards.RemoveFirst();
        return value;
    }
}

