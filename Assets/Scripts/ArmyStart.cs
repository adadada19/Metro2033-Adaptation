using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ArmyStart : MonoBehaviour
{
    int numArmy;
    [SerializeField] private TextMeshProUGUI armyText;
    // Start is called before the first frame update
    void Start()
    {
        numArmy = 2;
        //armyText.text = "Армия: " + numArmy;
    }

    // Update is called once per frame
    void Update()
    {
        armyText.text = "Армия: " + numArmy;
    }
}
