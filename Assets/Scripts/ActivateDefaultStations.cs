using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDefaultStations : MonoBehaviour
{
    int armyName;
    GameObject start;
    public Transform[] allStations;
    public List<GameObject> stations = new List<GameObject>();
    public Material[] materials;
    // Start is called before the first frame update
/*    public void StationCounter()
    {
        *//*Transform[] *//*allStations = this.transform.GetComponentsInChildren<Transform>();
        //allStation = allStations;
        *//*       for (int i = 0; i < allStations.Length; i++)
               {
                   Debug.Log(allStations[i].name);
               }*//*

    }*/
    public void ActivateStations()
    {

        start = GameObject.Find("TypeOfArmy");
        ArmyType armyType = start.GetComponent<ArmyType>();
        armyName = armyType.type;
        switch (armyName)
        {
            //Бандиты
            case 1:
                {
                    foreach (var station in stations)
                    {
                        if (station.name.Equals("Tretyakovskaya_Orange") || station.name.Equals("Tretyakovskaya_Yellow") || station.name.Equals("Novokuzneckaya"))
                        {
                            //Debug.Log("Found one");
                            station.gameObject.GetComponent<SpriteRenderer>().material = materials[0];
                            station.gameObject.SetActive(true);
                            //station.transform.gameObject.SetActive(true);
                        }
                    }
                    break;
                }
            //Бауманский альянс    
            case 2:
                {
                    foreach (var station in stations)
                    {
                        if (station.name.Equals("Baumanskaya") || station.name.Equals("Kurskaya_Purple") || station.name.Equals("Chkalovskaya"))
                        {
                            //Debug.Log("Found one");
                            station.gameObject.GetComponent<SpriteRenderer>().material = materials[1];
                            station.gameObject.SetActive(true);
                            //station.transform.gameObject.SetActive(true);
                        }
                    }
                    break;
                }
            //Арбатская конфедерация
            case 3:
                {
                    foreach (var station in stations)
                    {
                        if (station.name.Equals("Kyivskaya_Blue") || station.name.Equals("Kyivskaya_Purple") || station.name.Equals("Smolenskaya_Purple"))
                        {
                            //Debug.Log("Found one");
                            station.gameObject.GetComponent<SpriteRenderer>().material = materials[2];
                            station.gameObject.SetActive(true);
                            //station.transform.gameObject.SetActive(true);
                        }
                    }
                    break;
                }
            //Красная линия
            case 4:
                {
                    foreach (var station in stations)
                    {
                        if (station.name.Equals("OhotnyiRyad") || station.name.Equals("Teatralnaya") || station.name.Equals("PloshadRevolutsiy"))
                        {
                            //Debug.Log("Found one");
                            station.gameObject.GetComponent<SpriteRenderer>().material = materials[3];
                            station.gameObject.SetActive(true);
                            //station.transform.gameObject.SetActive(true);
                        }
                    }
                    break;
                }
            //Конфедерация 1905 года
            case 5:
                {
                    foreach (var station in stations)
                    {
                        if (station.name.Equals("Begovaya") || station.name.Equals("Ulitsa1905Goda") || station.name.Equals("Barrikadnaya_Pink"))
                        {
                            //Debug.Log("Found one");
                            station.gameObject.GetComponent<SpriteRenderer>().material = materials[4];
                            station.gameObject.SetActive(true);
                            //station.transform.gameObject.SetActive(true);
                        }
                    }
                    break;
                }
            //Четвёртый рейх
            case 6:
                {
                    foreach (var station in stations)
                    {
                        if (station.name.Equals("Pushkinskaya") || station.name.Equals("Tverskaya") || station.name.Equals("Chehovskaya"))
                        {
                            //Debug.Log("Found one");
                            station.gameObject.GetComponent<SpriteRenderer>().material = materials[5];
                            station.gameObject.SetActive(true);
                            //station.transform.gameObject.SetActive(true);
                        }
                    }
                    break;
                }
        }
    }
}
