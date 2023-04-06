using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using WearHFPlugin;
using UnityEngine.EventSystems;
using Newtonsoft.Json.Bson;
public class Orientation : MonoBehaviour
{
    PreviewAndSave previewandsave;


    private WearHF m_wearHF;
    public GameObject GTBTarget;
    public GameObject GTBlist;
    public GameObject GTBOrientation;
    public GameObject TBOrientation;
    public GameObject TubeBlankTarget;
    public GameObject TubeBlankList;
    public GameObject HPTCCVTarget;
    public GameObject HPTCCVList;
    public GameObject HPTCCVOrientation;
    public GameObject TankCapTarget;
    public GameObject TankCapList;
    public GameObject TankCapOrientation;
    public GameObject B1FlangeTarget;
    public GameObject B1FlangeList;
    public GameObject B1FlangeOrientation;
    public GameObject TAIADTarget;
    public GameObject TAIADList;
    public GameObject TAIADOrientation;
    public GameObject ALTERNATORTarget;
    public GameObject ALTERNATORList;
    public GameObject ALTERNATOROrientation;
    public GameObject OTBTarget;
    public GameObject OTBList;
    public GameObject OTBOrientation;

    public Button GTBYesBtn;
    public Button GTBNoBtn;
    public Button GTBBackbutton;
    public Button TBYesBtn;
    public Button TBNoBtn;
    public Button TBBackbutton;
    public Button HPTCCVYesBtn;
    public Button HPTCCVNoBtn;
    public Button HPTCCVBackbutton;
    public Button TCYesBtn;
    public Button TCNoBtn;
    public Button TCBackbutton;
    public Button B1YesBtn;
    public Button B1NoBtn;
    public Button B1Backbutton;
    public Button TAIADYesBtn;
    public Button TAIADNoBtn;
    public Button TAIADBackbutton;
    public Button ALTYesBtn;
    public Button ALTNoBtn;
    public Button ALTBackbutton;
    public Button OTBYesBtn;
    public Button OTBNoBtn;
    public Button OTBBackbutton;

    public Button checksave;
    public Button checkback;
    public InputField remarkinputfield;


    CaptureAndSave snapShot;



    private void Start()
    {
        snapShot = GameObject.FindObjectOfType<CaptureAndSave>();


    }






    public void GOTOGTBORIENTATION()
    {
        

        GTBlist.SetActive(false);
        GTBOrientation.SetActive(true);
        GTBTarget.SetActive(false);

        GTBaddorientationcmd();

    }

    public void GOBACKGTBTARGET()
    {
        GTBOrientation.SetActive(false);
        GTBTarget.SetActive(true);
        GTBlist.SetActive(false);

        removeorientationcmd();


    }

    public void GOTOGTBLIST()

    {
     
        GTBTarget.SetActive(false);// turns off the scanning page
        GTBOrientation.SetActive(false);// turns off the GTB orientation page
        GTBlist.SetActive(true);// turns on the GTB list
        
        m_wearHF.ClearCommands();// clears all existing VC 

        Invoke("addchecklistbtns", 1f);// adds the VC for checklists with a delay
    }

    public void GOBACKGTBORIENTATION()
    {
        GTBlist.SetActive(false);

        GTBTarget.SetActive(false);
        GTBOrientation.SetActive(true);

        GTBaddorientationcmd();
    }

    public void GOTOTBORIENTATION()
    {
        TubeBlankList.SetActive(false);
        TBOrientation.SetActive(true);
        TubeBlankTarget.SetActive(false);
        TBaddorientationcmd();
    }


    public void GOBACKTUBEBLANKTARGET()
    {
        TBOrientation.SetActive(false);
        TubeBlankTarget.SetActive(true);
        TubeBlankList.SetActive(false);

        removeorientationcmd();
    }

    public void GOTOTBLIST()
    {
        
        TubeBlankTarget.SetActive(false);
        TBOrientation.SetActive(false);
        TubeBlankList.SetActive(true);
        
        m_wearHF.ClearCommands();

        Invoke("addchecklistbtns", 1f);
    }
  

    public void GOBACKTBORIENTATION()
    {
        TubeBlankList.SetActive(false);
        TubeBlankTarget.SetActive(false);
        TBOrientation.SetActive(true);
        TBaddorientationcmd();
    }

    public void GOTOHPTCCVORIENTATION()
    {
        HPTCCVList.SetActive(false);
        HPTCCVOrientation.SetActive(true);
        HPTCCVTarget.SetActive(false);
        HPTCCVaddorientationcmd();
    }
    

    public void GOBACKHPTCCVTARGET()
    {
        HPTCCVOrientation.SetActive(false);
        HPTCCVTarget.SetActive(true);
        HPTCCVList.SetActive(false);

        removeorientationcmd();
    }

    public void GOTOHPTCCVLIST()
    {
        
        HPTCCVTarget.SetActive(false);
        HPTCCVOrientation.SetActive(false);
        HPTCCVList.SetActive(true);
        
        m_wearHF.ClearCommands();

        Invoke("addchecklistbtns", 1f);

    }

    public void GOBACKHPTCCVORIENTATION()
    {
        HPTCCVList.SetActive(false);
        HPTCCVTarget.SetActive(false);
        HPTCCVOrientation.SetActive(true);
        HPTCCVaddorientationcmd();
    }
    
   
    
    public void GOTOTANKCAPORIENTATION()
    {
        TankCapList.SetActive(false);
        TankCapOrientation.SetActive(true);
        TankCapTarget.SetActive(false);
        TCaddorientationcmd();
    }

    public void GOBACKTANKCAPTARGET()
    {
        TankCapOrientation.SetActive(false);
        TankCapTarget.SetActive(true);
        TankCapList.SetActive(false);

        removeorientationcmd();
    }

    public void GOTOTANKCAPLIST()
    {
        m_wearHF.ClearCommands();
        TankCapTarget.SetActive(false);
        TankCapOrientation.SetActive(false);
        TankCapList.SetActive(true);
       
        

        Invoke("addchecklistbtns", 1f);
    }

    public void GOBACKTANKCAPORIENTATION()
    {
        TankCapList.SetActive(false);
        TankCapTarget.SetActive(false);
        TankCapOrientation.SetActive(true);
        TCaddorientationcmd();

    }
    
    
   
    public void GOTOB1FlangeORIENTATION()
    {
        B1FlangeList.SetActive(false);
        B1FlangeOrientation.SetActive(true);
        B1FlangeTarget.SetActive(false);
        B1addorientationcmd();
    }

    public void GOTOB1FlangeLIST()
    {
        
        B1FlangeTarget.SetActive(false);
        B1FlangeOrientation.SetActive(false);
        B1FlangeList.SetActive(true);
        
        m_wearHF.ClearCommands();

        Invoke("addchecklistbtns", 1f);
    }

    public void GOBACKB1FlangeTARGET()
    {
        B1FlangeOrientation.SetActive(false);
        B1FlangeTarget.SetActive(true);
        B1FlangeList.SetActive(false);

        removeorientationcmd();
    }
    public void GOBACKB1FlangeORIENTATION()
    {
        B1FlangeList.SetActive(false);
        B1FlangeTarget.SetActive(false);
        B1FlangeOrientation.SetActive(true);
        B1addorientationcmd();

    }
    
    public void GOTOTAIADORIENTATION()
    {
        
        TAIADOrientation.SetActive(true);
        TAIADTarget.SetActive(false);
        TAIADaddorientationcmd();

    }

    public void GOTOTAIADLIST()
    {
        
        TAIADTarget.SetActive(false);
        TAIADOrientation.SetActive(false);
        TAIADList.SetActive(true);
        
        m_wearHF.ClearCommands();

        Invoke("addchecklistbtns", 1f);
    }

    public void GOBACKTAIADTARGET()
    {
        TAIADOrientation.SetActive(false);
        TAIADTarget.SetActive(true);
        TAIADList.SetActive(false);

        removeorientationcmd();
    }
    public void GOBACKTAIADORIENTATION()
    {
        TAIADList.SetActive(false);
        TAIADTarget.SetActive(false);
        TAIADOrientation.SetActive(true);
        TAIADaddorientationcmd();
    }

    
    
    

    public void GOTOALTERNATORORIENTATION()
    {
        ALTERNATORList.SetActive(false);
        ALTERNATOROrientation.SetActive(true);
        ALTERNATORTarget.SetActive(false);
        ALTaddorientationcmd();


    }

    public void GOTOALTERNATORLIST()
    {
        
        ALTERNATORTarget.SetActive(false);
        ALTERNATOROrientation.SetActive(false);
        ALTERNATORList.SetActive(true);
        
        m_wearHF.ClearCommands();

        Invoke("addchecklistbtns", 1f);
    }

    public void GOBACKALTERNATORTARGET()
    {
        ALTERNATOROrientation.SetActive(false);
        ALTERNATORTarget.SetActive(true);
        ALTERNATORList.SetActive(false);

        removeorientationcmd();
    }
    public void GOBACKALTERNATORORIENTATION()
    {
        ALTERNATORList.SetActive(false);
        ALTERNATORTarget.SetActive(false);
        ALTERNATOROrientation.SetActive(true);
        ALTaddorientationcmd();
    }

    

    public void GOTOOTBORIENTATION()
    {
        OTBList.SetActive(false);
        OTBOrientation.SetActive(true);
        OTBTarget.SetActive(false);
        OTBaddorientationcmd();

    }

    public void GOTOOTBLIST()
    {
        
        OTBTarget.SetActive(false);
        OTBOrientation.SetActive(false);
        OTBList.SetActive(true);
        Invoke("removeorientationcmd", 1f);
        m_wearHF.ClearCommands();

        Invoke("addchecklistbtns", 1f);
    }

    public void GOBACKOTBRTARGET()
    {
        OTBOrientation.SetActive(false);
        OTBTarget.SetActive(true);
        OTBList.SetActive(false);
        removeorientationcmd();
    }
    public void GOBACKOTBRORIENTATION()
    {
        OTBList.SetActive(false);
        OTBTarget.SetActive(false);
        OTBOrientation.SetActive(true);

        OTBaddorientationcmd();

    }

   
    public void GTBaddorientationcmd()
    {
        m_wearHF.AddVoiceCommand("Select Yes", GTByesbtnselected);
        m_wearHF.AddVoiceCommand("Select No", GTBnobtnselected);
        m_wearHF.AddVoiceCommand("Select Back", GTBbackbuttonselected);

    }

    public void TBaddorientationcmd()
    {
        m_wearHF.AddVoiceCommand("Select Yes", TByesbtnselected);
        m_wearHF.AddVoiceCommand("Select No", TBnobtnselected);
        m_wearHF.AddVoiceCommand("Select Back", TBbackbuttonselected);
    }

    public void HPTCCVaddorientationcmd()
    {
        m_wearHF.AddVoiceCommand("Select Yes", HPTCCVyesbtnselected);
        m_wearHF.AddVoiceCommand("Select No", HPTCCVnobtnselected);
        m_wearHF.AddVoiceCommand("Select Back", HPTCCVbackbuttonselected);
    }

    public void TCaddorientationcmd()
    {
        m_wearHF.AddVoiceCommand("Select Yes", TCyesbtnselected);
        m_wearHF.AddVoiceCommand("Select No", TCnobtnselected);
        m_wearHF.AddVoiceCommand("Select Back", TCbackbuttonselected);
    }

    public void B1addorientationcmd()
    {
        m_wearHF.AddVoiceCommand("Select Yes", B1yesbtnselected);
        m_wearHF.AddVoiceCommand("Select No", B1nobtnselected);
        m_wearHF.AddVoiceCommand("Select Back", B1backbuttonselected);
    }

    public void TAIADaddorientationcmd()
    {
        m_wearHF.AddVoiceCommand("Select Yes", TAIADyesbtnselected);
        m_wearHF.AddVoiceCommand("Select No", TAIADnobtnselected);
        m_wearHF.AddVoiceCommand("Select Back", TAIADbackbuttonselected);
    }

    public void ALTaddorientationcmd()
    {
        m_wearHF.AddVoiceCommand("Select Yes", ALTyesbtnselected);
        m_wearHF.AddVoiceCommand("Select No", ALTnobtnselected);
        m_wearHF.AddVoiceCommand("Select Back", ALTbackbuttonselected);
    }

    public void OTBaddorientationcmd()
    {
        m_wearHF.AddVoiceCommand("Select Yes", OTByesbtnselected);
        m_wearHF.AddVoiceCommand("Select No", OTBnobtnselected);
        m_wearHF.AddVoiceCommand("Select Back", OTBbackbuttonselected);
    }
    private void removeorientationcmd()
    {
        m_wearHF.RemoveVoiceCommand("Select Yes");
        m_wearHF.RemoveVoiceCommand("Select No");
        m_wearHF.RemoveVoiceCommand("Select Back");
    }
    private void GTByesbtnselected(string voiceCommand)
    {
        GTBYesBtn.onClick.Invoke();
    }

    private void GTBnobtnselected(string voiceCommand)
    {
        GTBNoBtn.onClick.Invoke();
    }

    private void GTBbackbuttonselected(string VoiceCommand)
    {
        GTBBackbutton.onClick.Invoke();
    }

    private void TByesbtnselected(string voiceCommand)
    {
        TBYesBtn.onClick.Invoke();
    }

    private void TBnobtnselected(string voiceCommand)
    {
        TBNoBtn.onClick.Invoke();
    }

    private void TBbackbuttonselected(string VoiceCommand)
    {
        TBBackbutton.onClick.Invoke();
    }
    ///
    private void HPTCCVyesbtnselected(string voiceCommand)
    {
        HPTCCVYesBtn.onClick.Invoke();
    }

    private void HPTCCVnobtnselected(string voiceCommand)
    {
        HPTCCVNoBtn.onClick.Invoke();
    }

    private void HPTCCVbackbuttonselected(string VoiceCommand)
    {
        HPTCCVBackbutton.onClick.Invoke();
    }
    ///
    private void TCyesbtnselected(string voiceCommand)
    {
        TCYesBtn.onClick.Invoke();
    }

    private void TCnobtnselected(string voiceCommand)
    {
        TCNoBtn.onClick.Invoke();
    }

    private void TCbackbuttonselected(string VoiceCommand)
    {
        TCBackbutton.onClick.Invoke();
    }
    ///
    private void B1yesbtnselected(string voiceCommand)
    {
        B1YesBtn.onClick.Invoke();
    }

    private void B1nobtnselected(string voiceCommand)
    {
        B1NoBtn.onClick.Invoke();
    }

    private void B1backbuttonselected(string VoiceCommand)
    {
        B1Backbutton.onClick.Invoke();
    }
    ///
    private void TAIADyesbtnselected(string voiceCommand)
    {
        TAIADYesBtn.onClick.Invoke();
    }

    private void TAIADnobtnselected(string voiceCommand)
    {
        TAIADNoBtn.onClick.Invoke();
    }

    private void TAIADbackbuttonselected(string VoiceCommand)
    {
        TAIADBackbutton.onClick.Invoke();
    }
    ///

    private void ALTyesbtnselected(string voiceCommand)
    {
        ALTYesBtn.onClick.Invoke();
    }

    private void ALTnobtnselected(string voiceCommand)
    {
        ALTNoBtn.onClick.Invoke();
    }

    private void ALTbackbuttonselected(string VoiceCommand)
    {
        ALTBackbutton.onClick.Invoke();
    }
    ///
    private void OTByesbtnselected(string voiceCommand)
    {
        OTBYesBtn.onClick.Invoke();
    }

    private void OTBnobtnselected(string voiceCommand)
    {
        OTBNoBtn.onClick.Invoke();
    }

    private void OTBbackbuttonselected(string VoiceCommand)
    {
        OTBBackbutton.onClick.Invoke();
    }

    private void addchecklistbtns()
    {
        m_wearHF.AddVoiceCommand("Select Save", savebtnselected);
        m_wearHF.AddVoiceCommand("Select Back", backbtncheckselect);
        m_wearHF.AddVoiceCommand("Select Remark", remarksinput);
    }

    private void savebtnselected(string voiceCommand)
    {

        checksave.onClick.Invoke();
    }

    private void backbtncheckselect(string voiceCommand)
    {
        m_wearHF.ClearCommands();
        checkback.onClick.Invoke();
    }

    private void remarksinput(string voiceCommand)
    {
        EventSystem.current.SetSelectedGameObject(null);
        remarkinputfield.Select();
    }
    public void delayGTB()
    {
        
        Invoke("removeorientationcmd",0.5f);
        Invoke("GOTOGTBLIST", 1f);
        
        m_wearHF.ClearCommands();
        Invoke("addchecklistbtns", 0.5f);


    }

    public void delayTB()
    {

        Invoke("removeorientationcmd", 0.5f);
        Invoke("GOTOTBLIST", 1f);

        m_wearHF.ClearCommands();
        Invoke("addchecklistbtns", 0.5f);


    }

    public void delayHPTCCV()
    {

        Invoke("removeorientationcmd", 0.5f);
        Invoke("GOTOHPTCCVLIST", 1f);

        m_wearHF.ClearCommands();
        Invoke("addchecklistbtns", 0.5f);


    }

    public void delayTC()
    {

        Invoke("removeorientationcmd", 0.5f);
        Invoke("GOTOTANKCAPLIST", 1f);

        m_wearHF.ClearCommands();
        Invoke("addchecklistbtns", 0.5f);


    }

    public void delayOTB()
    {

        Invoke("removeorientationcmd", 0.5f);
        Invoke("GOTOOTBLIST", 1f);

        m_wearHF.ClearCommands();
        Invoke("addchecklistbtns", 0.5f);


    }

    public void delayTAIAD()
    {

        Invoke("removeorientationcmd", 0.5f);
        Invoke("GOTOTAIADLIST", 1f);

        m_wearHF.ClearCommands();
        Invoke("addchecklistbtns", 0.5f);


    }

    public void delayB1()
    {

        Invoke("removeorientationcmd", 0.5f);
        Invoke("GOTOB1FlangeLIST", 1);

        m_wearHF.ClearCommands();
        Invoke("addchecklistbtns", 1f);


    }

    public void delayALT()
    {

        Invoke("removeorientationcmd", 0.5f);
        Invoke("GOTOALTLIST", 1f);

        m_wearHF.ClearCommands();
        Invoke("addchecklistbtns", 0.5f);


    }

   


}

