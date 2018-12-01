using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Stats
{
    public string name;

    public Sprite artwork;

    public float health;
    public float armor;
    public float attackDamage;

    public string skill_1;
    public string skill_2;
    // TODO: Enabele/Intigrade field
    public string skill_3;
}

public class CardDisplay : MonoBehaviour
{
    public Stats stats;

    public HeroCard card;
    private void Awake()
    {
        SetConstructor();
    }

    void Start()
    {

    }

    void Update()
    {
        SetCanvas();
    }

    private void SetConstructor()
    {
        this.stats.name = card.name;
        this.stats.artwork = card.artwork;
        this.stats.health = card.health;
        this.stats.armor = card.armor;
        this.stats.attackDamage = card.attackDamage;

        this.stats.skill_1 = card.skill_1;
        this.stats.skill_2 = card.skill_2;
    }



    private void SetCanvas()
    {
        SetConstructor();
        foreach (var textItem in GetComponentsInChildren<Text>())
        {
            switch (textItem.name)
            {
                case "Name":
                    textItem.text = stats.name;
                    break;
                case "Skill_1":
                    textItem.text = stats.skill_1;
                    break;
                case "Skill_2":
                    textItem.text = stats.skill_2;
                    break;
                case "AttackDamage":
                    textItem.text = stats.attackDamage.ToString();
                    break;
                case "Health":
                    textItem.text = stats.health.ToString();
                    break;
                case "Armor":
                    textItem.text = stats.armor.ToString();
                    break;

                default:
                    break;
            }
        }

        foreach (var spriteItem in GetComponentsInChildren<Image>())
        {
            switch (spriteItem.name)
            {
                case "Artwork":
                    spriteItem.sprite = stats.artwork;
                    break;

                default:
                    break;
            }
        }
    }
}
