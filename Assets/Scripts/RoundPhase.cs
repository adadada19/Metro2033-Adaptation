using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RoundPhase : MonoBehaviour
{
    int PhaseOne;
    [SerializeField] private TextMeshProUGUI phase;
    GameObject a;
    GameObject b;
    // Start is called before the first frame update
    void Start()
    {
        a = GameObject.Find("Start/PickACharacterAndArmy");
        b = GameObject.Find("ClaimResources/Laws");
    }
    public void FirstPhase()
    {
        GetResourcesOrLaws button = b.GetComponent<GetResourcesOrLaws>();
        PhaseOne = button.RoundPhase;
        phase.text = "Фаза раунда: " + PhaseOne;
    }
    public void ZeroPhase()
    {
        Start();
        StartGameRandomizer button = a.GetComponent<StartGameRandomizer>();
        PhaseOne = button.RoundPhase;
        phase.text = "Фаза раунда: " + PhaseOne;

    }
}
