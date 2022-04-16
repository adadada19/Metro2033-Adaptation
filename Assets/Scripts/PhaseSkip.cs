using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhaseSkip : MonoBehaviour
{
    public int Turn;
    // Start is called before the first frame update
    void Start()
    {
        Turn = 1;
        Button button = gameObject.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (Turn)
        {
            case 1:
                {
                    
                    break;
                }
            case 2:
                {
                    break;
                }
            case 3:
                {
                    break;
                }
            case 4:
                {
                    break;
                }
            case 5:
                {
                    break;
                }
        }
    }
}
