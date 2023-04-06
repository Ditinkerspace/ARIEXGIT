using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using WearHFPlugin;
using UnityEngine.EventSystems;

public class Saveload : MonoBehaviour
{
    private WearHF m_wearHF;
    public GameObject Saveloadscene;
    public GameObject workidscene;
    public Button Backbutton;
    public Button Readybutton;
    public Button Canvabtn;
    public Button Newbtn;
    public Button Loadbtn;
    public InputField Jobnumber;
    public InputField Serialnumber;
    public GameObject savesuccess;
    public GameObject sendsuccess;
    public GameObject savesuccessaudio;
    Engine5b fivebscript;

    // Start is called before the first frame update
    void Start()
    {
        
        m_wearHF = GameObject.Find("WearHF Manager").GetComponent<WearHF>();//Find the WearHF library

        savesuccess.SetActive(false); // turns off the savesuccess GameObject
        Saveloadscene.SetActive(false);// turns off the Saveloadscene GameObject
        workidscene.SetActive(false);// turns off the workidscene GameObject
        sendsuccess.SetActive(false);//turns off the sendsuccess GameObject
        savesuccessaudio.SetActive(false);//turns off the savesuccessaudio GameObject
        
    }
    
    
     private void Jobnuminput(string voiceCommand)
    {
        EventSystem.current.SetSelectedGameObject(null);
        Jobnumber.Select();
    }
    
    private void Serialnuminput(string voiceCommand)
    {
        EventSystem.current.SetSelectedGameObject(null);
        Serialnumber.Select();
    }
    public void AddSAVEback()
    {
        m_wearHF.AddVoiceCommand("Select Back", Backbtnselected);
    }
    private void Newselected(string voiceCommand)
    {
        Newbtn.onClick.Invoke();
    }
    private void Loadselected(string voiceCommand)
    {

        Loadbtn.onClick.Invoke();

    }
    public void removereadyvc()
    {
        m_wearHF.RemoveVoiceCommand("Select Ready");
    }
   
    
    private void Backbtnselected(string voiceCommand)
    {
        Backbutton.onClick.Invoke();
        m_wearHF.RemoveVoiceCommand("Select Back");
    }

    public void removecommands()
    {
        m_wearHF.RemoveVoiceCommand("Select New");
        m_wearHF.RemoveVoiceCommand("Select Load");
        m_wearHF.RemoveVoiceCommand("Select Back");
        m_wearHF.RemoveVoiceCommand("Select Job");
        m_wearHF.RemoveVoiceCommand("Select Serial");
    }
    public void Newbutton()
    {
        ClearALLCOMMANDSPLEASE();// clears all current VC
        
        m_wearHF.AddVoiceCommand("Select Ready", Readyselected);// adds VC for Readyselected function
        m_wearHF.AddVoiceCommand("Select Back", CanvaBack);// adds VC for CanvaBack function
        m_wearHF.AddVoiceCommand("Select Job", Jobnuminput);// adds VC for Jobnuminput function
        m_wearHF.AddVoiceCommand("Select Serial", Serialnuminput);//adds VC for Serialnuminput
        Saveloadscene.SetActive(false);// turns off the Saveloadscene function
        workidscene.SetActive(true);//turns off the workidscene function
       
    }

    public void Loadbutton()
    {
        ClearALLCOMMANDSPLEASE();// clears all current VC

        m_wearHF.AddVoiceCommand("Select Ready", Readyselected);// adds VC for Readyselected function
        m_wearHF.AddVoiceCommand("Select Back", CanvaBack);// adds VC for CanvaBack function
        m_wearHF.AddVoiceCommand("Select Job", Jobnuminput);// adds VC for Jobnuminput function
        m_wearHF.AddVoiceCommand("Select Serial", Serialnuminput); // adds VC for Serialnuminput function
        Saveloadscene.SetActive(false);// turns off the Saveloadscene function
        workidscene.SetActive(true);//turns off the workidscene function


    }
     private void CanvaBack(string voiceCommand)
    {
        m_wearHF.ClearCommands();
        Invoke("loadVcSavepageVC", 0.5f);
        Canvabtn.onClick.Invoke();
        m_wearHF.ClearCommands();


    }

    public void ClearALLCOMMANDSPLEASE()
    {
        m_wearHF.ClearCommands();
    }
    private void Readyselected(string voiceCommand)
    {
        
        Readybutton.onClick.Invoke();
        
    }
    
    public void removebackcmd()
    {
        m_wearHF.RemoveVoiceCommand("Select Back");
    }

    public void loadVcSavepageVC()
    {

        Invoke("Loadallcmds", 0.5f);
        
    }

    private void Loadallcmds()
    {
        m_wearHF.AddVoiceCommand("Select New", Newselected);//add VC to activate the Newselected function
        m_wearHF.AddVoiceCommand("Select Load", Loadselected);// add VC to activate the loadselected function
        m_wearHF.AddVoiceCommand("Select Back", Backbtnselected);// add VC to activate Backbtnselected function
        m_wearHF.AddVoiceCommand("Select Job", Jobnuminput);// add VC to activate Jobnuminput function
        m_wearHF.AddVoiceCommand("Select Serial", Serialnuminput); //add VC to activate Serialnuminput function
    }
    public void loadreadyVC()
    {
        Invoke("readyvcdelay", 1f);
    }
    private void readyvcdelay()
    {
        m_wearHF.AddVoiceCommand("Select Ready", Readyselected);
        m_wearHF.AddVoiceCommand("Select Back", CanvaBack);
        m_wearHF.AddVoiceCommand("Select Job", Jobnuminput);
        m_wearHF.AddVoiceCommand("Select Serial", Serialnuminput);
    }    
}
