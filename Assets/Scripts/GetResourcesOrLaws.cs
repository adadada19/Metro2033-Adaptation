using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetResourcesOrLaws : MonoBehaviour
{
    GameObject roundFirstPhase;
    public int RoundPhase;
    GameObject armyType;
    GameObject bullets;
    GameObject pigs;
    GameObject mushrooms;
    // Start is called before the first frame update
    void Start()
    {
        roundFirstPhase = GameObject.Find("RoundPhase");
        armyType = GameObject.Find("TypeOfArmy");
        bullets = GameObject.Find("Bullets");
        pigs = GameObject.Find("Pigs");
        mushrooms = GameObject.Find("Mushrooms");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        ArmyType army = armyType.GetComponent<ArmyType>();
        RoundPhase = 2;
        roundFirstPhase.GetComponent<RoundPhase>().FirstPhase();
        transform.gameObject.SetActive(false);
        switch (army.type)
        {
            case 1:
                {
                    BulletStart bullet = bullets.GetComponent<BulletStart>();
                    bullet.numBullets += 2;
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
                    PigStart pig = pigs.GetComponent<PigStart>();
                    pig.numPigs += 2;
                    break;
                }
            case 5:
                {
                    MushroomStart mushroom = mushrooms.GetComponent<MushroomStart>();
                    mushroom.numMushrooms += 2;
                    break;
                }
            case 6:
                {
                    break;
                }
        }
    }
}
