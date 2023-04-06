using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class rotationvalue : MonoBehaviour
{
    // Start is called before the first frame update

    public Text headingText;
    public string compassvalue;
    private bool startTracking = false;
    public GameObject firstptbtn;
    void Start()
    {
        Input.compass.enabled = true;
        Input.location.Start();
        StartCoroutine(InitializeCompass());
    }

    // Update is called once per frame
    void Update()
    {
        if (startTracking)
        {
            transform.rotation = Quaternion.Euler(0, Input.compass.trueHeading, 0);
            headingText.text = ((int)Input.compass.trueHeading).ToString() + "° " + DegreesToCardinalDetailed(Input.compass.trueHeading);
            compassvalue = DegreesToCardinalDetailed(Input.compass.trueHeading);
            
        }
        if (compassvalue == "ESE")
        {
            firstptbtn.SetActive(true);
        }
        else
        {
            firstptbtn.SetActive(false);
        }
    }

    IEnumerator InitializeCompass()
    {
        yield return new WaitForSeconds(1f);
        startTracking |= Input.compass.enabled;
    }

    private static string DegreesToCardinalDetailed(double degrees)
    {
        string[] caridnals = { "N", "NNE", "NE", "ENE", "E", "ESE", "SE", "SSE", "S", "SSW", "SW", "WSW", "W", "WNW", "NW", "NNW", "N" };
        return caridnals[(int)Math.Round(((double)degrees * 10 % 3600) / 225)];
    }
}

