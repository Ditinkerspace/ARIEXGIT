using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SaveText : MonoBehaviour
{
    private TMP_InputField inputname;
    public int savedpartnumber;
    public string damagetogglestatus;
    public string receivetogglestatus;
    public string defectstogglestatus;

    private Toggle damagetoggle;
    private Toggle receivetoggle;
    private Toggle defectstoggle;

    // Start is called before the first frame update
    void Start()
    {
        inputname = GameObject.FindWithTag("RemarksData").GetComponent<TMP_InputField>();
        savedpartnumber = PlayerPrefs.GetInt("SavedPartNumber");
        inputname.text = PlayerPrefs.GetString("Remarks" + savedpartnumber);


        receivetoggle = GameObject.FindWithTag("Receivedtoggle").GetComponent<Toggle>();
        damagetoggle = GameObject.FindWithTag("Damagedtoggle").GetComponent<Toggle>();


        damagetogglestatus = PlayerPrefs.GetString("Damaged" + savedpartnumber);
        receivetogglestatus = PlayerPrefs.GetString("Received" + savedpartnumber);


        if (damagetogglestatus == "YES")
        {
            damagetoggle.isOn = true;
        }

        if (receivetogglestatus == "YES")
        {
            receivetoggle.isOn = true;
        }

        if (defectstogglestatus == "YES")
        {
            defectstoggle.isOn = true;
        }


        PlayerPrefs.SetInt("SavedPartNumber", savedpartnumber + 1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
