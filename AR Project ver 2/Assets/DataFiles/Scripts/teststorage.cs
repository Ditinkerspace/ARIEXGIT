using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class teststorage : MonoBehaviour
{
    public static int PartNumber;

    public List<string> RemarksList;

    private TMP_InputField inputremarks;

    public string remarksText;

    public int listsize;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
  
    }

    public void storeInput()
    {
        inputremarks = GameObject.FindWithTag("RemarksData").GetComponent<TMP_InputField>();
        remarksText = inputremarks.text;
        Debug.Log(remarksText);
        RemarksList.Add(remarksText);
        Debug.Log(RemarksList[0]);
        listsize = RemarksList.Count;
        for (int i = 0; i < listsize; i++)
        {
            PlayerPrefs.SetString("Remarks" + i, RemarksList[i]);
        }
        PlayerPrefs.SetInt("ListSize", listsize);
    }

    public void PartNo1()
    {
        PartNumber = 0;
    }

    public void PartNo2()
    {
        PartNumber = 1;
    }

    public void PartNo3()
    {
        PartNumber = 2;
    }

    public void PartNo4()
    {
        PartNumber = 3;
    }

    public void PartNo5()
    {
        PartNumber = 4;
    }

    public void PartNo6()
    {
        PartNumber = 5;
    }

    public void PartNo7()
    {
        PartNumber = 6;
    }

    public void PartNo8()
    {
        PartNumber = 7;
    }

    public void PartNo9()
    {
        PartNumber = 8;
    }

    public void PartNo10()
    {
        PartNumber = 9;
    }

    public void PartNo11()
    {
        PartNumber = 10;
    }

    public void PartNo12()
    {
        PartNumber = 11;
    }

    public void PartNo13()
    {
        PartNumber = 12;
    }

    public void PartNo14()
    {
        PartNumber = 13;
    }

    public void PartNo15()
    {
        PartNumber = 14;
    }

    public void PartNo16()
    {
        PartNumber = 15;
    }

    public void PartNo17()
    {
        PartNumber = 16;
    }

    public void PartNo18()
    {
        PartNumber = 17;
    }

    public void PartNo19()
    {
        PartNumber = 18;
    }

    public void PartNo20()
    {
        PartNumber = 19;
    }

    public void PartNo21()
    {
        PartNumber = 20;
    }

    public void PartNo22()
    {
        PartNumber = 21;
    }

}
