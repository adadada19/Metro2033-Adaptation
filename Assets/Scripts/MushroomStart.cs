using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class MushroomStart : MonoBehaviour
{
    // Start is called before the first frame update
    public int numMushrooms;
    [SerializeField] private TextMeshProUGUI mushroomText;
    void Start()
    {
        numMushrooms = 2;
        mushroomText.text = "Грибы: " + numMushrooms;
    }

    // Update is called once per frame
    void Update()
    {
        mushroomText.text = "Грибы: " + numMushrooms;

    }
}
