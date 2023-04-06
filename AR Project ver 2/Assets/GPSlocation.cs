using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GPSlocation : MonoBehaviour
{
    public static GPSlocation Instance { set; get; }
    public float latitude;
    public float longitude;
    public Text coordinates;

    private void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        StartCoroutine(StartLocationService());
    }
    private void Update()
    {
        coordinates.text = "Lat:" + Instance.latitude.ToString() + "  Lon:" + Instance.longitude.ToString();
    }
    private IEnumerator StartLocationService()
    {
        if(!Input.location.isEnabledByUser)
        {
            Debug.Log("User didnt enable gps");
            yield break;
        }

        Input.location.Start();
        int maxWait = 20;
        while(Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }
         if(maxWait <= 0)
        {
            Debug.Log("Timed out");
            yield break;
        }
         if(Input.location.status == LocationServiceStatus.Failed)
        {
            Debug.Log("Unable to determin location");
            yield break;
        }

        latitude = Input.location.lastData.latitude;
        longitude = Input.location.lastData.longitude;

        yield break;

    }
}
