using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Engine5bOriginal : MonoBehaviour
{
    public InputField userJobNum;
    public InputField userSerialNum;
    public InputField inputInteger;
    public InputField inputInteger1;
    public GameObject warningTextIDEmpty;
    public GameObject warningInvalidID;

    public string user_JobNum;
    public string user_SerialNum;
    public string user_JobNum_integer;
    public string user_SerialNum_integer;
    private int error = 0;
    private int colour = 0;
    public GameObject Backtomenu;
    public GameObject ChoseDispatch;
    public GameObject ChoseRec;
    public GameObject CFM5b;
    public GameObject GTBlist;
    public GameObject BacktoRec;
    public GameObject GTBDamage;
    public GameObject GTBRemark;
    public GameObject Invalid;
    public SpriteRenderer Border;
    public GameObject ConfirmBtn;
    public GameObject PartName;
    public GameObject JobNumber;
    public GameObject SerialNumber;
    public string JobNum;
    public string SerialNum;
    public GameObject JobnSerialFilterlist;
    public string GTBDamages;
    public string GTBRemarks;
    public GameObject Inspectbtn;
    public GameObject Dingsound;
    public GameObject TubeBlankDamage;
    public GameObject TubeBlankRemark;
    public string TubeBlankDamages;
    public string TubeBlankRemarks;
    public GameObject TubeBlanklist;
    public GameObject HPTCCVDamage;
    public GameObject HPTCCVRemark;
    public string HPTCCVDamages;
    public string HPTCCVRemarks;
    public GameObject HPTCCVlist;
    public GameObject TankCapDamage;
    public GameObject TankCapRemark;
    public string TankCapDamages;
    public string TankCapRemarks;
    public GameObject TankCaplist;
    public int superSize = 2;
    private int _shotIndex = 0;
    public Text JobNo;
    public Text SerialNo;
    public GameObject SSCamera;
    public GameObject SummaryList;
    public Text sumTBDamage;
    public Text sumTBRemark;
    public Text sumGTBDamage;
    public Text sumGTBRemark;
    public Text sumHPTCCVDamage;
    public Text sumHPTCCVRemark;
    public Text sumTCDamage;
    public Text sumTcRemark;
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
    public GameObject Damageinput;
    public GameObject Remarkinput;
    public string Damagesinput;
    public string Remarksinput;
    public InputField Remarksinputfield;
    public InputField Damagesinputfield;



    private void Start()
    {
        ChoseDispatch.SetActive(false);
        CFM5b.SetActive(true);
        GTBlist.SetActive(false);
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        Inspectbtn.SetActive(false);
        Dingsound.SetActive(false);
        HPTCCVlist.SetActive(false);
        TubeBlanklist.SetActive(false);
        ChoseRec.SetActive(false);
        TankCaplist.SetActive(false);
        Invalid.SetActive(false);
        SummaryList.SetActive(false);
    }

    public void CheckParticulars()
    {

        user_JobNum = userJobNum.text;
        user_SerialNum = userSerialNum.text;

        string input1 = user_JobNum;
        string input2 = user_SerialNum;


        warningTextIDEmpty.SetActive(false);
        warningInvalidID.SetActive(false);



        if (string.IsNullOrEmpty(input1) && string.IsNullOrEmpty(input2)) // if user did not input both 
        {

            warningTextIDEmpty.SetActive(true);
            error = 1;
        }

        else if (string.IsNullOrEmpty(input1))
        {
            warningTextIDEmpty.SetActive(true);
            error = 1;
        }

        else if (string.IsNullOrEmpty(input2)) // if user only input user name
        {
            warningTextIDEmpty.SetActive(true);
            error = 1;
        }

        else
        {
            warningTextIDEmpty.SetActive(false);
            int.TryParse(input2, out int result); // try
            int.TryParse(input1, out int result1);
            if ((result > 9999999 && result < 100000000) && (result1 > 9999999 && result1 < 100000000))
            {

                error = 0;
            }
            else
            {

                warningInvalidID.SetActive(true);
                error = 1;

            }
        }
    }

    public void CertifiedID()
    {
        if (error == 0)
        {
            warningInvalidID.SetActive(false);

            ChoseRec.SetActive(true);
            CFM5b.SetActive(false);
            HPTCCVlist.SetActive(false);
            TubeBlanklist.SetActive(false);
            TankCaplist.SetActive(false);
            GTBlist.SetActive(false);
            JobNo.text = user_JobNum;
            SerialNo.text = user_SerialNum;
        }
    }
    public void ClearTextsTankCap()
    {
        Damagesinputfield.text = TankCapDamages;
        Remarksinputfield.text = TankCapRemarks;
    }


    public void OnSumlist()
    {
        SummaryList.SetActive(true);
        ChoseRec.SetActive(false);
    }

    public void backfrmsum()
    {
        SummaryList.SetActive(false);
        ChoseRec.SetActive(true);
    }




    public void Gobackmenu()
    {
        SceneManager.LoadScene(0);

    }


    public void ReceiveScan()
    {
        Invoke("Activatescan", 0.5f);

    }
    private void Activatescan()
    {
        ChoseRec.SetActive(true);
        CFM5b.SetActive(false);
        HPTCCVlist.SetActive(false);
        TubeBlanklist.SetActive(false);
        GTBlist.SetActive(false);
        TankCaplist.SetActive(false);
        Screen.orientation = ScreenOrientation.AutoRotation;
        Dingsound.SetActive(false);
        SummaryList.SetActive(false);
        SummaryBTN.SetActive(true);
        BackBTN.SetActive(true);
    }
    public void BackHome()
    {

        SceneManager.LoadScene(1);
    }

    public void RemoveBtns()
    {
        SummaryBTN.SetActive(false);
        BackBTN.SetActive(false);
        Display_JobNo.SetActive(false);
        Display_SerialNo.SetActive(false);
        Display_JobNo1.SetActive(false);
        Display_SerialNo1.SetActive(false);
        Display_BorderRed.SetActive(false);
        Display_nameRed.SetActive(false);
        Display_BorderGreen.SetActive(false);
        Display_nameGreen.SetActive(false);
    }


    public void DetectedObject()
    {
        Inspectbtn.SetActive(true);
        Dingsound.SetActive(true);
        SSCamera.SetActive(true);
        Damagesinput = Damageinput.GetComponent<Text>().text;
        Remarksinput = Remarkinput.GetComponent<Text>().text;

    }
    public void checkcolour()
    {
        if (colour == 0)

        {

            ChangeColourRed();
        }
        else if (colour == 1)
        {
            ChangeColourGreen();

        }
    }
    public void Offdingsound()
    {
        Dingsound.SetActive(false);
        Display_JobNo.SetActive(true);
        Display_SerialNo.SetActive(true);
        Display_JobNo1.SetActive(true);
        Display_SerialNo1.SetActive(true);
        SummaryBTN.SetActive(true);
        BackBTN.SetActive(true);

    }

    public void OffCamera()
    {
        SSCamera.SetActive(false);
    }
    public void delayGTB()
    {
        Invoke("ToGTBList", 0.5f);
        Inspectbtn.SetActive(false);
        Invoke("OffCamera", 1.5f);
        Invoke("RemoveRec", 0.5f);
    }

    public void delayTubeBlank()
    {
        Invoke("ToTubeBlankList", 0.5f);
        Inspectbtn.SetActive(false);
        Invoke("OffCamera", 1.5f);
        Invoke("RemoveRec", 0.5f);
    }

    public void delayHPTCCV()
    {
        Invoke("ToHPTCCVList", 0.5f);
        Inspectbtn.SetActive(false);
        Invoke("OffCamera", 1.5f);
        Invoke("RemoveRec", 0.5f);
    }

    public void delayTankCap()
    {
        Invoke("ToTankCapList", 0.5f);
        Inspectbtn.SetActive(false);
        Invoke("OffCamera", 1.5f);
        Invoke("RemoveRec", 0.5f);



    }

    void RemoveRec()
    {
        ChoseRec.SetActive(false);
    }
    public void ToGTBList()
    {
        GTBlist.SetActive(true);
        ChoseRec.SetActive(false);
        Invalid.SetActive(false);


        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }


    public void ToTubeBlankList()
    {
        TubeBlanklist.SetActive(true);
        ChoseRec.SetActive(false);
        Invalid.SetActive(false);
        Inspectbtn.SetActive(false);

        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
    public void ToHPTCCVList()
    {
        HPTCCVlist.SetActive(true);
        ChoseRec.SetActive(false);
        Invalid.SetActive(false);
        Inspectbtn.SetActive(false);

        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
    public void ToTankCapList()
    {
        TankCaplist.SetActive(true);
        ChoseRec.SetActive(false);
        Invalid.SetActive(false);
        Inspectbtn.SetActive(false);

        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
    public void GTBCFMBtn()
    {
        GTBDamages = GTBDamage.GetComponent<Text>().text;
        GTBRemarks = GTBRemark.GetComponent<Text>().text;
        if ((GTBDamages == "") || (GTBRemarks == ""))

        {
            Invalid.SetActive(true);
            ChangeColourRed();
            colour = 0;
        }
        else
        {
            GTBlist.SetActive(false);
            Invalid.SetActive(false);
            ChoseRec.SetActive(true);
            sumGTBDamage.text = GTBDamages;
            sumGTBRemark.text = GTBRemarks;
            ChangeColourGreen();
            colour = 1;
        }
    }
    public void TubeBlankCFMBtn()
    {
        TubeBlankDamages = TubeBlankDamage.GetComponent<Text>().text;
        TubeBlankRemarks = TubeBlankRemark.GetComponent<Text>().text;
        if ((TubeBlankDamages == "") || (TubeBlankRemarks == ""))

        {
            Invalid.SetActive(true);
            ChangeColourRed();
            colour = 0;
        }
        else
        {
            Invalid.SetActive(false);
            ChoseRec.SetActive(true);
            TubeBlanklist.SetActive(false);
            sumTBDamage.text = TubeBlankDamages;
            sumTBRemark.text = TubeBlankRemarks;
            ChangeColourGreen();
            colour = 1;
        }
    }

    public void HPTCCVCFMBtn()
    {
        HPTCCVDamages = HPTCCVDamage.GetComponent<Text>().text;
        HPTCCVRemarks = HPTCCVRemark.GetComponent<Text>().text;
        if ((HPTCCVDamages == "") || (HPTCCVRemarks == ""))

        {
            Invalid.SetActive(true);
            ChangeColourRed();
            colour = 0;
        }
        else
        {
            Invalid.SetActive(false);
            ChoseRec.SetActive(true);
            HPTCCVlist.SetActive(false);
            sumHPTCCVDamage.text = HPTCCVDamages;
            sumHPTCCVRemark.text = HPTCCVRemarks;
            ChangeColourGreen();
            colour = 1;
        }
    }
    public void TankCapCFMBtn()
    {
        TankCapDamages = TankCapDamage.GetComponent<Text>().text;
        TankCapRemarks = TankCapRemark.GetComponent<Text>().text;
        if ((TankCapDamages == "") || (TankCapRemarks == ""))

        {
            Invalid.SetActive(true);
            sumTCDamage.text = "";
            sumTcRemark.text = "";
            colour = 0;
        }
        else
        {
            Invalid.SetActive(false);
            ChoseRec.SetActive(true);
            TankCaplist.SetActive(false);
            sumTCDamage.text = TankCapDamages;
            sumTcRemark.text = TankCapRemarks;
            colour = 1;
        }

    }

    public void ChangeColourGreen()
    {
        Display_BorderRed.SetActive(false);
        Display_nameRed.SetActive(false);
        Display_BorderGreen.SetActive(true);
        Display_nameGreen.SetActive(true);
    }

    public void ChangeColourRed()
    {
        Display_BorderRed.SetActive(true);
        Display_nameRed.SetActive(true);
        Display_BorderGreen.SetActive(false);
        Display_nameGreen.SetActive(false);
    }

}
