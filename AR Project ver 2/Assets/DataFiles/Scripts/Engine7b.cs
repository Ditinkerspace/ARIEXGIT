using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class Engine7b : MonoBehaviour
{
    public GameObject Backtomenu;
    public GameObject ChoseDispatch;
    public GameObject ChoseReceive;
    public GameObject CFM7b;


    // Start is called before the first frame update

    void Start()
    {
        ChoseReceive.SetActive(false);
        ChoseDispatch.SetActive(false);
        CFM7b.SetActive(true);
    }
    public void gobackmenu()
    {
        SceneManager.LoadScene(0);

    }

    public void receivescan()
    {
        ChoseReceive.SetActive(true);
        CFM7b.SetActive(false);
    }

    public void dispatchscan()
    {
        ChoseDispatch.SetActive(true);
        CFM7b.SetActive(false);
    }

    public void BackHome()
    {
        ChoseReceive.SetActive(false);
        ChoseDispatch.SetActive(false);
        CFM7b.SetActive(true);
    }
}
