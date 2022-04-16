using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HeroType : MonoBehaviour
{
    readonly string[] heroes = new string[] { "Хан", "Артём", "Мельник", "Хантер", "Анна", "Саша" };
    GameObject a;
    int type;
    [SerializeField] private TextMeshProUGUI hero;
    void Start()
    {
        a = GameObject.Find("Start/PickACharacterAndArmy");
    }
    public void TypeOfHero()
    {
        StartGameRandomizer button = a.GetComponent<StartGameRandomizer>();
        type = button.randomHero;
        switch (type)
        {
            case 1:
                {
                    hero.text = "Ваш герой: " + heroes[0];
                    break;
                }
            case 2:
                {
                    hero.text = "Ваш герой: " + heroes[1];
                    break;
                }
            case 3:
                {
                    hero.text = "Ваш герой: " + heroes[2];
                    break;
                }
            case 4:
                {
                    hero.text = "Ваш герой: " + heroes[3];
                    break;
                }
            case 5:
                {
                    hero.text = "Ваш герой: " + heroes[4];
                    break;
                }
            case 6:
                {
                    hero.text = "Ваш герой: " + heroes[5];
                    break;
                }
        }
    }
}
