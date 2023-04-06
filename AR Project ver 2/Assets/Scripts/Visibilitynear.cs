using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Visibilitynear : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Target1;
    public GameObject Target2;
    public GameObject Target3;
    public GameObject Target4;
    public GameObject ABVtext;
    

    void Start()
    {
        Target1.SetActive(false);
        Target2.SetActive(false);
        Target3.SetActive(false);
        Target4.SetActive(false);
        ABVtext.SetActive(false); 
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            Target1.SetActive(true);
            Target2.SetActive(true);
        }
        else if (other.tag == "player1")
        {
            Target3.SetActive(true);
            Target4.SetActive(true);
        }
        else if (other.tag == "ABV")
        {
            ABVtext.SetActive(true);
        }
        else if (other.tag == "LP")
        {

        }
        else if (other.tag == "PD")
        {

        }
        else if (other.tag == "OTC")
        {

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if ((other.tag == "player") ||(other.tag == "player1") || (other.tag == "ABV"))
        {
            Target1.SetActive(false);
            Target2.SetActive(false);
            Target3.SetActive(false);
            Target4.SetActive(false);
            ABVtext.SetActive(false);
        }

    }
}
