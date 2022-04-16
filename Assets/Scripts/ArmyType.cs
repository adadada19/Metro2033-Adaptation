using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ArmyType : MonoBehaviour
{
    readonly public string[] armies = new string[] { "Бандиты", "Бауманский альянс", "Арбатская конфедерация", "Красная линия", "Конфедерация 1905 года", "Четвёртый рейх" };
    GameObject a;
    public int type;
    [SerializeField] private TextMeshProUGUI army;
    private void Start()
    {
        a = GameObject.Find("Start/PickACharacterAndArmy");
    }
    public void TypeOfArmy()
    {
        StartGameRandomizer button = a.GetComponent<StartGameRandomizer>();
        type = button.randomArmy;
        switch (type)
        {
            case 1:
                {
                    army.text = "Ваша армия: " + armies[0];
                    break;
                }
            case 2:
                {
                    army.text = "Ваша армия: " + armies[1];
                    break;
                }
            case 3:
                {
                    army.text = "Ваша армия: " + armies[2];
                    break;
                }
            case 4:
                {
                    army.text = "Ваша армия: " + armies[3];
                    break;
                }
            case 5:
                {
                    army.text = "Ваша армия: " + armies[4];
                    break;
                }
            case 6:
                {
                    army.text = "Ваша армия: " + armies[5];
                    break;
                }
        }
    }
}
