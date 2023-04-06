using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    string filename = "";
    // Start is called before the first frame update
    void Start()
    {
        filename = Application.dataPath + "/testing3.csv";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void testing()
    {
        TextWriter tw = new StreamWriter(filename, true);
        tw.WriteLine("Part Name, Received, Damaged, Remarks");


        //tw = new StreamWriter(filename, true);

        for (int i = 0; i < 50; i++)
        {
            tw.WriteLine("hello" + "," + i + "," + "damaged" + "," + "received");
        }
        tw.Close();
    }
}
