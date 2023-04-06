using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class WarningScript : MonoBehaviour
{
    public TextMeshProUGUI warningtext; 
    public TextMeshProUGUI donetext;
    public int count;
    public GameObject warningPage; // warning page (red)
    public GameObject donePage; // done page (green)
    public GameObject mainCanvas; // review page 11


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        count = PlayerPrefs.GetInt("Counter");
    }

    public void checkCount()
    {
        if (count != 22)
        {
            warningPage.SetActive(true);
            mainCanvas.SetActive(false);
            warningtext.text = "WARNING YOU HAVE ONLY COMPLETED " + count + "/22 AREAS!";
        }
        else
        {
            if (PlayerPrefs.GetString("Mode") == "Receive")
            {
                donePage.SetActive(true);
                mainCanvas.SetActive(false); // note: we need to add one more gameobject for review page 12
                // donetext.text = "YOU HAVE ALREADY COMPLETED " + count + "/22 AREAS!";
                // SceneManager.LoadScene(3); // if user is scanning received
            }
            else
            {
                donePage.SetActive(true);
                SceneManager.LoadScene(5); // if user is scanning dispatched
            }
        }
    }

}
