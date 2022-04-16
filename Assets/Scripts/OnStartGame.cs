using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OnStartGame : MonoBehaviour
{
    private GameObject resources;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
    }
    public void Activate()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
}
