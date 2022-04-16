using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StartGameRandomizer : MonoBehaviour
{
    public int RoundPhase;
    GameObject army;
    GameObject hero;
    GameObject resources;
    GameObject roundFirstPhase;
    GameObject stations;
    GameObject nextTurnButton;
    public int randomArmy;
    public int randomHero;
    [SerializeField] private TextMeshProUGUI button;
    public GameObject ButtonStart;
    // Start is called before the first frame update
    void Start()
    {
        ButtonStart = GameObject.Find("Start/PickACharacterAndArmy");
        ButtonStart.SetActive(true);
        army = GameObject.Find("TypeOfArmy");
        hero = GameObject.Find("TypeOfHero");
        resources = GameObject.Find("Resources");
        stations = GameObject.Find("Stations");
        nextTurnButton = GameObject.Find("ClaimResources/Laws");
        nextTurnButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        randomArmy = Random.Range(1, 7);
        randomHero = Random.Range(1, 7);
        army.GetComponent<ArmyType>().TypeOfArmy();
        hero.GetComponent<HeroType>().TypeOfHero();
        Debug.Log("Номер армии: " + randomArmy);
        Debug.Log("Номер героя: " + randomHero);
        resources.GetComponent<OnStartGame>().Activate();
        roundFirstPhase = GameObject.Find("RoundPhase");
        RoundPhase = 1;
        roundFirstPhase.GetComponent<RoundPhase>().ZeroPhase();
        //stations.GetComponent<ActivateDefaultStations>().StationCounter();
        stations.GetComponent<DefaultInvise>().DeActivate();
        stations.GetComponent<ActivateDefaultStations>().ActivateStations();
        ButtonStart.SetActive(false);
        NextTurn();
    }
    void NextTurn()
    {
        nextTurnButton.SetActive(true);
    }
}
