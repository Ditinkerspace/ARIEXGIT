using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WearHFPlugin;


public class sumlistvc : MonoBehaviour
{
    private WearHF m_wearHF;
    public Button sumsavebtn;
    public Button sumsendbtn;
    public Button sumbackbtn;
    public Button scrollup;
    public Button scrolldown;
    public Button remark1;
    public Button remark2;
    public Button remark3;
    public Button remark4;
    public GameObject SummaryList;
    public GameObject Saveloadpage;
    public GameObject sendsuccess;
    public Saveload saveloadscript;

    private void Start()
    {
        m_wearHF = GameObject.Find("WearHF Manager").GetComponent<WearHF>();
        saveloadscript = GameObject.FindGameObjectWithTag("TagA").GetComponent<Saveload>();
        sendsuccess.SetActive(false);
    }
    public void Addcmds()
    {
        m_wearHF.AddVoiceCommand("Select Back", sumbackcmddelay);
        m_wearHF.AddVoiceCommand("Select Save", sumsavecmddelay);
        m_wearHF.AddVoiceCommand("Select Send", sumsendcmddelay);
        m_wearHF.AddVoiceCommand("Select Up", sumscrollupdelay);
        m_wearHF.AddVoiceCommand("Select Down", sumscrolldowndelay);
        m_wearHF.AddVoiceCommand("Select Remark 1", showremark1delay);
        m_wearHF.AddVoiceCommand("Select Remark 2", showremark2delay);
        m_wearHF.AddVoiceCommand("Select Remark 3", showremark3delay);
        m_wearHF.AddVoiceCommand("Select Remark 4", showremark4delay);
    }

    private void sumsendcmddelay(string voiceCommand)
    {
        Invoke("sumsendcmd", 0.5f);
    }
    private void sumbackcmddelay(string voiceCommand)
    {
        Invoke("sumbackcmd", 0.5f);
    }
    private void sumsavecmddelay(string voiceCommand)
    {
        Invoke("sumsavecmd", 0.5f);
    }
    private void sumscrollupdelay(string voiceCOmmand)
    {
        Invoke("sumscrollup", 0.5f);
    }
    private void sumscrolldowndelay(string voiceCOmmand)
    {
        Invoke("sumscrolldown", 0.5f);
    }
    private void showremark1delay(string voiceCOmmand)
    {
        Invoke("showremark1", 0.5f);
    }
    private void showremark2delay(string voiceCOmmand)
    {
        Invoke("showremark2", 0.5f);
    }
    private void showremark3delay(string voiceCOmmand)
    {
        Invoke("showremark3", 0.5f);
    }
    private void showremark4delay(string voiceCOmmand)
    {
        Invoke("showremark4", 0.5f);
    }

    private void sumscrollup()
    {
        scrollup.onClick.Invoke();
    }
    private void sumscrolldown()
    {
        scrolldown.onClick.Invoke();
    }
    private void showremark1()
    {
        remark1.onClick.Invoke();
    }
    private void showremark2()
    {
        remark2.onClick.Invoke();
    }
    private void showremark3()
    {
        remark3.onClick.Invoke();
    }
    private void showremark4()
    {
        remark4.onClick.Invoke();
    }
    private void sumsavecmd()
    {
        m_wearHF.ClearCommands();
        saveloadscript.loadVcSavepageVC();
        sumsavebtn.onClick.Invoke();

        SummaryList.SetActive(false);
        Saveloadpage.SetActive(true);

    }
    private void sumsendcmd()
    {


        sumsendbtn.onClick.Invoke();


    }

    private void sumbackcmd()
    {

        m_wearHF.ClearCommands();
        sumbackbtn.onClick.Invoke();

    }
    public void removeallcmds()
    {
        m_wearHF.ClearCommands();
    }

    public void onsendsuccess()
    {
        sendsuccess.SetActive(true);
        Invoke("offsendsuccess", 3f);
    }
    private void offsendsuccess()
    {
        sendsuccess.SetActive(false);
    }

    
}


