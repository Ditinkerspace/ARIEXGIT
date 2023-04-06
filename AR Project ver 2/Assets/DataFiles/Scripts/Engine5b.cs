using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using WearHFPlugin;
using UnityEngine.EventSystems;
using Newtonsoft.Json.Bson;

public class Engine5b : MonoBehaviour
{
    
    private WearHF m_wearHF;
    public InputField userJobNum;
    public InputField userSerialNum;
    public InputField inputInteger;
    public InputField inputInteger1;
    public GameObject warningTextIDEmpty;
    public GameObject warningInvalidID;
    public GameObject warningInvalid8digit;

    public string user_JobNum;
    public string user_SerialNum;
    public string user_JobNum_integer;
    public string user_SerialNum_integer;
    private int error = 0;
    public int colour = 0;
    private int Summary = 0;
    private int Joblistsc = 0;
    public GameObject Backtomenu;
    public GameObject ChoseDispatch;
    public GameObject ChoseRec;
    public GameObject CFM5b;
    public GameObject GTBlist;
    public GameObject BacktoRec;
    
    public GameObject GTBRemark;
    public GameObject Invalid;
    public SpriteRenderer Border;
    public Button ConfirmBtn;
    public GameObject PartName;
    public GameObject JobNumber;
    public GameObject SerialNumber;
    public string JobNum;
    public string SerialNum;
    public GameObject JobnSerialFilterlist;
    
    public string GTBRemarks;
    public GameObject Inspectbtn;
    public GameObject Dingsound;
    public GameObject Nameaudio;
    
    public GameObject TubeBlankRemark;
    
    public string TubeBlankRemarks;
    public GameObject TubeBlanklist;
    
    public GameObject HPTCCVRemark;
    
    public string HPTCCVRemarks;
    public GameObject HPTCCVlist;
   
    public GameObject TankCapRemark;
   
    public string TankCapRemarks;
    public GameObject TankCaplist;

    public GameObject B1FlangeRemark;

    public string B1FlangeRemarks;
    public GameObject B1Flangelist;

    public GameObject TAIADRemark;

    public string TAIADRemarks;
    public GameObject TAIADlist;

    public GameObject ALTRemark;

    public string ALTRemarks;
    public GameObject ALTlist;

    public GameObject OTBRemark;

    public string OTBRemarks;
    public GameObject OTBlist;


    public Button YesButton;
    public Button NoButton;
    public Button BackButton;

    public int superSize = 2;
    private int _shotIndex = 0;
    public Text JobNo;
    public Text SerialNo;
    public GameObject SSCamera;
    public GameObject SummaryList;
  
    public Text sumTBRemark;
    public Text sumGTBRemark;
    public Text sumHPTCCVRemark;
    public Text sumTcRemark;
    public Text sumB1FlangeRemark;
    public Text sumTAIADRemark;
    public Text sumALTRemark;
    public Text sumOTBRemark;

    public GameObject SummaryBTN;
    public GameObject BackBTN;
    public GameObject Display_JobNo;
    public GameObject Display_SerialNo;
    public GameObject Display_JobNo1;
    public GameObject Display_SerialNo1;
    public GameObject Display_BorderRed;
    public GameObject Display_nameRed;
    public GameObject Display_BorderGreen;
    public GameObject Display_nameGreen;
    public GameObject Display_BorderRed1;
    public GameObject Display_nameRed1;
    public GameObject Display_BorderGreen1;
    public GameObject Display_nameGreen1;
    public GameObject Display_BorderRed2;
    public GameObject Display_nameRed2;
    public GameObject Display_BorderGreen2;
    public GameObject Display_nameGreen2;
    public GameObject Saveloadpage;
    
    public GameObject Saveloadscript;
    public GameObject Loadpreviousscript;
    public GameObject Remarkinput;
   
    public string Remarksinput;
    public InputField Remarksinputfield;
   
    
    public GameObject sumRemarks;
    
    public GameObject Remarktitle;

    
    public Button Inspectpage;
    public Button Readytbn;
    public Saveload saveloadscript;
    
    public Button Backbtn;
    public GameObject Recbackscript;
    public Button Yesbtn;

    public Button checksave;
    public Button checkback;

    public InputField remarkinputfield;
    public Button instructnextbtn;
    public Button instructbackbtn;
    public Button instructhomebtn;
    public sumlistvc sumlistvcscript;
    public GameObject fillupbothaudio;
    public GameObject invalid6digitaudio;
    public GameObject invalid8digitaudio;
    public GameObject enterjobnserialaudio;
    public GameObject invalidvoicesum;
    public GameObject Blockimage;

    public GameObject GTBOrientation;

    public GameObject TBOrientation;

    public GameObject HPTCCVOrientation;

    public GameObject TCOrientation;

    public GameObject B1FlangeOrientation;

    public GameObject TAIADOrientation;

    public GameObject ALTOrientation;

    public GameObject OTBOrientation;

    
    void Start()
    {        
        m_wearHF = GameObject.Find("WearHF Manager").GetComponent<WearHF>();//Find the WearHF library



        saveloadscript = GameObject.FindGameObjectWithTag("TagA").GetComponent<Saveload>();
        sumlistvcscript = GameObject.FindGameObjectWithTag("Tagsum").GetComponent<sumlistvc>();
        ChoseDispatch.SetActive(false);//turns off the ChoseDispatch GameObject
        CFM5b.SetActive(false);// turns off the CFM5b GameObject
        GTBlist.SetActive(false);// turns off the GTBlist GameObject
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        Inspectbtn.SetActive(false);// turns off the Inspectbtn GameObject
        Dingsound.SetActive(false);// turns off the Dingsound GameObject
        HPTCCVlist.SetActive(false);// turns off the HPTCCVlist GameObject
        TubeBlanklist.SetActive(false);// turns off the TubeBlanklist GameObject
        ChoseRec.SetActive(false);// turns off the ChoseRec GameObject 
        TankCaplist.SetActive(false);// turns off the TankCaplist GameObject
        B1Flangelist.SetActive(false);//turns off the B1Flangelist GameObject
        TAIADlist.SetActive(false);//turns off the TAIADlist GameObject
        ALTlist.SetActive(false);//turns off the ALTlist GameObject 
        OTBlist.SetActive(false);//turns off the OTBlist GameObject
        Invalid.SetActive(false);//turns off the Invalid GameObject
        SummaryList.SetActive(false);//turns off the Summary GameObject
        Saveloadpage.SetActive(true);//turns off the Saveloadpage GameObject


    }
    public void offallinvalid()
    {
        warningInvalidID.SetActive(false);
        warningTextIDEmpty.SetActive(false);
        fillupbothaudio.SetActive(false);
        invalid6digitaudio.SetActive(false); 
        Invalid.SetActive(false);
        invalidvoicesum.SetActive(false);
        warningInvalid8digit.SetActive(false);
        invalid8digitaudio.SetActive(false);
    }
    public void enterjobnserial()
    {
        enterjobnserialaudio.SetActive(true);
        Invoke("offjobnserial", 3f);
    }

    public void offjobnserial()
    {
        enterjobnserialaudio.SetActive(false);
    }
    
    public void Inspectpg(string voiceCommand)
    {

        Inspectpage.onClick.Invoke();
    }

    private void instructback(string voiceCommand)
    {
        m_wearHF.ClearCommands();
        instructbackbtn.onClick.Invoke();
    }

    private void instructhome(string voiceCommand)
    {
        m_wearHF.ClearCommands();
        instructhomebtn.onClick.Invoke();
    }

    private void instructnext(string voiceCommand)
    {
        m_wearHF.ClearCommands();
        instructnextbtn.onClick.Invoke();
    }


    public void CheckParticulars()
    {

        user_JobNum = userJobNum.text;
        user_SerialNum = userSerialNum.text;

        string input1 = user_JobNum;
        string input2 = user_SerialNum;


        warningTextIDEmpty.SetActive(false);
        warningInvalidID.SetActive(false);
        invalid6digitaudio.SetActive(false);
        fillupbothaudio.SetActive(false);
        warningInvalid8digit.SetActive(false);
        invalid8digitaudio.SetActive(false);

        if (string.IsNullOrEmpty(input1) && string.IsNullOrEmpty(input2)) // if user did not input both 
        {

            warningTextIDEmpty.SetActive(true);
            error = 1;
            fillupbothaudio.SetActive(true);
        }

        else if (string.IsNullOrEmpty(input1))
        {
            warningTextIDEmpty.SetActive(true);
            error = 1;
            fillupbothaudio.SetActive(true);
        }

        else if (string.IsNullOrEmpty(input2)) // if user only input user name
        {
            warningTextIDEmpty.SetActive(true);
            error = 1;
            fillupbothaudio.SetActive(true);
        }

        else
        {
            warningTextIDEmpty.SetActive(false);
            int.TryParse(input2, out int result); // try
            int.TryParse(input1, out int result1);
            if ((result > 99999 && result < 1000000) && (result1 > 9999999 && result1 < 100000000))
            {

                error = 0;
                
            }
            else if (( result < 100000) && (result1 > 9999999 && result1 < 100000000))
            {

                warningInvalidID.SetActive(true);
                error = 1;
                invalid6digitaudio.SetActive(true);
            }

            else if ((result > 99999 && result < 1000000) && (result1 < 10000000))
            {
                warningInvalid8digit.SetActive(true);
                error = 1;
                invalid8digitaudio.SetActive(true);
            }
        }
    }
     public void Showrecords()
    {
        if (Summary == 0)
        {
            Summary += 1;
           
            sumRemarks.SetActive(true);
          
            Remarktitle.SetActive(true);
        }

        else if (Summary == 1)
        {
            Summary = 0;
           
            sumRemarks.SetActive(false);
           
            Remarktitle.SetActive(false);
        }
    }

    
    public void CertifiedID()
    {
        if (error == 0)
        {
            enterjobnserialaudio.SetActive(false);//Turns off enterjobnserialaudio GameObject
            warningInvalidID.SetActive(false);//Turns off warningInvalidID GameObject
            warningTextIDEmpty.SetActive(false);//Turns off warningTEXTIDEmpty GameObject
            warningInvalid8digit.SetActive(false);//Turns off warningInvalid8digit GameObject
            invalid8digitaudio.SetActive(false); //Turns off invalid8digitaudio GameObject
            invalid6digitaudio.SetActive(false);//Turns off invalid8digitaudio GameObject
            fillupbothaudio.SetActive(false);//Turn off "Fill Up Both" audio
            ChoseRec.SetActive(true);// Turn on receive scan
            CFM5b.SetActive(false);//Turn off 5B
            HPTCCVlist.SetActive(false);// Turn off HPTCCV checklist
            TubeBlanklist.SetActive(false);// Turn off TubeBlank checklist
            TankCaplist.SetActive(false);// Turn off Tank Cap checklist
            GTBlist.SetActive(false);// Turn off GTB checklist
            B1Flangelist.SetActive(false);// Turn off B1Flange checklist
            TAIADlist.SetActive(false);// Turn off Tai Air Duct checklist
            ALTlist.SetActive(false);// Turn off Alternator checklist
            OTBlist.SetActive(false);// Turn off Oil Tube Blank checklist
            JobNo.text = user_JobNum;
            SerialNo.text = user_SerialNum;
            Joblistsc = 0;
            
            
            saveloadscript.removereadyvc();
            saveloadscript.ClearALLCOMMANDSPLEASE();
            
            m_wearHF.AddVoiceCommand("Select Summary", summaryselected);// add VC for the summary select function
            m_wearHF.AddVoiceCommand("Select Back", Backbtnselected);// add VC for the back button select function
            Recbackscript.SetActive(true);// turn on the right back script
        }
    }

    public void addsumcmd()
    {
        m_wearHF.AddVoiceCommand("Select Summary", summaryselected);
        m_wearHF.AddVoiceCommand("Select Back", Backbtnselected);
    }

    public void recbackscriptturnon()
    {
        Recbackscript.SetActive(true);
    }

    public void recbackscriptturnoff()
    {
        Recbackscript.SetActive(false);
    }
    
    private void Backbtnselected(string voiceCommand)
    {
        m_wearHF.ClearCommands();
        BackHome();
    }
    public void RemovebackVC()
    {
        m_wearHF.RemoveVoiceCommand("Select Back");
    }

   
    
    private void summaryselected(string voiceCommand)
    {
        OnSumlist();
        sumlistvcscript.Addcmds();
    }

    private void Readybtnselected(string voiceCommand)
    {
        Readytbn.onClick.Invoke();
    }
    public void ClearTextsTankCap()
    {
        
        Remarksinputfield.text = TankCapRemarks;
    }
    public void ClearTextsHPTCCV()
    {
        
        Remarksinputfield.text = HPTCCVRemarks;
    }
    public void ClearTextsTubeBlank()
    {
        
        Remarksinputfield.text = TubeBlankRemarks;
    }
    public void ClearTextsGTB()
    {
        
        Remarksinputfield.text = GTBRemarks;
    }

    public void ClearTextsB1Flange()
    {
        Remarksinputfield.text = B1FlangeRemarks;
    }

    public void ClearTextsTAIAD()
    {
        Remarksinputfield.text = TAIADRemarks;
    }

    public void ClearTextsALT()
    {
        Remarksinputfield.text = ALTRemarks;
    }

    public void ClearTextsOTB()
    {
        Remarksinputfield.text = OTBRemarks;
    }
    public void OnSumlist()
    {
        m_wearHF.ClearCommands();
        SummaryList.SetActive(true);
        ChoseRec.SetActive(false);
        

    }
    
    

    public void sumsavebtnclicked()
    {
        SummaryList.SetActive(false);
        Saveloadpage.SetActive(true);
    }

    
    
    public void backfrmsum()
    {
        addsumcmd();
        SummaryList.SetActive(false);
        ChoseRec.SetActive(true);
       
    }


    public void ReceiveScan()
    {
        Invoke("Activatescan", 0.5f);
        m_wearHF.AddVoiceCommand("Select Summary", summaryselected);

    }
    private void Activatescan()
    {
        ChoseRec.SetActive(true);
        CFM5b.SetActive(false);
        HPTCCVlist.SetActive(false);
        TubeBlanklist.SetActive(false);
        GTBlist.SetActive(false);
        TankCaplist.SetActive(false);
        B1Flangelist.SetActive(false);
        TAIADlist.SetActive(false);
        ALTlist.SetActive(false);
        OTBlist.SetActive(false);
        Screen.orientation = ScreenOrientation.AutoRotation;
        Dingsound.SetActive(false);
        SummaryList.SetActive(false);
        SummaryBTN.SetActive(true);
        BackBTN.SetActive(true);
    }
    public void BackHome()
    {
        saveloadscript.loadreadyVC();
        ChoseRec.SetActive(false);
        CFM5b.SetActive(true);
        
        Loadpreviousscript.SetActive(true);
        
    }

    public void Backtosaveload()
    {
        
        Saveloadpage.SetActive(true);
        CFM5b.SetActive(false);
        
    }

    public void RemoveBtns()
    {
        
        SummaryBTN.SetActive(false);// Turn off Summary Button
        BackBTN.SetActive(false);// Turn off Back Button
        Display_JobNo.SetActive(false);// Turn off Job Number Display
        Display_SerialNo.SetActive(false);// Turn off Serial Number Display
        Display_JobNo1.SetActive(false);// Turn off Job Number Display
        Display_JobNo1.SetActive(false);// Turn off Job Number Display
        Display_SerialNo1.SetActive(false);// Turn off Serial Number Display
        Display_BorderRed.SetActive(false);// Turn off Red Boarder
        Display_nameRed.SetActive(false);// Turn off Red Display Name
        Display_BorderGreen.SetActive(false);// Turn off Green Boarder
        Display_nameGreen.SetActive(false);// Turn off Green Display Name
    }


    public void DetectedObject()
    {
        
        Dingsound.SetActive(true);// turns on the Dingsound GameObject
        Nameaudio.SetActive(true);// turns on the Nameaudiio GameObject
        SSCamera.SetActive(true);// turns on SSCamera GameObject
        Inspectbtn.SetActive(true);// turns on Inspectbtn GameObject
        Remarksinput = Remarkinput.GetComponent<Text>().text;// convert the text in Remarksinput into a variable
        m_wearHF.AddVoiceCommand("Select Inspect", Inspectpg);// add VC for inspect to activate the Inspectpg function
    }
    

    public void checkcolour()
    {

        if (colour == 0)

        {

            ChangeColourRed();// changes part name and border colour to red
        }
        else if (colour == 1)
        {
            ChangeColourGreen();// changes part name and border colour to green

        }
    }
    public void Offdingsound()
    {
        Dingsound.SetActive(false);// Turn off "Ding" sound effect
        Nameaudio.SetActive(false);// Turn off part name audio
        Display_JobNo.SetActive(true);// Turn on Job Number display
        Display_SerialNo.SetActive(true);// Turn on Serial Number display
        Display_JobNo1.SetActive(true);// Turn on Job Number display
        Display_SerialNo1.SetActive(true);// Turn on Serial Number display
        SummaryBTN.SetActive(true);// Turn on Summary button
        BackBTN.SetActive(true);// Turn on Back Button
        m_wearHF.RemoveVoiceCommand("Select Inspect");// Remove "Select Inspect" VC 
        

    }

    private void OFFAR()
    {
        ChoseRec.SetActive(false);
    }
    private void OnbackAR()
    {
        ChoseRec.SetActive(true);
    }
    public void OffCamera()
    {
        SSCamera.SetActive(false);
    }
    private void addchecklistbtns()
    {
        m_wearHF.AddVoiceCommand("Select Save", savebtnselected);
        m_wearHF.AddVoiceCommand("Select Back", backbtncheckselect);
        m_wearHF.AddVoiceCommand("Select Remark", remarksinput);
    }

    private void remarksinput(string voiceCommand)
    {
        EventSystem.current.SetSelectedGameObject(null);
        remarkinputfield.Select();
    }
    public void GOTOGTBLIST()

    {
        GTBOrientation.SetActive(false);
        GTBlist.SetActive(true);

        m_wearHF.ClearCommands();

        Invoke("addchecklistbtns", 0.5f);
    }


    public void GOTOTBLIST()
    {

        
        TBOrientation.SetActive(false);
        TubeBlanklist.SetActive(true);

        m_wearHF.ClearCommands();

        Invoke("addchecklistbtns", 1f);
    }

    public void GOTOHPTCCVLIST()
    {

        
        HPTCCVOrientation.SetActive(false);
        HPTCCVlist.SetActive(true);

        m_wearHF.ClearCommands();

        Invoke("addchecklistbtns", 1f);

    }
    public void GOTOTANKCAPLIST()
    {
        m_wearHF.ClearCommands();
        
        TCOrientation.SetActive(false);
        TankCaplist.SetActive(true);



        Invoke("addchecklistbtns", 1f);
    }

    public void GOTOB1FlangeLIST()
    {

        
        B1FlangeOrientation.SetActive(false);
        B1Flangelist.SetActive(true);

        m_wearHF.ClearCommands();

        Invoke("addchecklistbtns", 1f);
    }

    public void GOTOTAIADLIST()
    {

        
        TAIADOrientation.SetActive(false);
        TAIADlist.SetActive(true);

        m_wearHF.ClearCommands();

        Invoke("addchecklistbtns", 1f);
    }


    public void GOTOALTERNATORLIST()
    {

        
        ALTOrientation.SetActive(false);
        ALTlist.SetActive(true);

        m_wearHF.ClearCommands();

        Invoke("addchecklistbtns", 1f);
    }

    public void GOTOOTBLIST()
    {

        
        OTBOrientation.SetActive(false);
        OTBlist.SetActive(true);
        
        m_wearHF.ClearCommands();

        Invoke("addchecklistbtns", 1f);
    }

    public void delayGTBOrientation()
    {
        Invoke("ToGTBOrientation", 0.5f);// turns on the GTB Orientation 
        Inspectbtn.SetActive(false);//turns off the Inspect Button

        Invoke("OffCamera", 1.5f);// turns off the camera
        Invoke("RemoveRec", 0.5f);// turns off the scanning page
        m_wearHF.ClearCommands();// clears all existing VC
        Invoke("addorientationcmd", 1f);// adds in the VC for the orientation page
    }

    public void delayTubeBlankOrientation()
    {
        Invoke("ToTubeBlankOrientation", 0.5f);
        Inspectbtn.SetActive(false);

        Invoke("OffCamera", 1.5f);
        Invoke("RemoveRec", 0.5f);
        m_wearHF.ClearCommands();
        Invoke("addorientationcmd", 1f);
    }

    public void delayTankCapOrientation()
    {
        Invoke("ToTankCapOrientation", 0.5f);
        Inspectbtn.SetActive(false);

        Invoke("OffCamera", 1.5f);
        Invoke("RemoveRec", 0.5f);
        m_wearHF.ClearCommands();

        Invoke("addorientationcmd", 1f);
    }

    public void delayHPTCCVOrientation()
    {
        Invoke("ToHPCTTVOrientation", 0.5f);
        Inspectbtn.SetActive(false);

        Invoke("OffCamera", 1.5f);
        Invoke("RemoveRec", 0.5f);
        m_wearHF.ClearCommands();
        Invoke("addorientationcmd", 1f);
    }

    public void delayB1FlangeOrientation()
    {
        Invoke("ToB1FlangeOrientation", 0.5f);
        Inspectbtn.SetActive(false);

        Invoke("OffCamera", 1.5f);
        Invoke("RemoveRec", 0.5f);
        m_wearHF.ClearCommands();

        Invoke("addorientationcmd", 1f);
    }

    public void delayTAIADOrientation()
    {
        Invoke("ToTAIADOrientation", 0.5f);
        Inspectbtn.SetActive(false);

        Invoke("OffCamera", 1.5f);
        Invoke("RemoveRec", 0.5f);
        m_wearHF.ClearCommands();

        Invoke("addorientationcmd", 1f);
    }

    public void delayALTOrientation()
    {
        Invoke("ToAlternatorOrientation", 0.5f);
        Inspectbtn.SetActive(false);

        Invoke("OffCamera", 1.5f);
        Invoke("RemoveRec", 0.5f);
        m_wearHF.ClearCommands();

        Invoke("addorientationcmd", 1f);
    }

    public void delayOTBOrientation()
    {
        Invoke("ToOTBOrientation", 0.5f);
        Inspectbtn.SetActive(false);

        Invoke("OffCamera", 1.5f);
        Invoke("RemoveRec", 0.5f);
        m_wearHF.ClearCommands();

        Invoke("addorientationcmd", 1f);
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
    void RemoveRec()
    {
        ChoseRec.SetActive(false);
    }
    public void ToGTBList()
    {
        
        GTBlist.SetActive(true);
        GTBOrientation.SetActive(false);
        ChoseRec.SetActive(false);
        Invalid.SetActive(false);
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        

    }
    public void ToGTBOrientation()
    {
        GTBOrientation.SetActive(true);
        ChoseRec.SetActive(false);
        Invalid.SetActive(false);
        Screen.orientation = ScreenOrientation.LandscapeLeft;

    }

    



    public void ToB1FlangeOrientation()
    {
        B1FlangeOrientation.SetActive(true);
        ChoseRec.SetActive(false);
        Invalid.SetActive(false);
        Screen.orientation = ScreenOrientation.LandscapeLeft;

    }

    public void ToTAIADOrientation()
    {
        TAIADOrientation.SetActive(true);
        ChoseRec.SetActive(false);
        Invalid.SetActive(false);
        Screen.orientation = ScreenOrientation.LandscapeLeft;

    }


    public void ToTubeBlankList()
    {
        
        TubeBlanklist.SetActive(true);
        TBOrientation.SetActive(false);
        ChoseRec.SetActive(false);
        Invalid.SetActive(false);
        Inspectbtn.SetActive(false);
        
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    private void SaveTB(string voiceCommand)
    {
        ConfirmBtn.onClick.Invoke();
    }

    private void SaveGTB(string voiceCommand)
    {
        ConfirmBtn.onClick.Invoke();
    }

    private void SaveTC(string voiceCommand)
    {
        ConfirmBtn.onClick.Invoke();
    }

    private void SaveHPTCCV(string voiceCommand)
    {
        ConfirmBtn.onClick.Invoke();
    }

    private void SaveB1Flange(string voiceCommand)
    {
        ConfirmBtn.onClick.Invoke();
    }

    private void SaveTAIAD(string voiceCommand)
    {
        ConfirmBtn.onClick.Invoke();
    }

    private void SaveALT(string voiceCommand)
    {
        ConfirmBtn.onClick.Invoke();
    }

    private void SaveOTB(string voiceCommand)
    {
        ConfirmBtn.onClick.Invoke();
    }

    public void ToHPTCCVList()
    {
        HPTCCVlist.SetActive(true);
        HPTCCVOrientation.SetActive(false);
        ChoseRec.SetActive(false);
        Invalid.SetActive(false);
        Inspectbtn.SetActive(false);
        
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
    public void ToTankCapList()
    {
        TankCaplist.SetActive(true);
        TCOrientation.SetActive(false);
        ChoseRec.SetActive(false);
        Invalid.SetActive(false);
        Inspectbtn.SetActive(false);
        
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    public void ToB1FlangeList()
    {
        B1Flangelist.SetActive(true);
        B1FlangeOrientation.SetActive(false);
        ChoseRec.SetActive(false);
        Invalid.SetActive(false);
        Inspectbtn.SetActive(false);

        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }


    public void ToAlternatorList()
    {
        ALTlist.SetActive(true);
        ALTOrientation.SetActive(false);
        ChoseRec.SetActive(false);
        Invalid.SetActive(false);
        Inspectbtn.SetActive(false);

        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    public void ToOTBList()
    {
        OTBlist.SetActive(true);
        OTBOrientation.SetActive(false);
        ChoseRec.SetActive(false);
        Invalid.SetActive(false);
        Inspectbtn.SetActive(false);

        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    public void ToTAIADList()
    {
        TAIADlist.SetActive(true);
        TAIADOrientation.SetActive(false);
        ChoseRec.SetActive(false);
        Invalid.SetActive(false);
        Inspectbtn.SetActive(false);

        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
    public void GTBCFMBtn()
    {
        invalidvoicesum.SetActive(false);//turns off the invlaidvoicesum audio
        GTBRemarks = GTBRemark.GetComponent<Text>().text;// 
        if  (GTBRemarks == "") // when the remarks inputfield is empty

        {
            Invalid.SetActive(true);//turns on the invalid text 
            invalidvoicesum.SetActive(true);//turns on the invalidvoice sum audio
            colour = 0;//colour counter change to 0

        }
        else
        {
            m_wearHF.ClearCommands();//clears all existing VC 
            GTBlist.SetActive(false);// turns off the GTB list
            Invalid.SetActive(false);//turns of the invalid text
            ChoseRec.SetActive(true);// turns on the scanning page
            Blockimage.SetActive(false);//turns off the block image
            sumGTBRemark.text = GTBRemarks;//converts the sumGTBRemark text into a variable
           
            colour = 1; //colour counter change from 0 to 1
             
        }
        
    }
    public void TubeBlankCFMBtn()
    {
        invalidvoicesum.SetActive(false);
        TubeBlankRemarks = TubeBlankRemark.GetComponent<Text>().text;
        if  (TubeBlankRemarks == "")

        {
            Invalid.SetActive(true);
            invalidvoicesum.SetActive(true);
            ChangeColourRed();
            colour = 0;
        }
        else
        {
            m_wearHF.ClearCommands();
            Invalid.SetActive(false);
            ChoseRec.SetActive(true);
            TubeBlanklist.SetActive(false);
            Blockimage.SetActive(false);
            sumTBRemark.text = TubeBlankRemarks;
            ChangeColourGreen();
            colour = 1;
             
        }
    }

    public void HPTCCVCFMBtn()
    {
        invalidvoicesum.SetActive(false);
        HPTCCVRemarks = HPTCCVRemark.GetComponent<Text>().text;
        if(HPTCCVRemarks == "")

        {
            Invalid.SetActive(true);
            invalidvoicesum.SetActive(true);
            ChangeColourRed();
            colour = 0;
        }
        else
        {
            m_wearHF.ClearCommands();
            Invalid.SetActive(false);
            ChoseRec.SetActive(true);
            HPTCCVlist.SetActive(false);
            Blockimage.SetActive(false);
            sumHPTCCVRemark.text = HPTCCVRemarks;
            ChangeColourGreen();
            colour = 1;
             
        }
    }
    public void TankCapCFMBtn()
    {
        invalidvoicesum.SetActive(false);
        TankCapRemarks = TankCapRemark.GetComponent<Text>().text;
        if (TankCapRemarks == "")

        {
            Invalid.SetActive(true);
            invalidvoicesum.SetActive(true);
            sumTcRemark.text = "";
            colour = 0;

        }
        else
        {
            m_wearHF.ClearCommands();
            Invalid.SetActive(false);
            ChoseRec.SetActive(true);
            TankCaplist.SetActive(false);
            Blockimage.SetActive(false);
            sumTcRemark.text = TankCapRemarks;
            colour = 1;
             
        }

    }


    public void B1FlangeCFMBtn()
    {
        invalidvoicesum.SetActive(false);
        B1FlangeRemarks = B1FlangeRemark.GetComponent<Text>().text;
        if (B1FlangeRemarks == "")

        {
            Invalid.SetActive(true);
            invalidvoicesum.SetActive(true);
            sumB1FlangeRemark.text = "";
            colour = 0;

        }
        else
        {
            m_wearHF.ClearCommands();
            Invalid.SetActive(false);
            ChoseRec.SetActive(true);
            B1Flangelist.SetActive(false);
            Blockimage.SetActive(false);
            sumB1FlangeRemark.text = B1FlangeRemarks;
            colour = 1;

        }

    }

    public void TAIADCFMBtn()
    {
        invalidvoicesum.SetActive(false);
        TAIADRemarks = TAIADRemark.GetComponent<Text>().text;
        if (TAIADRemarks == "")

        {
            Invalid.SetActive(true);
            invalidvoicesum.SetActive(true);
            sumTAIADRemark.text = "";
            colour = 0;

        }
        else
        {
            m_wearHF.ClearCommands();
            Invalid.SetActive(false);
            ChoseRec.SetActive(true);
            TAIADlist.SetActive(false);
            Blockimage.SetActive(false);
            sumTAIADRemark.text = TAIADRemarks;
            colour = 1;

        }

    }

    public void ALTCFMBtn()
    {
        invalidvoicesum.SetActive(false);
        ALTRemarks = ALTRemark.GetComponent<Text>().text;
        if (ALTRemarks == "")

        {
            Invalid.SetActive(true);
            invalidvoicesum.SetActive(true);
            sumALTRemark.text = "";
            colour = 0;

        }
        else
        {
            m_wearHF.ClearCommands();
            Invalid.SetActive(false);
            ChoseRec.SetActive(true);
            ALTlist.SetActive(false);
            Blockimage.SetActive(false);
            sumALTRemark.text = ALTRemarks;
            colour = 1;

        }

    }

    public void OTBCFMBtn()
    {
        invalidvoicesum.SetActive(false);
        OTBRemarks = OTBRemark.GetComponent<Text>().text;
        if (OTBRemarks == "")

        {
            Invalid.SetActive(true);
            invalidvoicesum.SetActive(true);
            colour = 0;

        }
        else
        {
            m_wearHF.ClearCommands();
            OTBlist.SetActive(false);
            Invalid.SetActive(false);
            ChoseRec.SetActive(true);
            Blockimage.SetActive(false);
            sumOTBRemark.text = OTBRemarks;
            colour = 1;

        }

    }


    public void greencolour()
    {
        colour = 1;
    }

    public void redcolour()
    {
        colour = 0;
    }
    public void ChangeColourGreen()
    {
        Display_BorderRed.SetActive(false);//turns off red border
        Display_nameRed.SetActive(false);//turns off red part name
        Display_BorderGreen.SetActive(true);//turns on green part border
        Display_nameGreen.SetActive(true);//turns on green part name

    }

    public void ChangeColourRed()
    {
        Display_BorderRed.SetActive(true);// turns on red border
        Display_nameRed.SetActive(true);// turns on red part name
        Display_BorderGreen.SetActive(false);//turns off green part border
        Display_nameGreen.SetActive(false);//turns off green part name
    }

    private void yesbtnselected(string voiceCommand)
    {
        YesButton.onClick.Invoke();
        
    }

    private void nobtnselected(string voiceCommand)
    {
        NoButton.onClick.Invoke();
    }

    private void backbuttonselected(string voiceCommand)
    {
        m_wearHF.ClearCommands();
        BackButton.onClick.Invoke();
    }
    public void addorientationcmd()
    {
        m_wearHF.AddVoiceCommand("Select Yes", yesbtnselected);
        m_wearHF.AddVoiceCommand("Select No", nobtnselected);
        m_wearHF.AddVoiceCommand("Select Back", backbuttonselected);

    }

    public void removeorientationcmd()
    {

        m_wearHF.RemoveVoiceCommand("Select Yes");
        m_wearHF.RemoveVoiceCommand("Select No");
        m_wearHF.RemoveVoiceCommand("Select Back");
    }
}






