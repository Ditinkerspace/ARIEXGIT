using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class savedsuccessfully : MonoBehaviour
{
    public GameObject savesuccess;
    public GameObject savesuccessaudio;
    public GameObject offcfmvoicc;
    // Start is called before the first frame update
    void Start()
    {
        savesuccess.SetActive(false);
        savesuccessaudio.SetActive(false);
        offcfmvoicc.SetActive(true);
    }

   public void onsavesuccess()
    {
        offcfmvoicc.SetActive(false);
        savesuccessaudio.SetActive(true);
        savesuccess.SetActive(true);
        Invoke("offsavesuccess", 3.5f);
    }

    private void offsavesuccess()
    {
        savesuccess.SetActive(false);
        savesuccessaudio.SetActive(false);
    }
}
