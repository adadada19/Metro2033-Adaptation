using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class BulletStart : MonoBehaviour
{
    // Start is called before the first frame update
    public int numBullets;
    [SerializeField] private TextMeshProUGUI bulletText;
    void Start()
    {
        numBullets = 2;
        //bulletText.text = "Патроны: " + numBullets;
    }

    // Update is called once per frame
    void Update()
    {
        //bulletText = gameObject.GetComponent<Text>();
        bulletText.text = "Патроны: " + numBullets;
    }
}
