using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HeroType : MonoBehaviour
{
    readonly string[] heroes = new string[] { "���", "����", "�������", "������", "����", "����" };
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
                    hero.text = "��� �����: " + heroes[0];
                    break;
                }
            case 2:
                {
                    hero.text = "��� �����: " + heroes[1];
                    break;
                }
            case 3:
                {
                    hero.text = "��� �����: " + heroes[2];
                    break;
                }
            case 4:
                {
                    hero.text = "��� �����: " + heroes[3];
                    break;
                }
            case 5:
                {
                    hero.text = "��� �����: " + heroes[4];
                    break;
                }
            case 6:
                {
                    hero.text = "��� �����: " + heroes[5];
                    break;
                }
        }
    }
}
