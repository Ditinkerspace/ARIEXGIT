using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Area1 : MonoBehaviour
{
    public GameObject A1P1;
    public GameObject A1P2;
    public GameObject A1P4;

    private int currentPage = 1;

    void Start()
    {
        A1P1.SetActive(true);
        A1P2.SetActive(false);
       
        A1P4.SetActive(false);
    }

    public void SetPage()
    {
        A1P1.SetActive(false);
        A1P2.SetActive(false);
       
        A1P4.SetActive(false);

        if (currentPage == 1)
        {
            A1P1.SetActive(true);
        }else if (currentPage == 2)
        {
            A1P2.SetActive(true);
        }else if (currentPage == 3)
        {
            A1P4.SetActive(true);
        }
    }

    public void NextPage()
    {
        currentPage += 1;
    }

    public void PreviousPage()
    {
        currentPage -= 1;
    }

    public void ExitToScan()
    {
        SceneManager.LoadScene(1);
    }


}
