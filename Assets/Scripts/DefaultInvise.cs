using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultInvise : MonoBehaviour
{
    GameObject stations;
    // Start is called before the first frame update
    void Start()
    {
        stations = GameObject.Find("Stations");

    }
    public void DeActivate()
    {
        ActivateDefaultStations stationCounter = stations.GetComponent<ActivateDefaultStations>();
        for (int i = 0; i < transform.childCount; i++)
        {
            for (int j = 0; j < transform.GetChild(i).transform.childCount; j++)
            {
                stationCounter.stations.Add(transform.GetChild(i).transform.GetChild(j).gameObject);
                transform.GetChild(i).transform.GetChild(j).gameObject.SetActive(false);
                //Debug.Log(stationCounter.stations[j].name);
            }
            
            //transform.GetChild(i).gameObject.SetActive(false);
            
        }
        //Debug.Log(stationCounter.stations.Count);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
