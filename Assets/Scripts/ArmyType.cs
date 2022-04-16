using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ArmyType : MonoBehaviour
{
    readonly public string[] armies = new string[] { "�������", "���������� ������", "��������� ������������", "������� �����", "������������ 1905 ����", "�������� ����" };
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
                    army.text = "���� �����: " + armies[0];
                    break;
                }
            case 2:
                {
                    army.text = "���� �����: " + armies[1];
                    break;
                }
            case 3:
                {
                    army.text = "���� �����: " + armies[2];
                    break;
                }
            case 4:
                {
                    army.text = "���� �����: " + armies[3];
                    break;
                }
            case 5:
                {
                    army.text = "���� �����: " + armies[4];
                    break;
                }
            case 6:
                {
                    army.text = "���� �����: " + armies[5];
                    break;
                }
        }
    }
}
