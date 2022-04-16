using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PigStart : MonoBehaviour
{
    // Start is called before the first frame update
    public int numPigs;
    [SerializeField] private TextMeshProUGUI pigText;
    void Start()
    {
        numPigs = 2;
        pigText.text = ("Свиньи: " + numPigs).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        pigText.text = ("Свиньи: " + numPigs).ToString();

    }
}
