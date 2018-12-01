using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Hero Card", menuName = "cards/hero", order = 1)]
public class HeroCard : Card
{
    public string skill_1;
    public string skill_2;

    public float health;
    public float armor;
    public float attackDamage;
}
