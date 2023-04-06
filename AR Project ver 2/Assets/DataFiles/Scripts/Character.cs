using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WearHFPlugin;

public class Character : MonoBehaviour
{
    private WearHF m_wearHF;
    public string GTBremark;
    public string HPTCCVremark;
    public string Tubeblankremark;
    public string Tankcapremark;
    public string B1Flangeremark;
    public string TAIADremark;
    public string ALTremark;
    public string OTBremark;
    public string Serialnumber;
    public string Jobnumber;
    public Text sumTBRemark;
    public Text sumGTBRemark;
    public Text sumHPTCCVRemark;
    public Text sumTcRemark;
    public Text sumB1Remark;
    public Text sumTAIADRemark;
    public Text sumALTRemark;
    public Text sumOTBRemark;
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
    public GameObject Display_BorderRed3;
    public GameObject Display_nameRed3;
    public GameObject Display_BorderGreen3;
    public GameObject Display_nameGreen3;
    /// 
    public GameObject DisplayTAI_BorderRed;
    public GameObject DisplayTAI_nameRed;
    public GameObject DisplayTAI_BorderGreen;
    public GameObject DisplayTAI_nameGreen;
    public GameObject DisplayB1_BorderRed;
    public GameObject DisplayB1_nameRed;
    public GameObject DisplayB1_BorderGreen;
    public GameObject DisplayB1_nameGreen;
    public GameObject DisplayALTERNATOR_BorderRed;
    public GameObject DisplayALTERNATOR_nameRed;
    public GameObject DisplayALTERNATOR_BorderGreen;
    public GameObject DisplayALTERNATOR_nameGreen;
    public GameObject DisplayOTB_BorderRed;
    public GameObject DisplayOTB_nameRed;
    public GameObject DisplayOTB_BorderGreen;
    public GameObject DisplayOTB_nameGreen;
    public GameObject savesuccess;
    public GameObject savesuccessaudio;
    public GameObject CFM56audio;
    public GameObject Loadsucessaudio;

    public int GTBcolor = 0; //set to inactive
    public int TBcolor = 0;  //set to inactive
    public int TCcolor = 0; //set to inactive
    public int HPTCCVcolor = 0;//set to inactive
    public int B1Flangecolor = 0;//set to inactive
    public int TAIADcolor = 0;//set to inactive
    public int ALTcolor = 0;//set to inactive
    public int OTBcolor = 0; //set to inactive
    public int GTBremarksno = 0;//set to inactive
    public int TBremarksno = 0;//set to inactive
    public int TCremarksno = 0;//set to inactive
    public int HPTCCVremarksno = 0;//set to inactive
    public int B1Flangeremarksno = 0;//set to inactive
    public int TAIADremarksno = 0;//set to inactive
    public int ALTremarksno = 0;//set to inactive
    public int OTBremarksno = 0;//set to inactive
    public GameObject Blockimage1;
    public GameObject Blockimage2;
    public GameObject Blockimage3;
    public GameObject Blockimage4;
    [SerializeField]
    private InputField _GTBremark;

    [SerializeField]
    private InputField _HPTCCVremark;

    [SerializeField]
    private InputField _Tubeblankremark;

    [SerializeField]
    private InputField _Tankcapremark;

    [SerializeField]
    private InputField _B1Flangeremark;

    [SerializeField]
    private InputField _TAIADremark;

    [SerializeField]
    private InputField _Serialnumber;

    [SerializeField]
    private InputField _ALTremark;


    [SerializeField]
    private InputField _OTBremark;

    [SerializeField]
    private InputField _Jobnumber;

    private void Start()
    {
        m_wearHF = GameObject.Find("WearHF Manager").GetComponent<WearHF>(); // Enable the RealWear Device
        savesuccess.SetActive(false); // turns off the save success text
        savesuccessaudio.SetActive(false); // turns off the save success audio
    }
    public void Load()
    {
        CharacterData data = SaveLoad.LoadData(); // loads the data after being saved

        GTBremark = data.GTBremark;// obtain the GTB remarks which was saved previously
        HPTCCVremark = data.HPTCCVremark; // obtain the HPTCCV remarks which was saved previously
        Tubeblankremark = data.Tubeblankremark; // obtain the Tube Blank remarks which was was saved previously
        Tankcapremark = data.Tankcapremark; // obtain the Tank Cap remarks which was saved previously
        B1Flangeremark = data.B1Flangeremark1;// obtain the B1 Flange remarks which was saved previously
        TAIADremark = data.TAIADremark1; // obtain the TAI Air Duct remarks which was saved previously
        ALTremark = data.ALTremark1;// obtain the Alternator remarks which was saved previously
        OTBremark = data.OTBremark1; // obtain the Oil Tube Blank remarks which was saved previously
        Serialnumber = data.Serialnumber; // obtain the serial number that was keyed in previously
        Jobnumber = data.Jobnumber; // obtain the Job number that was keyed in previously

        _GTBremark.text = GTBremark; // makes the remarks of the GTB remain after loading 
        _HPTCCVremark.text = HPTCCVremark; // makes the remarks of the HPTCCV remain after loading 
        _Tubeblankremark.text = Tubeblankremark; // makes the remarks of the Tube Blank remain after loading 
        _Tankcapremark.text = Tankcapremark; // makes the remarks of the Tank Cap remain after loading 
        _B1Flangeremark.text = B1Flangeremark; // makes the remarks of the B1 Flange remain after loading 
        _TAIADremark.text = TAIADremark; // makes the remarks of the TAI Air Duct remain after loading 
        _ALTremark.text = ALTremark; // makes the remarks of the Alternator remain after loading 
        _OTBremark.text = OTBremark; // makes the remarks of the Oil Tube Blank remain after loading 
        _Serialnumber.text = Serialnumber; // makes the serial number remain after loading 
        _Jobnumber.text = Jobnumber; // makes the Job Number remain after loading 
        Loadsucessaudio.SetActive(true); //turns on the load success audio
        Invoke("offloadaudio", 6f); // turns off the load success audio with a delay  
    }

    public void offloadaudio()
    {
        Loadsucessaudio.SetActive(false); // turns off the load success audio 
    }
    
    public void cfm56audioturnon()
    {
        CFM56audio.SetActive(true);// turns on the CFM56 audio
    }

    public void changeGTBcolor()
    {
        if (GTBremark == "") // if the GTB remarks section is empty ,  
        {
            GTBcolor = 0;// colour of border become red
            Blockimage2.SetActive(false);//turns off Blockimage2 GameObject
        }
        else
        {
            GTBcolor = 1; // else if its filled in , colour of border becomes green
        }
    }

    public void changeTBcolor()
    {
        if (Tubeblankremark == "") // if the Tube Blank remarks section is empty ,  colour of border become red
        {
            TBcolor = 0;
            Display_nameRed2.SetActive(false);
        }
        else
        {
            TBcolor = 1; // else if its filled in , colour of border becomes green
        }
    }
    public void changeTCcolor()
    {
        if (Tankcapremark == "") // if the Tank Cap remarks section is empty ,  colour of border become red
        {
            TCcolor = 0;
            Blockimage4.SetActive(false);
        }
        else
        {
            TCcolor = 1; // else if its filled in , colour of border becomes green
        }
    }

    public void changeB1Flangecolor()
    {
        if (B1Flangeremark == "") // if the B1 Flange remarks section is empty ,  colour of border become red
        {
            B1Flangecolor = 0;
            Blockimage4.SetActive(false);
        }
        else
        {
            B1Flangecolor = 1; //else if its filled in , colour of border becomes green
        }
    }


    public void changeHPTCCVcolor()
    {
        if (HPTCCVremark == "") // if the HPTCCV remarks section is empty , colour of border becomes red
        {
            HPTCCVcolor = 0;
            Blockimage3.SetActive(false);
        }
        else
        {
            HPTCCVcolor = 1; // else if its filled in , colour of border becomes green
        }
    }

    public void changeTAIADcolor()
    {
        if (TAIADremark == "") // if the TAI Air Duct remarks section is empty , colour of border becomes red
        {
            TAIADcolor = 0;
            Blockimage3.SetActive(false);
        }
        else
        {
            TAIADcolor = 1; // else if its filled in , colour of border becomes green
        }
    }

    public void changeALTcolor()
    {
        if (ALTremark == "") // if the Alternator remarks section is empty , colour of border becomes red
        {
            ALTcolor = 0;
            Blockimage3.SetActive(false);
        }
        else
        {
            ALTcolor = 1; // else if its filled in , colour of border becomes green
        }
    }


    public void changeOTBcolor()
    {
        if (OTBremark == "") // if the Oil Tube Blank remarks section is empty , colour of border becomes red
        {
            ALTcolor = 0;
            Blockimage3.SetActive(false);// turns off block image 3
        }
        else
        {
            OTBcolor = 1; // else if its filled in , colour of border becomes green
        }
    }

    public void checkloadGTBcolour()
    {
        if (GTBcolor == 0)// counter change to 0
        {
            Display_BorderGreen.SetActive(false); //  turns off green border
            Display_nameGreen.SetActive(false);// turns off the green part name
            Display_BorderRed.SetActive(true);// turns on red border
            Display_nameRed.SetActive(true);// turns on red part name
            
        }
        else if (GTBcolor == 1)// counter change to 1
        {
            Display_BorderGreen.SetActive(true);// turns on green border of GTB
            Display_nameGreen.SetActive(true); // turns on green part name of GTB
            Display_BorderRed.SetActive(false); // turns on red border of GTB
            Display_nameRed.SetActive(false);// turns on red part name of GTB
            
        }


    }

    public void checkloadTBcolour()
    {
        if (TBcolor == 0)
        {
            Display_BorderGreen1.SetActive(false); // turns off green border of Tube Blank
            Display_nameGreen1.SetActive(false);// turns off green part name of Tube Blank
            Display_BorderRed1.SetActive(true);// turns on the red border of Tube Blank
            Display_nameRed1.SetActive(true);// turns on the red part name of Tube Blank
            
        }
        else if (TBcolor == 1)
        {
            Display_BorderGreen1.SetActive(true); // turns on green border of Tube Blank
            Display_nameGreen1.SetActive(true); // turns on green part name of Tube Blank
            Display_BorderRed1.SetActive(false); // turns off the red border of Tube Blank
            Display_nameRed1.SetActive(false);// turns off the red part name of Tube Blank
            Blockimage1.SetActive(false);// turns off Block Image 1
        }


    }

    public void checkloadTCcolour()
    {
        if (TCcolor == 0)
        {
            Display_BorderGreen1.SetActive(false); // turns off green border of Tank Cap
            Display_nameGreen1.SetActive(false); // turns off green part name of Tank Cap
            Display_BorderRed1.SetActive(true); // turns on the red border of Tank Cap
            Display_nameRed1.SetActive(true); // turns on the red part name of Tank Cap
            

        }
        else if (TCcolor == 1)
        {
            Display_BorderGreen1.SetActive(true);// turns on the green border of Tank Cap
            Display_nameGreen1.SetActive(true); // turns on the green part name of Tank Cap
            Display_BorderRed1.SetActive(false); // turns off the red border of Tank Cap
            Display_nameRed1.SetActive(false);// turns off the red part name of Tank Cap


        }


    }
    public void checkloadHPTCCVcolour()
    {
        if (HPTCCVcolor == 0)
        {
            Display_BorderGreen3.SetActive(false);// turns off the green border of HPTCCV
            Display_nameGreen3.SetActive(false);// turns off the green part name of HPTCCV
            Display_BorderRed3.SetActive(true);// turns on the red border of HPTCCV
            Display_nameRed3.SetActive(true);// turns on the red part name of HPTCCV
            
        }
        else if (HPTCCVcolor == 1)
        {
            Display_BorderGreen3.SetActive(true); // turns on the green border of HPTCCV
            Display_nameGreen3.SetActive(true); // turns on the green part name of HPTCCV
            Display_BorderRed3.SetActive(false);// turns off the red border of HPTCCV
            Display_nameRed3.SetActive(false);// turns off the red part name of HPTCCV
            
        }


    }

    public void checkloadB1Flangecolour()
    {
        if (B1Flangecolor == 0)
        {
            DisplayB1_BorderGreen.SetActive(false); // turns off the green border of B1 Flange
            DisplayB1_nameGreen.SetActive(false);// turns off the green part name of B1 Flange
            DisplayB1_BorderRed.SetActive(true); // turns on the red border of B1 Flange
            DisplayB1_nameRed.SetActive(true);// turns on the red part name of B1 Flange

        }
        else if (B1Flangecolor == 1)
        {
            DisplayB1_BorderGreen.SetActive(true); //turns on the green border of B1 Flange
            DisplayB1_nameGreen.SetActive(true); // turns on the green part name of B1 Flange
            DisplayB1_BorderRed.SetActive(false); // turns off the red border of B1 Flange 
            DisplayB1_nameRed.SetActive(false); //turns off the red part name of B1 Flange

        }


    }

    public void checkloadTAIADcolour()
    {
        if (TAIADcolor == 0)
        {
            DisplayTAI_BorderGreen.SetActive(false); // turns off the green border of TAI Air Duct
            DisplayTAI_nameGreen.SetActive(false); // turns off the green part name of TAI Air Duct
            DisplayTAI_BorderRed.SetActive(true);// turns on the red border of TAI Air Duct
            DisplayTAI_nameRed.SetActive(true); // turns on the red part name of TAI Air Duct 

        }
        else if (TAIADcolor == 1)
        {
            DisplayTAI_BorderGreen.SetActive(true); // turns on the green border of TAI Air Duct
            DisplayTAI_nameGreen.SetActive(true); // turns on the green part name of TAI Air Duct
            DisplayTAI_BorderRed.SetActive(false);// turns off the red border of TAI Air Duct
            DisplayTAI_nameRed.SetActive(false);// turns off the red part name of TAI Air Duct

        }


    }

    public void checkloadALTcolour()
    {
        if (ALTcolor == 0)
        {
            DisplayALTERNATOR_BorderGreen.SetActive(false);// turns off the green border of Alternator
            DisplayALTERNATOR_nameGreen.SetActive(false); // turns off the green part name of Alternator
            DisplayALTERNATOR_BorderRed.SetActive(true);// turns on the red border of Alternator
            DisplayALTERNATOR_nameRed.SetActive(true);// turns on the red part name of Alternator 

        }
        else if (ALTcolor == 1)
        {
            DisplayALTERNATOR_BorderGreen.SetActive(true); // turns on the green border of Alternator
            DisplayALTERNATOR_nameGreen.SetActive(true); // turns on the green part name of Alternator
            DisplayALTERNATOR_BorderRed.SetActive(false);// turns off the red border of Alternator
            DisplayALTERNATOR_nameRed.SetActive(false);// turns off the red part name of Alternator

        }


    }

    public void checkloadOTBcolour()
    {
        if (OTBcolor == 0)
        {
            DisplayOTB_BorderGreen.SetActive(false); // turns off the green border of Oil Tube Blank
            DisplayOTB_nameGreen.SetActive(false); // turns off the green part name of Oil Tube Blank 
            DisplayOTB_BorderRed.SetActive(true);// turns on the red border of Oil Tube Blank 
            DisplayOTB_nameRed.SetActive(true);// turns off the red part name of Oil Tube Blank

        }
        else if (OTBcolor == 1)
        {
            DisplayOTB_BorderGreen.SetActive(true);// turns on the green border of Oil Tube Blank
            DisplayOTB_nameGreen.SetActive(true); // turns on the green part name of Oil Tube Blank
            DisplayOTB_BorderRed.SetActive(false); // turns off red border of Oil Tube Blank
            DisplayOTB_nameRed.SetActive(false); // turns off the red part name of Oil Tube Blank

        }


    }



    public void UpdateGTBremark(InputField inputField)
    {
        GTBremark = inputField.text; // Set the input text field of the GTB remarks as a variable
        sumGTBRemark.text = GTBremark; // updates the GTB remarks 
        changeGTBcolor();// activates the function 'changeGTBcolor'

    }

   

    public void UpdateHPTCCVremark(InputField inputField)
    {
        HPTCCVremark = inputField.text;
        sumHPTCCVRemark.text = HPTCCVremark;
        changeHPTCCVcolor();

    }

    public void UpdateTubeblankremark(InputField inputField)
    {
        Tubeblankremark = inputField.text;
        sumTBRemark.text = Tubeblankremark;
        changeTBcolor();
    }
    

    public void UpdateTankcapremark(InputField inputField)
    {
        Tankcapremark = inputField.text;
        sumTcRemark.text = Tankcapremark;
        changeTCcolor();
    }

    public void UpdateB1Flangeremark(InputField inputField)
    {
        B1Flangeremark = inputField.text;
        sumB1Remark.text = B1Flangeremark;
        changeB1Flangecolor();
    }

    public void UpdateTAIADremark(InputField inputField)
    {
        TAIADremark = inputField.text;
        sumTAIADRemark.text = TAIADremark;
        changeTAIADcolor();
    }

    public void UpdateALTremark(InputField inputField)
    {
        ALTremark = inputField.text;
        sumALTRemark.text = ALTremark;
        changeALTcolor();
    }

    public void UpdateOTBremark(InputField inputField)
    {
        OTBremark = inputField.text;
        sumOTBRemark.text = OTBremark;
        changeOTBcolor();
    }


    public void UpdateJobnumber(InputField inputField)
    {
        Jobnumber = inputField.text;
    }

    public void UpdateSerialnumber(InputField inputField)
    {
        Serialnumber = inputField.text;
    }

    public void SaveGame()
    {
        SaveLoad.SaveData(this);
        savesuccess.SetActive(true);
        savesuccessaudio.SetActive(true);
        CFM56audio.SetActive(false);
        Clearalltexts();
        Invoke("removesavesuccess", 3f);
    }

    private void removesavesuccess()
    {
        savesuccess.SetActive(false);
        savesuccessaudio.SetActive(false);
        
    }
    public void GTBsavebtnclicked()
    {
        GTBremarksno = 1; // GTBremarksno counter value changed to 1
    }
    public void TBsavebtnclicked()
    {
        TBremarksno = 1;
    }
    public void TCsavebtnclicked()
    {
        TCremarksno = 1;
    }
    public void HPTCCVsavebtnclicked()
    {
        HPTCCVremarksno = 1;
    }

    public void B1Flangesavebtnclicked()
    {
        B1Flangeremarksno = 1;
    }

    public void TAIADsavebtnclicked()
    {
        TAIADremarksno = 1;
    }

    public void ALTsavebtnclicked()
    {
        ALTremarksno = 1;
    }

    public void OTBsavebtnclicked()
    {
        ALTremarksno = 1;
    }
    public void GTBbackbtnfilter()
    {
        if (GTBremarksno == 0) // if counter value of GTBremarksno becomes 0
        {
            CharacterData data = SaveLoad.LoadData();//load the data from the SaveLoad script and converts to "CharacterData" variable
            GTBremark = data.GTBremark;//converts the variable GTB text remark into a data
            _GTBremark.text = GTBremark;//converts the GTB text remark into a variable
        }
    }

    public void TBbackbtnfilter()
    {
        if (TBremarksno == 0)
        {
            CharacterData data = SaveLoad.LoadData();
            Tubeblankremark = data.Tubeblankremark;
            _Tubeblankremark.text = Tubeblankremark;
        }
    }
    public void TCbackbtnfilter()
    {
        if (TCremarksno == 0)
        {
            CharacterData data = SaveLoad.LoadData();
            Tankcapremark = data.Tankcapremark;
            _Tankcapremark.text = Tankcapremark;
        }
    }
    public void HPTCCVbackbtnfilter()
    {
        if (HPTCCVremarksno == 0)
        {
            CharacterData data = SaveLoad.LoadData();
            HPTCCVremark = data.HPTCCVremark;
            _HPTCCVremark.text = HPTCCVremark;
        }
    }

    public void TAIADbackbtnfilter()
    {
        if (TAIADremarksno == 0)
        {
            CharacterData data = SaveLoad.LoadData();
            TAIADremark = data.TAIADremark1;
            _TAIADremark.text = TAIADremark;
        }
    }

    public void B1Flangebackbtnfilter()
    {
        if (B1Flangeremarksno == 0)
        {
            CharacterData data = SaveLoad.LoadData();
            B1Flangeremark = data.B1Flangeremark1;
            _B1Flangeremark.text = B1Flangeremark;
        }
    }

    public void ALTbackbtnfilter()
    {
        if (ALTremarksno == 0)
        {
            CharacterData data = SaveLoad.LoadData();
            ALTremark = data.ALTremark1;
            _ALTremark.text = ALTremark;
        }
    }

    public void OTBbackbtnfilter()
    {
        if (OTBremarksno == 0)
        {
            CharacterData data = SaveLoad.LoadData();
            OTBremark = data.OTBremark1;
            _OTBremark.text = OTBremark;
        }
    }

    public void Clearalltexts()
    {
        _GTBremark.text = "";// removes all text from GTBremark
        _HPTCCVremark.text = "";//removes all text from HPTCCVremark
        _Tankcapremark.text = "";//removes all text from Tankcapremark
        _Tubeblankremark.text = "";//removes all text from Tubeblankremark
        _B1Flangeremark.text = "";//removes all text from B1flangeremark
        _TAIADremark.text = "";//removes all text from TAIADremark
        _ALTremark.text = "";//removes all text from ALTremark
        _OTBremark.text = "";//removes all text from OTBremark
        _Serialnumber.text = "";//removes all text from Serialnumber
        _Jobnumber.text = "";//removes all text from Jobnumber


    }

    public void remarksnoallchange()
    {
        GTBremarksno = 1;
        TBremarksno = 1;
        TCremarksno = 1;
        HPTCCVremarksno = 1;
        B1Flangeremarksno = 1;
        TAIADremarksno = 1;
        ALTremarksno = 1;
        OTBremarksno = 1;
    }

}