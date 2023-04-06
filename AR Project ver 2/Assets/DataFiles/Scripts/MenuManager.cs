using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class MenuManager : MonoBehaviour
{
    private int areanumber;
    public TMP_Text counter;
    public int count;
    public int mode;
    public GameObject warningPage;
    public GameObject donePage;
    public TextMeshProUGUI warningtext;
    public TextMeshProUGUI donetext;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void Start()
    {
        count = PlayerPrefs.GetInt("Counter");
        if (PlayerPrefs.GetString("Mode") == "Receive")
        {
            mode = 2; // receive check
        }else
        {
            mode = 4; // dispatch check
        }
    }

    public void Update()
    {
        counter.text = "Area Completed:" + count + "/22";
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(2);
    }

    public void Area1()
    {
        areanumber = 1;
        PlayerPrefs.SetInt("AreaNumber", areanumber);
        PlayerPrefs.SetInt("PageNumber", 1);
        SceneManager.LoadScene(mode);
    }
    public void Area2()
    {
        areanumber = 2;
        PlayerPrefs.SetInt("AreaNumber", areanumber);
        SceneManager.LoadScene(mode);
    }
    public void Area3()
    {
        areanumber = 3;
        PlayerPrefs.SetInt("AreaNumber", areanumber);
        SceneManager.LoadScene(mode);
    }
    public void Area4()
    {
        areanumber = 4;
        PlayerPrefs.SetInt("AreaNumber", areanumber);
        SceneManager.LoadScene(mode);
    }
    public void Area5()
    {
        areanumber = 5;
        PlayerPrefs.SetInt("AreaNumber", areanumber);
        SceneManager.LoadScene(mode);
    }

    public void Area6()
    {
        areanumber = 6;
        PlayerPrefs.SetInt("AreaNumber", areanumber);
        SceneManager.LoadScene(mode);
    }

    public void Area7()
    {
        areanumber = 7;
        PlayerPrefs.SetInt("AreaNumber", areanumber);
        SceneManager.LoadScene(mode);
    }

    public void Area8()
    {
        areanumber = 8;
        PlayerPrefs.SetInt("AreaNumber", areanumber);
        SceneManager.LoadScene(mode);
    }

    public void Area9()
    {
        areanumber = 9;
        PlayerPrefs.SetInt("AreaNumber", areanumber);
        SceneManager.LoadScene(mode);
    }

    public void Area10()
    {
        areanumber = 10;
        PlayerPrefs.SetInt("AreaNumber", areanumber);
        SceneManager.LoadScene(mode);
    }

    public void Area11()
    {
        areanumber = 11;
        PlayerPrefs.SetInt("AreaNumber", areanumber);
        SceneManager.LoadScene(mode);
    }

    public void Area12()
    {
        areanumber = 12;
        PlayerPrefs.SetInt("AreaNumber", areanumber);
        SceneManager.LoadScene(mode);
    }

    public void Area13()
    {
        areanumber = 13;
        PlayerPrefs.SetInt("AreaNumber", areanumber);
        SceneManager.LoadScene(mode);
    }

    public void Area14()
    {
        areanumber = 14;
        PlayerPrefs.SetInt("AreaNumber", areanumber);
        SceneManager.LoadScene(mode);
    }

    public void Area15()
    {
        areanumber = 15;
        PlayerPrefs.SetInt("AreaNumber", areanumber);
        SceneManager.LoadScene(mode);
    }

    public void Area16()
    {
        areanumber = 16;
        PlayerPrefs.SetInt("AreaNumber", areanumber);
        SceneManager.LoadScene(mode);
    }

    public void Area17()
    {
        areanumber = 17;
        PlayerPrefs.SetInt("AreaNumber", areanumber);
        SceneManager.LoadScene(mode);
    }

    public void Area18()
    {
        areanumber = 18;
        PlayerPrefs.SetInt("AreaNumber", areanumber);
        SceneManager.LoadScene(mode);
    }

    public void Area19()
    {
        areanumber = 19;
        PlayerPrefs.SetInt("AreaNumber", areanumber);
        SceneManager.LoadScene(mode);
    }

    public void Area20()
    {
        areanumber = 20;
        PlayerPrefs.SetInt("AreaNumber", areanumber);
        SceneManager.LoadScene(mode);
    }

    public void Area21()
    {
        areanumber = 21;
        PlayerPrefs.SetInt("AreaNumber", areanumber);
        SceneManager.LoadScene(mode);
    }

    public void Area22()
    {
        areanumber = 22;
        PlayerPrefs.SetInt("AreaNumber", areanumber);
        SceneManager.LoadScene(mode);
    }

    public void backtoscan()
    {
        if (PlayerPrefs.GetInt("reviewmode") == 1)
        {
            SceneManager.LoadScene(3); // back to review user input scene
        }else
        {
            SceneManager.LoadScene(1); //back to scanning page
        }
    }

    public void ToReviewPage()
    {
        SceneManager.LoadScene(3);
        if (PlayerPrefs.GetString("Mode") == "Receive")
        {
            SceneManager.LoadScene(3);
        }
        else
        {
            SceneManager.LoadScene(5);
        }
     
    }

    public void ToLogin()
    {
        SceneManager.LoadScene(0);
    }

    public void missingPageBackButton() // transition from missing page --> warning page / done page (depends on the number of area that user scan)
    {
        if (count != 22)
        {
            SceneManager.LoadScene(1); // do not need to consider whether user is doing receive or dispatch
            warningPage.SetActive(true);
            warningtext.text = "WARNING YOU HAVE ONLY COMPLETED " + count + "/22 AREAS!";
            
        }
        else
        {
            SceneManager.LoadScene(1); 
            donePage.SetActive(true);
            donetext.text = "YOU HAVE ALREADY COMPLETED " + count + "/22 AREAS!";

        }
    }
}



