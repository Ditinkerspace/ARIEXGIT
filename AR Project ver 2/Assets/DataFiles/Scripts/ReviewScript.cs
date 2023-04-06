using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ReviewScript : MonoBehaviour
{
    public int pageNumber;

    public GameObject MissingPage1;
    public GameObject MissingPage2;
    public GameObject MissingPage3;
    public GameObject MissingPage4;
    public GameObject MissingPage5;
    public GameObject MissingPage6;

    public GameObject SurplusPage1;
    public GameObject SurplusPage2;
    public GameObject SurplusPage3;
    public GameObject SurplusPage4;
    public GameObject SurplusPage5;
    public GameObject SurplusPage6;

    public GameObject ConfirmPage;
    public GameObject ReviewPage1;
    public GameObject ReviewPage2;
    public GameObject ReviewPage3;
    public GameObject ReviewPage4;
    public GameObject ReviewPage5;
    public GameObject ReviewPage6;
    public GameObject ReviewPage7;
    public GameObject ReviewPage8;
    public GameObject ReviewPage9;
    public GameObject ReviewPage10;
    public GameObject ReviewPage11;
    public GameObject ReviewPage12;
    public GameObject ReviewPage13;
    public GameObject ReviewPage14;
    public GameObject ReviewPage15;
    public GameObject ReviewPage16;
    public GameObject ReviewPage17;
    public GameObject ReviewPage18;
    public GameObject ReviewPage19;
    public GameObject ReviewPage20;
    public GameObject ReviewPage21;
    public GameObject ReviewPage22;
    public GameObject SubmitPage;

    public TextMeshProUGUI ReceivedPart1;
    public TextMeshProUGUI ReceivedPart2;
    public TextMeshProUGUI ReceivedPart3;
    public TextMeshProUGUI ReceivedPart4;
    public TextMeshProUGUI ReceivedPart5;
    public TextMeshProUGUI ReceivedPart6;
    public TextMeshProUGUI ReceivedPart7;
    public TextMeshProUGUI ReceivedPart8;
    public TextMeshProUGUI ReceivedPart9;
    public TextMeshProUGUI ReceivedPart10;
    public TextMeshProUGUI ReceivedPart11;
    public TextMeshProUGUI ReceivedPart12;
    public TextMeshProUGUI ReceivedPart13;
    public TextMeshProUGUI ReceivedPart14;
    public TextMeshProUGUI ReceivedPart15;
    public TextMeshProUGUI ReceivedPart16;
    public TextMeshProUGUI ReceivedPart17;
    public TextMeshProUGUI ReceivedPart18;
    public TextMeshProUGUI ReceivedPart19;
    public TextMeshProUGUI ReceivedPart20;
    public TextMeshProUGUI ReceivedPart21;
    public TextMeshProUGUI ReceivedPart22;
    public TextMeshProUGUI ReceivedPart23;
    public TextMeshProUGUI ReceivedPart24;
    public TextMeshProUGUI ReceivedPart25;
    public TextMeshProUGUI ReceivedPart26;
    public TextMeshProUGUI ReceivedPart27;
    public TextMeshProUGUI ReceivedPart28;
    public TextMeshProUGUI ReceivedPart29;
    public TextMeshProUGUI ReceivedPart30;
    public TextMeshProUGUI ReceivedPart31;
    public TextMeshProUGUI ReceivedPart32;
    public TextMeshProUGUI ReceivedPart33;
    public TextMeshProUGUI ReceivedPart34;
    public TextMeshProUGUI ReceivedPart35;
    public TextMeshProUGUI ReceivedPart36;
    public TextMeshProUGUI ReceivedPart37;
    public TextMeshProUGUI ReceivedPart38;
    public TextMeshProUGUI ReceivedPart39;
    public TextMeshProUGUI ReceivedPart40;
    public TextMeshProUGUI ReceivedPart41;
    public TextMeshProUGUI ReceivedPart42;
    public TextMeshProUGUI ReceivedPart43;
    public TextMeshProUGUI ReceivedPart44;
    public TextMeshProUGUI ReceivedPart45;
    public TextMeshProUGUI ReceivedPart46;
    public TextMeshProUGUI ReceivedPart47;
    public TextMeshProUGUI ReceivedPart48;
    public TextMeshProUGUI ReceivedPart49;
    public TextMeshProUGUI ReceivedPart50;

    public TextMeshProUGUI DamagedPart1;
    public TextMeshProUGUI DamagedPart2;
    public TextMeshProUGUI DamagedPart3;
    public TextMeshProUGUI DamagedPart4;
    public TextMeshProUGUI DamagedPart5;
    public TextMeshProUGUI DamagedPart6;
    public TextMeshProUGUI DamagedPart7;
    public TextMeshProUGUI DamagedPart8;
    public TextMeshProUGUI DamagedPart9;
    public TextMeshProUGUI DamagedPart10;
    public TextMeshProUGUI DamagedPart11;
    public TextMeshProUGUI DamagedPart12;
    public TextMeshProUGUI DamagedPart13;
    public TextMeshProUGUI DamagedPart14;
    public TextMeshProUGUI DamagedPart15;
    public TextMeshProUGUI DamagedPart16;
    public TextMeshProUGUI DamagedPart17;
    public TextMeshProUGUI DamagedPart18;
    public TextMeshProUGUI DamagedPart19;
    public TextMeshProUGUI DamagedPart20;
    public TextMeshProUGUI DamagedPart21;
    public TextMeshProUGUI DamagedPart22;
    public TextMeshProUGUI DamagedPart23;
    public TextMeshProUGUI DamagedPart24;
    public TextMeshProUGUI DamagedPart25;
    public TextMeshProUGUI DamagedPart26;
    public TextMeshProUGUI DamagedPart27;
    public TextMeshProUGUI DamagedPart28;
    public TextMeshProUGUI DamagedPart29;
    public TextMeshProUGUI DamagedPart30;
    public TextMeshProUGUI DamagedPart31;
    public TextMeshProUGUI DamagedPart32;
    public TextMeshProUGUI DamagedPart33;
    public TextMeshProUGUI DamagedPart34;
    public TextMeshProUGUI DamagedPart35;
    public TextMeshProUGUI DamagedPart36;
    public TextMeshProUGUI DamagedPart37;
    public TextMeshProUGUI DamagedPart38;
    public TextMeshProUGUI DamagedPart39;
    public TextMeshProUGUI DamagedPart40;
    public TextMeshProUGUI DamagedPart41;
    public TextMeshProUGUI DamagedPart42;
    public TextMeshProUGUI DamagedPart43;
    public TextMeshProUGUI DamagedPart44;
    public TextMeshProUGUI DamagedPart45;
    public TextMeshProUGUI DamagedPart46;
    public TextMeshProUGUI DamagedPart47;
    public TextMeshProUGUI DamagedPart48;
    public TextMeshProUGUI DamagedPart49;
    public TextMeshProUGUI DamagedPart50;

    public TextMeshProUGUI RemarksPart1;
    public TextMeshProUGUI RemarksPart2;
    public TextMeshProUGUI RemarksPart3;
    public TextMeshProUGUI RemarksPart4;
    public TextMeshProUGUI RemarksPart5;
    public TextMeshProUGUI RemarksPart6;
    public TextMeshProUGUI RemarksPart7;
    public TextMeshProUGUI RemarksPart8;
    public TextMeshProUGUI RemarksPart9;
    public TextMeshProUGUI RemarksPart10;
    public TextMeshProUGUI RemarksPart11;
    public TextMeshProUGUI RemarksPart12;
    public TextMeshProUGUI RemarksPart13;
    public TextMeshProUGUI RemarksPart14;
    public TextMeshProUGUI RemarksPart15;
    public TextMeshProUGUI RemarksPart16;
    public TextMeshProUGUI RemarksPart17;
    public TextMeshProUGUI RemarksPart18;
    public TextMeshProUGUI RemarksPart19;
    public TextMeshProUGUI RemarksPart20;
    public TextMeshProUGUI RemarksPart21;
    public TextMeshProUGUI RemarksPart22;
    public TextMeshProUGUI RemarksPart23;
    public TextMeshProUGUI RemarksPart24;
    public TextMeshProUGUI RemarksPart25;
    public TextMeshProUGUI RemarksPart26;
    public TextMeshProUGUI RemarksPart27;
    public TextMeshProUGUI RemarksPart28;
    public TextMeshProUGUI RemarksPart29;
    public TextMeshProUGUI RemarksPart30;
    public TextMeshProUGUI RemarksPart31;
    public TextMeshProUGUI RemarksPart32;
    public TextMeshProUGUI RemarksPart33;
    public TextMeshProUGUI RemarksPart34;
    public TextMeshProUGUI RemarksPart35;
    public TextMeshProUGUI RemarksPart36;
    public TextMeshProUGUI RemarksPart37;
    public TextMeshProUGUI RemarksPart38;
    public TextMeshProUGUI RemarksPart39;
    public TextMeshProUGUI RemarksPart40;
    public TextMeshProUGUI RemarksPart41;
    public TextMeshProUGUI RemarksPart42;
    public TextMeshProUGUI RemarksPart43;
    public TextMeshProUGUI RemarksPart44;
    public TextMeshProUGUI RemarksPart45;
    public TextMeshProUGUI RemarksPart46;
    public TextMeshProUGUI RemarksPart47;
    public TextMeshProUGUI RemarksPart48;
    public TextMeshProUGUI RemarksPart49;
    public TextMeshProUGUI RemarksPart50;

    // ============================================================== REVIEW FOR MISSING ITEMS ==================================================================================

    //===== Missingreviewpage 1 (Display review page 11)

    public TextMeshProUGUI Missing_1Name1;
    public TextMeshProUGUI Missing_1Name2;
    public TextMeshProUGUI Missing_1Name3;
    public TextMeshProUGUI Missing_1Name4;
    public TextMeshProUGUI Missing_1Name5;

    public TextMeshProUGUI Missing_1PartNum1;
    public TextMeshProUGUI Missing_1PartNum2;
    public TextMeshProUGUI Missing_1PartNum3;
    public TextMeshProUGUI Missing_1PartNum4;
    public TextMeshProUGUI Missing_1PartNum5;

    public TextMeshProUGUI Missing_1SerialNum1;
    public TextMeshProUGUI Missing_1SerialNum2;
    public TextMeshProUGUI Missing_1SerialNum3;
    public TextMeshProUGUI Missing_1SerialNum4;
    public TextMeshProUGUI Missing_1SerialNum5;

    public TextMeshProUGUI Missing_1Remarks1;
    public TextMeshProUGUI Missing_1Remarks2;
    public TextMeshProUGUI Missing_1Remarks3;
    public TextMeshProUGUI Missing_1Remarks4;
    public TextMeshProUGUI Missing_1Remarks5;

    //===== Missingreviewpage 2

    public TextMeshProUGUI Missing_2Name1;
    public TextMeshProUGUI Missing_2Name2;
    public TextMeshProUGUI Missing_2Name3;
    public TextMeshProUGUI Missing_2Name4;
    public TextMeshProUGUI Missing_2Name5;

    public TextMeshProUGUI Missing_2PartNum1;
    public TextMeshProUGUI Missing_2PartNum2;
    public TextMeshProUGUI Missing_2PartNum3;
    public TextMeshProUGUI Missing_2PartNum4;
    public TextMeshProUGUI Missing_2PartNum5;

    public TextMeshProUGUI Missing_2SerialNum1;
    public TextMeshProUGUI Missing_2SerialNum2;
    public TextMeshProUGUI Missing_2SerialNum3;
    public TextMeshProUGUI Missing_2SerialNum4;
    public TextMeshProUGUI Missing_2SerialNum5;

    public TextMeshProUGUI Missing_2Remarks1;
    public TextMeshProUGUI Missing_2Remarks2;
    public TextMeshProUGUI Missing_2Remarks3;
    public TextMeshProUGUI Missing_2Remarks4;
    public TextMeshProUGUI Missing_2Remarks5;

    //===== Missingreviewpage 3

    public TextMeshProUGUI Missing_3Name1;
    public TextMeshProUGUI Missing_3Name2;
    public TextMeshProUGUI Missing_3Name3;
    public TextMeshProUGUI Missing_3Name4;
    public TextMeshProUGUI Missing_3Name5;

    public TextMeshProUGUI Missing_3PartNum1;
    public TextMeshProUGUI Missing_3PartNum2;
    public TextMeshProUGUI Missing_3PartNum3;
    public TextMeshProUGUI Missing_3PartNum4;
    public TextMeshProUGUI Missing_3PartNum5;

    public TextMeshProUGUI Missing_3SerialNum1;
    public TextMeshProUGUI Missing_3SerialNum2;
    public TextMeshProUGUI Missing_3SerialNum3;
    public TextMeshProUGUI Missing_3SerialNum4;
    public TextMeshProUGUI Missing_3SerialNum5;

    public TextMeshProUGUI Missing_3Remarks1;
    public TextMeshProUGUI Missing_3Remarks2;
    public TextMeshProUGUI Missing_3Remarks3;
    public TextMeshProUGUI Missing_3Remarks4;
    public TextMeshProUGUI Missing_3Remarks5;

    //===== Missingreviewpage 4

    public TextMeshProUGUI Missing_4Name1;
    public TextMeshProUGUI Missing_4Name2;
    public TextMeshProUGUI Missing_4Name3;
    public TextMeshProUGUI Missing_4Name4;
    public TextMeshProUGUI Missing_4Name5;

    public TextMeshProUGUI Missing_4PartNum1;
    public TextMeshProUGUI Missing_4PartNum2;
    public TextMeshProUGUI Missing_4PartNum3;
    public TextMeshProUGUI Missing_4PartNum4;
    public TextMeshProUGUI Missing_4PartNum5;

    public TextMeshProUGUI Missing_4SerialNum1;
    public TextMeshProUGUI Missing_4SerialNum2;
    public TextMeshProUGUI Missing_4SerialNum3;
    public TextMeshProUGUI Missing_4SerialNum4;
    public TextMeshProUGUI Missing_4SerialNum5;

    public TextMeshProUGUI Missing_4Remarks1;
    public TextMeshProUGUI Missing_4Remarks2;
    public TextMeshProUGUI Missing_4Remarks3;
    public TextMeshProUGUI Missing_4Remarks4;
    public TextMeshProUGUI Missing_4Remarks5;

    //===== Missingreviewpage 5

    public TextMeshProUGUI Missing_5Name1;
    public TextMeshProUGUI Missing_5Name2;
    public TextMeshProUGUI Missing_5Name3;
    public TextMeshProUGUI Missing_5Name4;
    public TextMeshProUGUI Missing_5Name5;

    public TextMeshProUGUI Missing_5PartNum1;
    public TextMeshProUGUI Missing_5PartNum2;
    public TextMeshProUGUI Missing_5PartNum3;
    public TextMeshProUGUI Missing_5PartNum4;
    public TextMeshProUGUI Missing_5PartNum5;

    public TextMeshProUGUI Missing_5SerialNum1;
    public TextMeshProUGUI Missing_5SerialNum2;
    public TextMeshProUGUI Missing_5SerialNum3;
    public TextMeshProUGUI Missing_5SerialNum4;
    public TextMeshProUGUI Missing_5SerialNum5;

    public TextMeshProUGUI Missing_5Remarks1;
    public TextMeshProUGUI Missing_5Remarks2;
    public TextMeshProUGUI Missing_5Remarks3;
    public TextMeshProUGUI Missing_5Remarks4;
    public TextMeshProUGUI Missing_5Remarks5;

    //===== Missingreviewpage 6

    public TextMeshProUGUI Missing_6Name1;
    public TextMeshProUGUI Missing_6Name2;
    public TextMeshProUGUI Missing_6Name3;
    public TextMeshProUGUI Missing_6Name4;
    public TextMeshProUGUI Missing_6Name5;

    public TextMeshProUGUI Missing_6PartNum1;
    public TextMeshProUGUI Missing_6PartNum2;
    public TextMeshProUGUI Missing_6PartNum3;
    public TextMeshProUGUI Missing_6PartNum4;
    public TextMeshProUGUI Missing_6PartNum5;

    public TextMeshProUGUI Missing_6SerialNum1;
    public TextMeshProUGUI Missing_6SerialNum2;
    public TextMeshProUGUI Missing_6SerialNum3;
    public TextMeshProUGUI Missing_6SerialNum4;
    public TextMeshProUGUI Missing_6SerialNum5;

    public TextMeshProUGUI Missing_6Remarks1;
    public TextMeshProUGUI Missing_6Remarks2;
    public TextMeshProUGUI Missing_6Remarks3;
    public TextMeshProUGUI Missing_6Remarks4;
    public TextMeshProUGUI Missing_6Remarks5;

    //===== Surplusreviewpage 1 (Display review page 17)

    public TextMeshProUGUI Surplus_1Name1;
    public TextMeshProUGUI Surplus_1Name2;
    public TextMeshProUGUI Surplus_1Name3;
    public TextMeshProUGUI Surplus_1Name4;
    public TextMeshProUGUI Surplus_1Name5;

    public TextMeshProUGUI Surplus_1PartNum1;
    public TextMeshProUGUI Surplus_1PartNum2;
    public TextMeshProUGUI Surplus_1PartNum3;
    public TextMeshProUGUI Surplus_1PartNum4;
    public TextMeshProUGUI Surplus_1PartNum5;

    public TextMeshProUGUI Surplus_1SerialNum1;
    public TextMeshProUGUI Surplus_1SerialNum2;
    public TextMeshProUGUI Surplus_1SerialNum3;
    public TextMeshProUGUI Surplus_1SerialNum4;
    public TextMeshProUGUI Surplus_1SerialNum5;

    public TextMeshProUGUI Surplus_1Remarks1;
    public TextMeshProUGUI Surplus_1Remarks2;
    public TextMeshProUGUI Surplus_1Remarks3;
    public TextMeshProUGUI Surplus_1Remarks4;
    public TextMeshProUGUI Surplus_1Remarks5;

    //===== Surplusreviewpage 2

    public TextMeshProUGUI Surplus_2Name1;
    public TextMeshProUGUI Surplus_2Name2;
    public TextMeshProUGUI Surplus_2Name3;
    public TextMeshProUGUI Surplus_2Name4;
    public TextMeshProUGUI Surplus_2Name5;

    public TextMeshProUGUI Surplus_2PartNum1;
    public TextMeshProUGUI Surplus_2PartNum2;
    public TextMeshProUGUI Surplus_2PartNum3;
    public TextMeshProUGUI Surplus_2PartNum4;
    public TextMeshProUGUI Surplus_2PartNum5;

    public TextMeshProUGUI Surplus_2SerialNum1;
    public TextMeshProUGUI Surplus_2SerialNum2;
    public TextMeshProUGUI Surplus_2SerialNum3;
    public TextMeshProUGUI Surplus_2SerialNum4;
    public TextMeshProUGUI Surplus_2SerialNum5;

    public TextMeshProUGUI Surplus_2Remarks1;
    public TextMeshProUGUI Surplus_2Remarks2;
    public TextMeshProUGUI Surplus_2Remarks3;
    public TextMeshProUGUI Surplus_2Remarks4;
    public TextMeshProUGUI Surplus_2Remarks5;

    //===== Surplusreviewpage 3

    public TextMeshProUGUI Surplus_3Name1;
    public TextMeshProUGUI Surplus_3Name2;
    public TextMeshProUGUI Surplus_3Name3;
    public TextMeshProUGUI Surplus_3Name4;
    public TextMeshProUGUI Surplus_3Name5;

    public TextMeshProUGUI Surplus_3PartNum1;
    public TextMeshProUGUI Surplus_3PartNum2;
    public TextMeshProUGUI Surplus_3PartNum3;
    public TextMeshProUGUI Surplus_3PartNum4;
    public TextMeshProUGUI Surplus_3PartNum5;

    public TextMeshProUGUI Surplus_3SerialNum1;
    public TextMeshProUGUI Surplus_3SerialNum2;
    public TextMeshProUGUI Surplus_3SerialNum3;
    public TextMeshProUGUI Surplus_3SerialNum4;
    public TextMeshProUGUI Surplus_3SerialNum5;

    public TextMeshProUGUI Surplus_3Remarks1;
    public TextMeshProUGUI Surplus_3Remarks2;
    public TextMeshProUGUI Surplus_3Remarks3;
    public TextMeshProUGUI Surplus_3Remarks4;
    public TextMeshProUGUI Surplus_3Remarks5;

    //===== Surplusreviewpage 4

    public TextMeshProUGUI Surplus_4Name1;
    public TextMeshProUGUI Surplus_4Name2;
    public TextMeshProUGUI Surplus_4Name3;
    public TextMeshProUGUI Surplus_4Name4;
    public TextMeshProUGUI Surplus_4Name5;

    public TextMeshProUGUI Surplus_4PartNum1;
    public TextMeshProUGUI Surplus_4PartNum2;
    public TextMeshProUGUI Surplus_4PartNum3;
    public TextMeshProUGUI Surplus_4PartNum4;
    public TextMeshProUGUI Surplus_4PartNum5;

    public TextMeshProUGUI Surplus_4SerialNum1;
    public TextMeshProUGUI Surplus_4SerialNum2;
    public TextMeshProUGUI Surplus_4SerialNum3;
    public TextMeshProUGUI Surplus_4SerialNum4;
    public TextMeshProUGUI Surplus_4SerialNum5;

    public TextMeshProUGUI Surplus_4Remarks1;
    public TextMeshProUGUI Surplus_4Remarks2;
    public TextMeshProUGUI Surplus_4Remarks3;
    public TextMeshProUGUI Surplus_4Remarks4;
    public TextMeshProUGUI Surplus_4Remarks5;

    //===== Surplusreviewpage 5

    public TextMeshProUGUI Surplus_5Name1;
    public TextMeshProUGUI Surplus_5Name2;
    public TextMeshProUGUI Surplus_5Name3;
    public TextMeshProUGUI Surplus_5Name4;
    public TextMeshProUGUI Surplus_5Name5;

    public TextMeshProUGUI Surplus_5PartNum1;
    public TextMeshProUGUI Surplus_5PartNum2;
    public TextMeshProUGUI Surplus_5PartNum3;
    public TextMeshProUGUI Surplus_5PartNum4;
    public TextMeshProUGUI Surplus_5PartNum5;

    public TextMeshProUGUI Surplus_5SerialNum1;
    public TextMeshProUGUI Surplus_5SerialNum2;
    public TextMeshProUGUI Surplus_5SerialNum3;
    public TextMeshProUGUI Surplus_5SerialNum4;
    public TextMeshProUGUI Surplus_5SerialNum5;

    public TextMeshProUGUI Surplus_5Remarks1;
    public TextMeshProUGUI Surplus_5Remarks2;
    public TextMeshProUGUI Surplus_5Remarks3;
    public TextMeshProUGUI Surplus_5Remarks4;
    public TextMeshProUGUI Surplus_5Remarks5;

    //===== Surplusreviewpage 6

    public TextMeshProUGUI Surplus_6Name1;
    public TextMeshProUGUI Surplus_6Name2;
    public TextMeshProUGUI Surplus_6Name3;
    public TextMeshProUGUI Surplus_6Name4;
    public TextMeshProUGUI Surplus_6Name5;

    public TextMeshProUGUI Surplus_6PartNum1;
    public TextMeshProUGUI Surplus_6PartNum2;
    public TextMeshProUGUI Surplus_6PartNum3;
    public TextMeshProUGUI Surplus_6PartNum4;
    public TextMeshProUGUI Surplus_6PartNum5;

    public TextMeshProUGUI Surplus_6SerialNum1;
    public TextMeshProUGUI Surplus_6SerialNum2;
    public TextMeshProUGUI Surplus_6SerialNum3;
    public TextMeshProUGUI Surplus_6SerialNum4;
    public TextMeshProUGUI Surplus_6SerialNum5;

    public TextMeshProUGUI Surplus_6Remarks1;
    public TextMeshProUGUI Surplus_6Remarks2;
    public TextMeshProUGUI Surplus_6Remarks3;
    public TextMeshProUGUI Surplus_6Remarks4;
    public TextMeshProUGUI Surplus_6Remarks5;

    // ============================================================== INPUTS FOR MISSING ITEMS ==================================================================================

    // Input for Missing parts page 1:

    public TMP_InputField Missing1Name1;
    public TMP_InputField Missing1Name2;
    public TMP_InputField Missing1Name3;
    public TMP_InputField Missing1Name4;
    public TMP_InputField Missing1Name5;

    public TMP_InputField Missing1PartNum1;
    public TMP_InputField Missing1PartNum2;
    public TMP_InputField Missing1PartNum3;
    public TMP_InputField Missing1PartNum4;
    public TMP_InputField Missing1PartNum5;

    public TMP_InputField Missing1SerialNum1;
    public TMP_InputField Missing1SerialNum2;
    public TMP_InputField Missing1SerialNum3;
    public TMP_InputField Missing1SerialNum4;
    public TMP_InputField Missing1SerialNum5;

    public TMP_InputField Missing1Remarks1;
    public TMP_InputField Missing1Remarks2;
    public TMP_InputField Missing1Remarks3;
    public TMP_InputField Missing1Remarks4;
    public TMP_InputField Missing1Remarks5;

    // Input for Missing parts page 2:

    public TMP_InputField Missing2Name1;
    public TMP_InputField Missing2Name2;
    public TMP_InputField Missing2Name3;
    public TMP_InputField Missing2Name4;
    public TMP_InputField Missing2Name5;

    public TMP_InputField Missing2PartNum1;
    public TMP_InputField Missing2PartNum2;
    public TMP_InputField Missing2PartNum3;
    public TMP_InputField Missing2PartNum4;
    public TMP_InputField Missing2PartNum5;

    public TMP_InputField Missing2SerialNum1;
    public TMP_InputField Missing2SerialNum2;
    public TMP_InputField Missing2SerialNum3;
    public TMP_InputField Missing2SerialNum4;
    public TMP_InputField Missing2SerialNum5;

    public TMP_InputField Missing2Remarks1;
    public TMP_InputField Missing2Remarks2;
    public TMP_InputField Missing2Remarks3;
    public TMP_InputField Missing2Remarks4;
    public TMP_InputField Missing2Remarks5;

    // Input for Missing parts page 3:

    public TMP_InputField Missing3Name1;
    public TMP_InputField Missing3Name2;
    public TMP_InputField Missing3Name3;
    public TMP_InputField Missing3Name4;
    public TMP_InputField Missing3Name5;

    public TMP_InputField Missing3PartNum1;
    public TMP_InputField Missing3PartNum2;
    public TMP_InputField Missing3PartNum3;
    public TMP_InputField Missing3PartNum4;
    public TMP_InputField Missing3PartNum5;

    public TMP_InputField Missing3SerialNum1;
    public TMP_InputField Missing3SerialNum2;
    public TMP_InputField Missing3SerialNum3;
    public TMP_InputField Missing3SerialNum4;
    public TMP_InputField Missing3SerialNum5;

    public TMP_InputField Missing3Remarks1;
    public TMP_InputField Missing3Remarks2;
    public TMP_InputField Missing3Remarks3;
    public TMP_InputField Missing3Remarks4;
    public TMP_InputField Missing3Remarks5;

    // Input for Missing parts page 4:

    public TMP_InputField Missing4Name1;
    public TMP_InputField Missing4Name2;
    public TMP_InputField Missing4Name3;
    public TMP_InputField Missing4Name4;
    public TMP_InputField Missing4Name5;

    public TMP_InputField Missing4PartNum1;
    public TMP_InputField Missing4PartNum2;
    public TMP_InputField Missing4PartNum3;
    public TMP_InputField Missing4PartNum4;
    public TMP_InputField Missing4PartNum5;

    public TMP_InputField Missing4SerialNum1;
    public TMP_InputField Missing4SerialNum2;
    public TMP_InputField Missing4SerialNum3;
    public TMP_InputField Missing4SerialNum4;
    public TMP_InputField Missing4SerialNum5;

    public TMP_InputField Missing4Remarks1;
    public TMP_InputField Missing4Remarks2;
    public TMP_InputField Missing4Remarks3;
    public TMP_InputField Missing4Remarks4;
    public TMP_InputField Missing4Remarks5;

    // Input for Missing parts page 5:

    public TMP_InputField Missing5Name1;
    public TMP_InputField Missing5Name2;
    public TMP_InputField Missing5Name3;
    public TMP_InputField Missing5Name4;
    public TMP_InputField Missing5Name5;

    public TMP_InputField Missing5PartNum1;
    public TMP_InputField Missing5PartNum2;
    public TMP_InputField Missing5PartNum3;
    public TMP_InputField Missing5PartNum4;
    public TMP_InputField Missing5PartNum5;

    public TMP_InputField Missing5SerialNum1;
    public TMP_InputField Missing5SerialNum2;
    public TMP_InputField Missing5SerialNum3;
    public TMP_InputField Missing5SerialNum4;
    public TMP_InputField Missing5SerialNum5;

    public TMP_InputField Missing5Remarks1;
    public TMP_InputField Missing5Remarks2;
    public TMP_InputField Missing5Remarks3;
    public TMP_InputField Missing5Remarks4;
    public TMP_InputField Missing5Remarks5;

    // Input for Missing parts page 6:

    public TMP_InputField Missing6Name1;
    public TMP_InputField Missing6Name2;
    public TMP_InputField Missing6Name3;
    public TMP_InputField Missing6Name4;
    public TMP_InputField Missing6Name5;

    public TMP_InputField Missing6PartNum1;
    public TMP_InputField Missing6PartNum2;
    public TMP_InputField Missing6PartNum3;
    public TMP_InputField Missing6PartNum4;
    public TMP_InputField Missing6PartNum5;

    public TMP_InputField Missing6SerialNum1;
    public TMP_InputField Missing6SerialNum2;
    public TMP_InputField Missing6SerialNum3;
    public TMP_InputField Missing6SerialNum4;
    public TMP_InputField Missing6SerialNum5;

    public TMP_InputField Missing6Remarks1;
    public TMP_InputField Missing6Remarks2;
    public TMP_InputField Missing6Remarks3;
    public TMP_InputField Missing6Remarks4;
    public TMP_InputField Missing6Remarks5;

    // ============================================================== INPUTS FOR SURPLUS ITEMS ==================================================================================

    // Input for Surplus parts page 1 :

    public TMP_InputField Surplus1Name1;
    public TMP_InputField Surplus1Name2;
    public TMP_InputField Surplus1Name3;
    public TMP_InputField Surplus1Name4;
    public TMP_InputField Surplus1Name5;

    public TMP_InputField Surplus1PartNum1;
    public TMP_InputField Surplus1PartNum2;
    public TMP_InputField Surplus1PartNum3;
    public TMP_InputField Surplus1PartNum4;
    public TMP_InputField Surplus1PartNum5;

    public TMP_InputField Surplus1SerialNum1;
    public TMP_InputField Surplus1SerialNum2;
    public TMP_InputField Surplus1SerialNum3;
    public TMP_InputField Surplus1SerialNum4;
    public TMP_InputField Surplus1SerialNum5;

    public TMP_InputField Surplus1Remarks1;
    public TMP_InputField Surplus1Remarks2;
    public TMP_InputField Surplus1Remarks3;
    public TMP_InputField Surplus1Remarks4;
    public TMP_InputField Surplus1Remarks5;

    // Input for Surplus parts page 2 :

    public TMP_InputField Surplus2Name1;
    public TMP_InputField Surplus2Name2;
    public TMP_InputField Surplus2Name3;
    public TMP_InputField Surplus2Name4;
    public TMP_InputField Surplus2Name5;

    public TMP_InputField Surplus2PartNum1;
    public TMP_InputField Surplus2PartNum2;
    public TMP_InputField Surplus2PartNum3;
    public TMP_InputField Surplus2PartNum4;
    public TMP_InputField Surplus2PartNum5;

    public TMP_InputField Surplus2SerialNum1;
    public TMP_InputField Surplus2SerialNum2;
    public TMP_InputField Surplus2SerialNum3;
    public TMP_InputField Surplus2SerialNum4;
    public TMP_InputField Surplus2SerialNum5;

    public TMP_InputField Surplus2Remarks1;
    public TMP_InputField Surplus2Remarks2;
    public TMP_InputField Surplus2Remarks3;
    public TMP_InputField Surplus2Remarks4;
    public TMP_InputField Surplus2Remarks5;

    // Input for Surplus parts page 3 :

    public TMP_InputField Surplus3Name1;
    public TMP_InputField Surplus3Name2;
    public TMP_InputField Surplus3Name3;
    public TMP_InputField Surplus3Name4;
    public TMP_InputField Surplus3Name5;

    public TMP_InputField Surplus3PartNum1;
    public TMP_InputField Surplus3PartNum2;
    public TMP_InputField Surplus3PartNum3;
    public TMP_InputField Surplus3PartNum4;
    public TMP_InputField Surplus3PartNum5;

    public TMP_InputField Surplus3SerialNum1;
    public TMP_InputField Surplus3SerialNum2;
    public TMP_InputField Surplus3SerialNum3;
    public TMP_InputField Surplus3SerialNum4;
    public TMP_InputField Surplus3SerialNum5;

    public TMP_InputField Surplus3Remarks1;
    public TMP_InputField Surplus3Remarks2;
    public TMP_InputField Surplus3Remarks3;
    public TMP_InputField Surplus3Remarks4;
    public TMP_InputField Surplus3Remarks5;

    // Input for Surplus parts page 4 :

    public TMP_InputField Surplus4Name1;
    public TMP_InputField Surplus4Name2;
    public TMP_InputField Surplus4Name3;
    public TMP_InputField Surplus4Name4;
    public TMP_InputField Surplus4Name5;

    public TMP_InputField Surplus4PartNum1;
    public TMP_InputField Surplus4PartNum2;
    public TMP_InputField Surplus4PartNum3;
    public TMP_InputField Surplus4PartNum4;
    public TMP_InputField Surplus4PartNum5;

    public TMP_InputField Surplus4SerialNum1;
    public TMP_InputField Surplus4SerialNum2;
    public TMP_InputField Surplus4SerialNum3;
    public TMP_InputField Surplus4SerialNum4;
    public TMP_InputField Surplus4SerialNum5;

    public TMP_InputField Surplus4Remarks1;
    public TMP_InputField Surplus4Remarks2;
    public TMP_InputField Surplus4Remarks3;
    public TMP_InputField Surplus4Remarks4;
    public TMP_InputField Surplus4Remarks5;

    // Input for Surplus parts page 5 :

    public TMP_InputField Surplus5Name1;
    public TMP_InputField Surplus5Name2;
    public TMP_InputField Surplus5Name3;
    public TMP_InputField Surplus5Name4;
    public TMP_InputField Surplus5Name5;

    public TMP_InputField Surplus5PartNum1;
    public TMP_InputField Surplus5PartNum2;
    public TMP_InputField Surplus5PartNum3;
    public TMP_InputField Surplus5PartNum4;
    public TMP_InputField Surplus5PartNum5;

    public TMP_InputField Surplus5SerialNum1;
    public TMP_InputField Surplus5SerialNum2;
    public TMP_InputField Surplus5SerialNum3;
    public TMP_InputField Surplus5SerialNum4;
    public TMP_InputField Surplus5SerialNum5;

    public TMP_InputField Surplus5Remarks1;
    public TMP_InputField Surplus5Remarks2;
    public TMP_InputField Surplus5Remarks3;
    public TMP_InputField Surplus5Remarks4;
    public TMP_InputField Surplus5Remarks5;

    // Input for Surplus parts page 6 :

    public TMP_InputField Surplus6Name1;
    public TMP_InputField Surplus6Name2;
    public TMP_InputField Surplus6Name3;
    public TMP_InputField Surplus6Name4;
    public TMP_InputField Surplus6Name5;

    public TMP_InputField Surplus6PartNum1;
    public TMP_InputField Surplus6PartNum2;
    public TMP_InputField Surplus6PartNum3;
    public TMP_InputField Surplus6PartNum4;
    public TMP_InputField Surplus6PartNum5;

    public TMP_InputField Surplus6SerialNum1;
    public TMP_InputField Surplus6SerialNum2;
    public TMP_InputField Surplus6SerialNum3;
    public TMP_InputField Surplus6SerialNum4;
    public TMP_InputField Surplus6SerialNum5;

    public TMP_InputField Surplus6Remarks1;
    public TMP_InputField Surplus6Remarks2;
    public TMP_InputField Surplus6Remarks3;
    public TMP_InputField Surplus6Remarks4;
    public TMP_InputField Surplus6Remarks5;



    // Start is called before the first frame update
    void Awake()
    {
        MissingPage1.SetActive(true);
        MissingPage2.SetActive(false);
        MissingPage3.SetActive(false);
        MissingPage4.SetActive(false);
        MissingPage5.SetActive(false);
        MissingPage6.SetActive(false);
        SurplusPage1.SetActive(false);
        SurplusPage2.SetActive(false);
        SurplusPage3.SetActive(false);
        SurplusPage4.SetActive(false);
        SurplusPage5.SetActive(false);
        SurplusPage6.SetActive(false);
        ConfirmPage.SetActive(false);
        ReviewPage1.SetActive(false);
        ReviewPage2.SetActive(false);
        ReviewPage3.SetActive(false);
        ReviewPage4.SetActive(false);
        ReviewPage5.SetActive(false);
        ReviewPage6.SetActive(false);
        ReviewPage7.SetActive(false);
        ReviewPage8.SetActive(false);
        ReviewPage9.SetActive(false);
        ReviewPage10.SetActive(false);
        ReviewPage11.SetActive(false);
        ReviewPage12.SetActive(false);
        ReviewPage13.SetActive(false);
        ReviewPage14.SetActive(false);
        ReviewPage15.SetActive(false);
        ReviewPage16.SetActive(false);
        ReviewPage17.SetActive(false);
        ReviewPage18.SetActive(false);
        ReviewPage19.SetActive(false);
        ReviewPage20.SetActive(false);
        ReviewPage21.SetActive(false);
        ReviewPage22.SetActive(false);
        SubmitPage.SetActive(false);
    }

    public void ReviewMissing1SaveText() // missing page 1
    {
        Missing1Name1.text = PlayerPrefs.GetString("Missing1Name" + 1);
        Missing1Name2.text = PlayerPrefs.GetString("Missing1Name" + 2);
        Missing1Name3.text = PlayerPrefs.GetString("Missing1Name" + 3);
        Missing1Name4.text = PlayerPrefs.GetString("Missing1Name" + 4);
        Missing1Name5.text = PlayerPrefs.GetString("Missing1Name" + 5);

        Missing1PartNum1.text = PlayerPrefs.GetString("Missing1PartNum" + 1);
        Missing1PartNum2.text = PlayerPrefs.GetString("Missing1PartNum" + 2);
        Missing1PartNum3.text = PlayerPrefs.GetString("Missing1PartNum" + 3);
        Missing1PartNum4.text = PlayerPrefs.GetString("Missing1PartNum" + 4);
        Missing1PartNum5.text = PlayerPrefs.GetString("Missing1PartNum" + 5);

        Missing1SerialNum1.text = PlayerPrefs.GetString("Missing1SerialNum" + 1);
        Missing1SerialNum2.text = PlayerPrefs.GetString("Missing1SerialNum" + 2);
        Missing1SerialNum3.text = PlayerPrefs.GetString("Missing1SerialNum" + 3);
        Missing1SerialNum4.text = PlayerPrefs.GetString("Missing1SerialNum" + 4);
        Missing1SerialNum5.text = PlayerPrefs.GetString("Missing1SerialNum" + 5);

        Missing1Remarks1.text = PlayerPrefs.GetString("Missing1Remarks" + 1);
        Missing1Remarks2.text = PlayerPrefs.GetString("Missing1Remarks" + 2);
        Missing1Remarks3.text = PlayerPrefs.GetString("Missing1Remarks" + 3);
        Missing1Remarks4.text = PlayerPrefs.GetString("Missing1Remarks" + 4);
        Missing1Remarks5.text = PlayerPrefs.GetString("Missing1Remarks" + 5);

        PlayerPrefs.Save();
    }

    public void ReviewMissing2SaveText() // misssing page 2
    {
        Missing2Name1.text = PlayerPrefs.GetString("Missing2Name" + 52);
        Missing2Name2.text = PlayerPrefs.GetString("Missing2Name" + 53);
        Missing2Name3.text = PlayerPrefs.GetString("Missing2Name" + 54);
        Missing2Name4.text = PlayerPrefs.GetString("Missing2Name" + 55);
        Missing2Name5.text = PlayerPrefs.GetString("Missing2Name" + 56);

        Missing2PartNum1.text = PlayerPrefs.GetString("Missing2PartNum" + 52);
        Missing2PartNum2.text = PlayerPrefs.GetString("Missing2PartNum" + 53);
        Missing2PartNum3.text = PlayerPrefs.GetString("Missing2PartNum" + 54);
        Missing2PartNum4.text = PlayerPrefs.GetString("Missing2PartNum" + 55);
        Missing2PartNum5.text = PlayerPrefs.GetString("Missing2PartNum" + 56);

        Missing2SerialNum1.text = PlayerPrefs.GetString("Missing2SerialNum" + 52);
        Missing2SerialNum2.text = PlayerPrefs.GetString("Missing2SerialNum" + 53);
        Missing2SerialNum3.text = PlayerPrefs.GetString("Missing2SerialNum" + 54);
        Missing2SerialNum4.text = PlayerPrefs.GetString("Missing2SerialNum" + 55);
        Missing2SerialNum5.text = PlayerPrefs.GetString("Missing2SerialNum" + 56);

        Missing2Remarks1.text = PlayerPrefs.GetString("Missing2Remarks" + 52);
        Missing2Remarks2.text = PlayerPrefs.GetString("Missing2Remarks" + 53);
        Missing2Remarks3.text = PlayerPrefs.GetString("Missing2Remarks" + 54);
        Missing2Remarks4.text = PlayerPrefs.GetString("Missing2Remarks" + 55);
        Missing2Remarks5.text = PlayerPrefs.GetString("Missing2Remarks" + 56);

        PlayerPrefs.Save();
    }

    public void ReviewMissing3SaveText() // missing page 3
    {
        Missing3Name1.text = PlayerPrefs.GetString("Missing3Name" + 54);
        Missing3Name2.text = PlayerPrefs.GetString("Missing3Name" + 55);
        Missing3Name3.text = PlayerPrefs.GetString("Missing3Name" + 56);
        Missing3Name4.text = PlayerPrefs.GetString("Missing3Name" + 57);
        Missing3Name5.text = PlayerPrefs.GetString("Missing3Name" + 58);

        Missing3PartNum1.text = PlayerPrefs.GetString("Missing3PartNum" + 54);
        Missing3PartNum2.text = PlayerPrefs.GetString("Missing3PartNum" + 55);
        Missing3PartNum3.text = PlayerPrefs.GetString("Missing3PartNum" + 56);
        Missing3PartNum4.text = PlayerPrefs.GetString("Missing3PartNum" + 57);
        Missing3PartNum5.text = PlayerPrefs.GetString("Missing3PartNum" + 58);

        Missing3SerialNum1.text = PlayerPrefs.GetString("Missing3SerialNum" + 54);
        Missing3SerialNum2.text = PlayerPrefs.GetString("Missing3SerialNum" + 55);
        Missing3SerialNum3.text = PlayerPrefs.GetString("Missing3SerialNum" + 56);
        Missing3SerialNum4.text = PlayerPrefs.GetString("Missing3SerialNum" + 57);
        Missing3SerialNum5.text = PlayerPrefs.GetString("Missing3SerialNum" + 58);

        Missing3Remarks1.text = PlayerPrefs.GetString("Missing3Remarks" + 54);
        Missing3Remarks2.text = PlayerPrefs.GetString("Missing3Remarks" + 55);
        Missing3Remarks3.text = PlayerPrefs.GetString("Missing3Remarks" + 56);
        Missing3Remarks4.text = PlayerPrefs.GetString("Missing3Remarks" + 57);
        Missing3Remarks5.text = PlayerPrefs.GetString("Missing3Remarks" + 58);

        PlayerPrefs.Save();
    }

    public void ReviewMissing4SaveText() // missing page 4
    {
        Missing4Name1.text = PlayerPrefs.GetString("Missing4Name" + 56);
        Missing4Name2.text = PlayerPrefs.GetString("Missing4Name" + 57);
        Missing4Name3.text = PlayerPrefs.GetString("Missing4Name" + 58);
        Missing4Name4.text = PlayerPrefs.GetString("Missing4Name" + 59);
        Missing4Name5.text = PlayerPrefs.GetString("Missing4Name" + 60);

        Missing4PartNum1.text = PlayerPrefs.GetString("Missing4PartNum" + 56);
        Missing4PartNum2.text = PlayerPrefs.GetString("Missing4PartNum" + 57);
        Missing4PartNum3.text = PlayerPrefs.GetString("Missing4PartNum" + 58);
        Missing4PartNum4.text = PlayerPrefs.GetString("Missing4PartNum" + 59);
        Missing4PartNum5.text = PlayerPrefs.GetString("Missing4PartNum" + 60);

        Missing4SerialNum1.text = PlayerPrefs.GetString("Missing4SerialNum" + 56);
        Missing4SerialNum2.text = PlayerPrefs.GetString("Missing4SerialNum" + 57);
        Missing4SerialNum3.text = PlayerPrefs.GetString("Missing4SerialNum" + 58);
        Missing4SerialNum4.text = PlayerPrefs.GetString("Missing4SerialNum" + 59);
        Missing4SerialNum5.text = PlayerPrefs.GetString("Missing4SerialNum" + 60);

        Missing4Remarks1.text = PlayerPrefs.GetString("Missing4Remarks" + 56);
        Missing4Remarks2.text = PlayerPrefs.GetString("Missing4Remarks" + 57);
        Missing4Remarks3.text = PlayerPrefs.GetString("Missing4Remarks" + 58);
        Missing4Remarks4.text = PlayerPrefs.GetString("Missing4Remarks" + 59);
        Missing4Remarks5.text = PlayerPrefs.GetString("Missing4Remarks" + 60);

        PlayerPrefs.Save();
    }

    public void ReviewMissing5SaveText() // missing page 5
    {
        Missing5Name1.text = PlayerPrefs.GetString("Missing5Name" + 58);
        Missing5Name2.text = PlayerPrefs.GetString("Missing5Name" + 59);
        Missing5Name3.text = PlayerPrefs.GetString("Missing5Name" + 60);
        Missing5Name4.text = PlayerPrefs.GetString("Missing5Name" + 61);
        Missing5Name5.text = PlayerPrefs.GetString("Missing5Name" + 62);

        Missing5PartNum1.text = PlayerPrefs.GetString("Missing5PartNum" + 58);
        Missing5PartNum2.text = PlayerPrefs.GetString("Missing5PartNum" + 59);
        Missing5PartNum3.text = PlayerPrefs.GetString("Missing5PartNum" + 60);
        Missing5PartNum4.text = PlayerPrefs.GetString("Missing5PartNum" + 61);
        Missing5PartNum5.text = PlayerPrefs.GetString("Missing5PartNum" + 62);

        Missing5SerialNum1.text = PlayerPrefs.GetString("Missing5SerialNum" + 58);
        Missing5SerialNum2.text = PlayerPrefs.GetString("Missing5SerialNum" + 59);
        Missing5SerialNum3.text = PlayerPrefs.GetString("Missing5SerialNum" + 60);
        Missing5SerialNum4.text = PlayerPrefs.GetString("Missing5SerialNum" + 61);
        Missing5SerialNum5.text = PlayerPrefs.GetString("Missing5SerialNum" + 62);

        Missing5Remarks1.text = PlayerPrefs.GetString("Missing5Remarks" + 58);
        Missing5Remarks2.text = PlayerPrefs.GetString("Missing5Remarks" + 59);
        Missing5Remarks3.text = PlayerPrefs.GetString("Missing5Remarks" + 60);
        Missing5Remarks4.text = PlayerPrefs.GetString("Missing5Remarks" + 61);
        Missing5Remarks5.text = PlayerPrefs.GetString("Missing5Remarks" + 62);

        PlayerPrefs.Save();
    }

    public void ReviewMissing6SaveText() // missing page 6
    {
        Missing6Name1.text = PlayerPrefs.GetString("Missing6Name" + 60);
        Missing6Name2.text = PlayerPrefs.GetString("Missing6Name" + 61);
        Missing6Name3.text = PlayerPrefs.GetString("Missing6Name" + 62);
        Missing6Name4.text = PlayerPrefs.GetString("Missing6Name" + 63);
        Missing6Name5.text = PlayerPrefs.GetString("Missing6Name" + 64);

        Missing6PartNum1.text = PlayerPrefs.GetString("Missing6PartNum" + 60);
        Missing6PartNum2.text = PlayerPrefs.GetString("Missing6PartNum" + 61);
        Missing6PartNum3.text = PlayerPrefs.GetString("Missing6PartNum" + 62);
        Missing6PartNum4.text = PlayerPrefs.GetString("Missing6PartNum" + 63);
        Missing6PartNum5.text = PlayerPrefs.GetString("Missing6PartNum" + 64);

        Missing6SerialNum1.text = PlayerPrefs.GetString("Missing6SerialNum" + 60);
        Missing6SerialNum2.text = PlayerPrefs.GetString("Missing6SerialNum" + 61);
        Missing6SerialNum3.text = PlayerPrefs.GetString("Missing6SerialNum" + 62);
        Missing6SerialNum4.text = PlayerPrefs.GetString("Missing6SerialNum" + 63);
        Missing6SerialNum5.text = PlayerPrefs.GetString("Missing6SerialNum" + 64);

        Missing6Remarks1.text = PlayerPrefs.GetString("Missing6Remarks" + 60);
        Missing6Remarks2.text = PlayerPrefs.GetString("Missing6Remarks" + 61);
        Missing6Remarks3.text = PlayerPrefs.GetString("Missing6Remarks" + 62);
        Missing6Remarks4.text = PlayerPrefs.GetString("Missing6Remarks" + 63);
        Missing6Remarks5.text = PlayerPrefs.GetString("Missing6Remarks" + 64);

        PlayerPrefs.Save();
    }

    public void SurplusSaveText1() // surplus page 1
    {
        Surplus1Name1.text = PlayerPrefs.GetString("Surplus1Name" + 50);
        Surplus1Name2.text = PlayerPrefs.GetString("Surplus1Name" + 51);
        Surplus1Name3.text = PlayerPrefs.GetString("Surplus1Name" + 52);
        Surplus1Name4.text = PlayerPrefs.GetString("Surplus1Name" + 53);
        Surplus1Name5.text = PlayerPrefs.GetString("Surplus1Name" + 54);

        Surplus1PartNum1.text = PlayerPrefs.GetString("Surplus1PartNum" + 50);
        Surplus1PartNum2.text = PlayerPrefs.GetString("Surplus1PartNum" + 51);
        Surplus1PartNum3.text = PlayerPrefs.GetString("Surplus1PartNum" + 52);
        Surplus1PartNum4.text = PlayerPrefs.GetString("Surplus1PartNum" + 53);
        Surplus1PartNum5.text = PlayerPrefs.GetString("Surplus1PartNum" + 54);

        Surplus1SerialNum1.text = PlayerPrefs.GetString("Surplus1SerialNum" + 50);
        Surplus1SerialNum2.text = PlayerPrefs.GetString("Surplus1SerialNum" + 51);
        Surplus1SerialNum3.text = PlayerPrefs.GetString("Surplus1SerialNum" + 52);
        Surplus1SerialNum4.text = PlayerPrefs.GetString("Surplus1SerialNum" + 53);
        Surplus1SerialNum5.text = PlayerPrefs.GetString("Surplus1SerialNum" + 54);

        Surplus1Remarks1.text = PlayerPrefs.GetString("Surplus1Remarks" + 50);
        Surplus1Remarks2.text = PlayerPrefs.GetString("Surplus1Remarks" + 51);
        Surplus1Remarks3.text = PlayerPrefs.GetString("Surplus1Remarks" + 52);
        Surplus1Remarks4.text = PlayerPrefs.GetString("Surplus1Remarks" + 53);
        Surplus1Remarks5.text = PlayerPrefs.GetString("Surplus1Remarks" + 54);

        PlayerPrefs.Save();
    }

    public void Surplus2SaveText()
    {
        Surplus2Name1.text = PlayerPrefs.GetString("Surplus2Name" + 62);
        Surplus2Name2.text = PlayerPrefs.GetString("Surplus2Name" + 63);
        Surplus2Name3.text = PlayerPrefs.GetString("Surplus2Name" + 64);
        Surplus2Name4.text = PlayerPrefs.GetString("Surplus2Name" + 65);
        Surplus2Name5.text = PlayerPrefs.GetString("Surplus2Name" + 66);

        Surplus2PartNum1.text = PlayerPrefs.GetString("Surplus2PartNum" + 62);
        Surplus2PartNum2.text = PlayerPrefs.GetString("Surplus2PartNum" + 63);
        Surplus2PartNum3.text = PlayerPrefs.GetString("Surplus2PartNum" + 64);
        Surplus2PartNum4.text = PlayerPrefs.GetString("Surplus2PartNum" + 65);
        Surplus2PartNum5.text = PlayerPrefs.GetString("Surplus2PartNum" + 66);

        Surplus2SerialNum1.text = PlayerPrefs.GetString("Surplus2SerialNum" + 62);
        Surplus2SerialNum2.text = PlayerPrefs.GetString("Surplus2SerialNum" + 63);
        Surplus2SerialNum3.text = PlayerPrefs.GetString("Surplus2SerialNum" + 64);
        Surplus2SerialNum4.text = PlayerPrefs.GetString("Surplus2SerialNum" + 65);
        Surplus2SerialNum5.text = PlayerPrefs.GetString("Surplus2SerialNum" + 66);

        Surplus2Remarks1.text = PlayerPrefs.GetString("Surplus2Remarks" + 62);
        Surplus2Remarks2.text = PlayerPrefs.GetString("Surplus2Remarks" + 63);
        Surplus2Remarks3.text = PlayerPrefs.GetString("Surplus2Remarks" + 64);
        Surplus2Remarks4.text = PlayerPrefs.GetString("Surplus2Remarks" + 65);
        Surplus2Remarks5.text = PlayerPrefs.GetString("Surplus2Remarks" + 66);

        PlayerPrefs.Save();
    }

    public void Surplus3SaveText()
    {
        Surplus3Name1.text = PlayerPrefs.GetString("Surplus3Name" + 64);
        Surplus3Name2.text = PlayerPrefs.GetString("Surplus3Name" + 65);
        Surplus3Name3.text = PlayerPrefs.GetString("Surplus3Name" + 66);
        Surplus3Name4.text = PlayerPrefs.GetString("Surplus3Name" + 67);
        Surplus3Name5.text = PlayerPrefs.GetString("Surplus3Name" + 68);

        Surplus3PartNum1.text = PlayerPrefs.GetString("Surplus3PartNum" + 64);
        Surplus3PartNum2.text = PlayerPrefs.GetString("Surplus3PartNum" + 65);
        Surplus3PartNum3.text = PlayerPrefs.GetString("Surplus3PartNum" + 66);
        Surplus3PartNum4.text = PlayerPrefs.GetString("Surplus3PartNum" + 67);
        Surplus3PartNum5.text = PlayerPrefs.GetString("Surplus3PartNum" + 68);

        Surplus3SerialNum1.text = PlayerPrefs.GetString("Surplus3SerialNum" + 64);
        Surplus3SerialNum2.text = PlayerPrefs.GetString("Surplus3SerialNum" + 65);
        Surplus3SerialNum3.text = PlayerPrefs.GetString("Surplus3SerialNum" + 66);
        Surplus3SerialNum4.text = PlayerPrefs.GetString("Surplus3SerialNum" + 67);
        Surplus3SerialNum5.text = PlayerPrefs.GetString("Surplus3SerialNum" + 68);

        Surplus3Remarks1.text = PlayerPrefs.GetString("Surplus3Remarks" + 64);
        Surplus3Remarks2.text = PlayerPrefs.GetString("Surplus3Remarks" + 65);
        Surplus3Remarks3.text = PlayerPrefs.GetString("Surplus3Remarks" + 66);
        Surplus3Remarks4.text = PlayerPrefs.GetString("Surplus3Remarks" + 67);
        Surplus3Remarks5.text = PlayerPrefs.GetString("Surplus3Remarks" + 68);

        PlayerPrefs.Save();
    }

    public void Surplus4SaveText()
    {
        Surplus4Name1.text = PlayerPrefs.GetString("Surplus4Name" + 66);
        Surplus4Name2.text = PlayerPrefs.GetString("Surplus4Name" + 67);
        Surplus4Name3.text = PlayerPrefs.GetString("Surplus4Name" + 68);
        Surplus4Name4.text = PlayerPrefs.GetString("Surplus4Name" + 69);
        Surplus4Name5.text = PlayerPrefs.GetString("Surplus4Name" + 70);

        Surplus4PartNum1.text = PlayerPrefs.GetString("Surplus4PartNum" + 66);
        Surplus4PartNum2.text = PlayerPrefs.GetString("Surplus4PartNum" + 67);
        Surplus4PartNum3.text = PlayerPrefs.GetString("Surplus4PartNum" + 68);
        Surplus4PartNum4.text = PlayerPrefs.GetString("Surplus4PartNum" + 69);
        Surplus4PartNum5.text = PlayerPrefs.GetString("Surplus4PartNum" + 70);

        Surplus4SerialNum1.text = PlayerPrefs.GetString("Surplus4SerialNum" + 66);
        Surplus4SerialNum2.text = PlayerPrefs.GetString("Surplus4SerialNum" + 67);
        Surplus4SerialNum3.text = PlayerPrefs.GetString("Surplus4SerialNum" + 68);
        Surplus4SerialNum4.text = PlayerPrefs.GetString("Surplus4SerialNum" + 69);
        Surplus4SerialNum5.text = PlayerPrefs.GetString("Surplus4SerialNum" + 70);

        Surplus4Remarks1.text = PlayerPrefs.GetString("Surplus4Remarks" + 66);
        Surplus4Remarks2.text = PlayerPrefs.GetString("Surplus4Remarks" + 67);
        Surplus4Remarks3.text = PlayerPrefs.GetString("Surplus4Remarks" + 68);
        Surplus4Remarks4.text = PlayerPrefs.GetString("Surplus4Remarks" + 69);
        Surplus4Remarks5.text = PlayerPrefs.GetString("Surplus4Remarks" + 70);

        PlayerPrefs.Save();
    }

    public void Surplus5SaveText()
    {
        Surplus5Name1.text = PlayerPrefs.GetString("Surplus5Name" + 68);
        Surplus5Name2.text = PlayerPrefs.GetString("Surplus5Name" + 69);
        Surplus5Name3.text = PlayerPrefs.GetString("Surplus5Name" + 70);
        Surplus5Name4.text = PlayerPrefs.GetString("Surplus5Name" + 71);
        Surplus5Name5.text = PlayerPrefs.GetString("Surplus5Name" + 72);

        Surplus5PartNum1.text = PlayerPrefs.GetString("Surplus5PartNum" + 68);
        Surplus5PartNum2.text = PlayerPrefs.GetString("Surplus5PartNum" + 69);
        Surplus5PartNum3.text = PlayerPrefs.GetString("Surplus5PartNum" + 70);
        Surplus5PartNum4.text = PlayerPrefs.GetString("Surplus5PartNum" + 71);
        Surplus5PartNum5.text = PlayerPrefs.GetString("Surplus5PartNum" + 72);

        Surplus5SerialNum1.text = PlayerPrefs.GetString("Surplus5SerialNum" + 68);
        Surplus5SerialNum2.text = PlayerPrefs.GetString("Surplus5SerialNum" + 69);
        Surplus5SerialNum3.text = PlayerPrefs.GetString("Surplus5SerialNum" + 70);
        Surplus5SerialNum4.text = PlayerPrefs.GetString("Surplus5SerialNum" + 71);
        Surplus5SerialNum5.text = PlayerPrefs.GetString("Surplus5SerialNum" + 72);

        Surplus5Remarks1.text = PlayerPrefs.GetString("Surplus5Remarks" + 68);
        Surplus5Remarks2.text = PlayerPrefs.GetString("Surplus5Remarks" + 69);
        Surplus5Remarks3.text = PlayerPrefs.GetString("Surplus5Remarks" + 70);
        Surplus5Remarks4.text = PlayerPrefs.GetString("Surplus5Remarks" + 71);
        Surplus5Remarks5.text = PlayerPrefs.GetString("Surplus5Remarks" + 72);

        PlayerPrefs.Save();
    }

    public void Surplus6SaveText()
    {
        Surplus6Name1.text = PlayerPrefs.GetString("Surplus6Name" + 70);
        Surplus6Name2.text = PlayerPrefs.GetString("Surplus6Name" + 71);
        Surplus6Name3.text = PlayerPrefs.GetString("Surplus6Name" + 72);
        Surplus6Name4.text = PlayerPrefs.GetString("Surplus6Name" + 73);
        Surplus6Name5.text = PlayerPrefs.GetString("Surplus6Name" + 74);

        Surplus6PartNum1.text = PlayerPrefs.GetString("Surplus6PartNum" + 70);
        Surplus6PartNum2.text = PlayerPrefs.GetString("Surplus6PartNum" + 71);
        Surplus6PartNum3.text = PlayerPrefs.GetString("Surplus6PartNum" + 72);
        Surplus6PartNum4.text = PlayerPrefs.GetString("Surplus6PartNum" + 73);
        Surplus6PartNum5.text = PlayerPrefs.GetString("Surplus6PartNum" + 74);

        Surplus6SerialNum1.text = PlayerPrefs.GetString("Surplus6SerialNum" + 70);
        Surplus6SerialNum2.text = PlayerPrefs.GetString("Surplus6SerialNum" + 71);
        Surplus6SerialNum3.text = PlayerPrefs.GetString("Surplus6SerialNum" + 72);
        Surplus6SerialNum4.text = PlayerPrefs.GetString("Surplus6SerialNum" + 73);
        Surplus6SerialNum5.text = PlayerPrefs.GetString("Surplus6SerialNum" + 74);

        Surplus6Remarks1.text = PlayerPrefs.GetString("Surplus6Remarks" + 70);
        Surplus6Remarks2.text = PlayerPrefs.GetString("Surplus6Remarks" + 71);
        Surplus6Remarks3.text = PlayerPrefs.GetString("Surplus6Remarks" + 72);
        Surplus6Remarks4.text = PlayerPrefs.GetString("Surplus6Remarks" + 73);
        Surplus6Remarks5.text = PlayerPrefs.GetString("Surplus6Remarks" + 74);

        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void missingPage1()
    {

        PlayerPrefs.SetString("Missing1Name" + 1, Missing1Name1.text);
        PlayerPrefs.SetString("Missing1Name" + 2, Missing1Name2.text);
        PlayerPrefs.SetString("Missing1Name" + 3, Missing1Name3.text);
        PlayerPrefs.SetString("Missing1Name" + 4, Missing1Name4.text);
        PlayerPrefs.SetString("Missing1Name" + 5, Missing1Name5.text);

        PlayerPrefs.SetString("Missing1PartNum" + 1, Missing1PartNum1.text);
        PlayerPrefs.SetString("Missing1PartNum" + 2, Missing1PartNum2.text);
        PlayerPrefs.SetString("Missing1PartNum" + 3, Missing1PartNum3.text);
        PlayerPrefs.SetString("Missing1PartNum" + 4, Missing1PartNum4.text);
        PlayerPrefs.SetString("Missing1PartNum" + 5, Missing1PartNum5.text);

        PlayerPrefs.SetString("Missing1SerialNum" + 1, Missing1SerialNum1.text);
        PlayerPrefs.SetString("Missing1SerialNum" + 2, Missing1SerialNum2.text);
        PlayerPrefs.SetString("Missing1SerialNum" + 3, Missing1SerialNum3.text);
        PlayerPrefs.SetString("Missing1SerialNum" + 4, Missing1SerialNum4.text);
        PlayerPrefs.SetString("Missing1SerialNum" + 5, Missing1SerialNum5.text);

        PlayerPrefs.SetString("Missing1Remarks" + 1, Missing1Remarks1.text);
        PlayerPrefs.SetString("Missing1Remarks" + 2, Missing1Remarks2.text);
        PlayerPrefs.SetString("Missing1Remarks" + 3, Missing1Remarks3.text);
        PlayerPrefs.SetString("Missing1Remarks" + 4, Missing1Remarks4.text);
        PlayerPrefs.SetString("Missing1Remarks" + 5, Missing1Remarks5.text);

        PlayerPrefs.Save();

        Debug.Log("Set missing items 1");
    }

    public void missingPage2()
    {

        PlayerPrefs.SetString("Missing2Name" + 52, Missing2Name1.text);
        PlayerPrefs.SetString("Missing2Name" + 53, Missing2Name2.text);
        PlayerPrefs.SetString("Missing2Name" + 54, Missing2Name3.text);
        PlayerPrefs.SetString("Missing2Name" + 55, Missing2Name4.text);
        PlayerPrefs.SetString("Missing2Name" + 56, Missing2Name5.text);

        PlayerPrefs.SetString("Missing2PartNum" + 52, Missing2PartNum1.text);
        PlayerPrefs.SetString("Missing2PartNum" + 53, Missing2PartNum2.text);
        PlayerPrefs.SetString("Missing2PartNum" + 54, Missing2PartNum3.text);
        PlayerPrefs.SetString("Missing2PartNum" + 55, Missing2PartNum4.text);
        PlayerPrefs.SetString("Missing2PartNum" + 56, Missing2PartNum5.text);

        PlayerPrefs.SetString("Missing2SerialNum" + 52, Missing2SerialNum1.text);
        PlayerPrefs.SetString("Missing2SerialNum" + 53, Missing2SerialNum2.text);
        PlayerPrefs.SetString("Missing2SerialNum" + 54, Missing2SerialNum3.text);
        PlayerPrefs.SetString("Missing2SerialNum" + 55, Missing2SerialNum4.text);
        PlayerPrefs.SetString("Missing2SerialNum" + 56, Missing2SerialNum5.text);

        PlayerPrefs.SetString("Missing2Remarks" + 52, Missing2Remarks1.text);
        PlayerPrefs.SetString("Missing2Remarks" + 53, Missing2Remarks2.text);
        PlayerPrefs.SetString("Missing2Remarks" + 54, Missing2Remarks3.text);
        PlayerPrefs.SetString("Missing2Remarks" + 55, Missing2Remarks4.text);
        PlayerPrefs.SetString("Missing2Remarks" + 56, Missing2Remarks5.text);

        PlayerPrefs.Save();

        Debug.Log("Set missing items 2");
    }

    public void missingPage3()
    {

        PlayerPrefs.SetString("Missing3Name" + 54, Missing3Name1.text);
        PlayerPrefs.SetString("Missing3Name" + 55, Missing3Name2.text);
        PlayerPrefs.SetString("Missing3Name" + 56, Missing3Name3.text);
        PlayerPrefs.SetString("Missing3Name" + 57, Missing3Name4.text);
        PlayerPrefs.SetString("Missing3Name" + 58, Missing3Name5.text);

        PlayerPrefs.SetString("Missing3PartNum" + 54, Missing3PartNum1.text);
        PlayerPrefs.SetString("Missing3PartNum" + 55, Missing3PartNum2.text);
        PlayerPrefs.SetString("Missing3PartNum" + 56, Missing3PartNum3.text);
        PlayerPrefs.SetString("Missing3PartNum" + 57, Missing3PartNum4.text);
        PlayerPrefs.SetString("Missing3PartNum" + 58, Missing3PartNum5.text);

        PlayerPrefs.SetString("Missing3SerialNum" + 54, Missing3SerialNum1.text);
        PlayerPrefs.SetString("Missing3SerialNum" + 55, Missing3SerialNum2.text);
        PlayerPrefs.SetString("Missing3SerialNum" + 56, Missing3SerialNum3.text);
        PlayerPrefs.SetString("Missing3SerialNum" + 57, Missing3SerialNum4.text);
        PlayerPrefs.SetString("Missing3SerialNum" + 58, Missing3SerialNum5.text);

        PlayerPrefs.SetString("Missing3Remarks" + 54, Missing3Remarks1.text);
        PlayerPrefs.SetString("Missing3Remarks" + 55, Missing3Remarks2.text);
        PlayerPrefs.SetString("Missing3Remarks" + 56, Missing3Remarks3.text);
        PlayerPrefs.SetString("Missing3Remarks" + 57, Missing3Remarks4.text);
        PlayerPrefs.SetString("Missing3Remarks" + 58, Missing3Remarks5.text);

        PlayerPrefs.Save();

        Debug.Log("Set missing items 3");
    }

    public void missingPage4()
    {

        PlayerPrefs.SetString("Missing4Name" + 56, Missing4Name1.text);
        PlayerPrefs.SetString("Missing4Name" + 57, Missing4Name2.text);
        PlayerPrefs.SetString("Missing4Name" + 58, Missing4Name3.text);
        PlayerPrefs.SetString("Missing4Name" + 59, Missing4Name4.text);
        PlayerPrefs.SetString("Missing4Name" + 60, Missing4Name5.text);

        PlayerPrefs.SetString("Missing4PartNum" + 56, Missing4PartNum1.text);
        PlayerPrefs.SetString("Missing4PartNum" + 57, Missing4PartNum2.text);
        PlayerPrefs.SetString("Missing4PartNum" + 58, Missing4PartNum3.text);
        PlayerPrefs.SetString("Missing4PartNum" + 59, Missing4PartNum4.text);
        PlayerPrefs.SetString("Missing4PartNum" + 60, Missing4PartNum5.text);

        PlayerPrefs.SetString("Missing4SerialNum" + 56, Missing4SerialNum1.text);
        PlayerPrefs.SetString("Missing4SerialNum" + 57, Missing4SerialNum2.text);
        PlayerPrefs.SetString("Missing4SerialNum" + 58, Missing4SerialNum3.text);
        PlayerPrefs.SetString("Missing4SerialNum" + 59, Missing4SerialNum4.text);
        PlayerPrefs.SetString("Missing4SerialNum" + 60, Missing4SerialNum5.text);

        PlayerPrefs.SetString("Missing4Remarks" + 56, Missing4Remarks1.text);
        PlayerPrefs.SetString("Missing4Remarks" + 57, Missing4Remarks2.text);
        PlayerPrefs.SetString("Missing4Remarks" + 58, Missing4Remarks3.text);
        PlayerPrefs.SetString("Missing4Remarks" + 59, Missing4Remarks4.text);
        PlayerPrefs.SetString("Missing4Remarks" + 60, Missing4Remarks5.text);

        PlayerPrefs.Save();

        Debug.Log("Set missing items 4");
    }

    public void missingPage5()
    {

        PlayerPrefs.SetString("Missing5Name" + 58, Missing5Name1.text);
        PlayerPrefs.SetString("Missing5Name" + 59, Missing5Name2.text);
        PlayerPrefs.SetString("Missing5Name" + 60, Missing5Name3.text);
        PlayerPrefs.SetString("Missing5Name" + 61, Missing5Name4.text);
        PlayerPrefs.SetString("Missing5Name" + 62, Missing5Name5.text);

        PlayerPrefs.SetString("Missing5PartNum" + 58, Missing5PartNum1.text);
        PlayerPrefs.SetString("Missing5PartNum" + 59, Missing5PartNum2.text);
        PlayerPrefs.SetString("Missing5PartNum" + 60, Missing5PartNum3.text);
        PlayerPrefs.SetString("Missing5PartNum" + 61, Missing5PartNum4.text);
        PlayerPrefs.SetString("Missing5PartNum" + 62, Missing5PartNum5.text);

        PlayerPrefs.SetString("Missing5SerialNum" + 58, Missing5SerialNum1.text);
        PlayerPrefs.SetString("Missing5SerialNum" + 59, Missing5SerialNum2.text);
        PlayerPrefs.SetString("Missing5SerialNum" + 60, Missing5SerialNum3.text);
        PlayerPrefs.SetString("Missing5SerialNum" + 61, Missing5SerialNum4.text);
        PlayerPrefs.SetString("Missing5SerialNum" + 62, Missing5SerialNum5.text);

        PlayerPrefs.SetString("Missing5Remarks" + 58, Missing5Remarks1.text);
        PlayerPrefs.SetString("Missing5Remarks" + 59, Missing5Remarks2.text);
        PlayerPrefs.SetString("Missing5Remarks" + 60, Missing5Remarks3.text);
        PlayerPrefs.SetString("Missing5Remarks" + 61, Missing5Remarks4.text);
        PlayerPrefs.SetString("Missing5Remarks" + 62, Missing5Remarks5.text);

        PlayerPrefs.Save();

        Debug.Log("Set missing items 5");
    }

    public void missingPage6()
    {

        PlayerPrefs.SetString("Missing6Name" + 60, Missing6Name1.text);
        PlayerPrefs.SetString("Missing6Name" + 61, Missing6Name2.text);
        PlayerPrefs.SetString("Missing6Name" + 62, Missing6Name3.text);
        PlayerPrefs.SetString("Missing6Name" + 63, Missing6Name4.text);
        PlayerPrefs.SetString("Missing6Name" + 64, Missing6Name5.text);

        PlayerPrefs.SetString("Missing6PartNum" + 60, Missing6PartNum1.text);
        PlayerPrefs.SetString("Missing6PartNum" + 61, Missing6PartNum2.text);
        PlayerPrefs.SetString("Missing6PartNum" + 62, Missing6PartNum3.text);
        PlayerPrefs.SetString("Missing6PartNum" + 63, Missing6PartNum4.text);
        PlayerPrefs.SetString("Missing6PartNum" + 64, Missing6PartNum5.text);

        PlayerPrefs.SetString("Missing6SerialNum" + 60, Missing6SerialNum1.text);
        PlayerPrefs.SetString("Missing6SerialNum" + 61, Missing6SerialNum2.text);
        PlayerPrefs.SetString("Missing6SerialNum" + 62, Missing6SerialNum3.text);
        PlayerPrefs.SetString("Missing6SerialNum" + 63, Missing6SerialNum4.text);
        PlayerPrefs.SetString("Missing6SerialNum" + 64, Missing6SerialNum5.text);

        PlayerPrefs.SetString("Missing6Remarks" + 60, Missing6Remarks1.text);
        PlayerPrefs.SetString("Missing6Remarks" + 61, Missing6Remarks2.text);
        PlayerPrefs.SetString("Missing6Remarks" + 62, Missing6Remarks3.text);
        PlayerPrefs.SetString("Missing6Remarks" + 63, Missing6Remarks4.text);
        PlayerPrefs.SetString("Missing6Remarks" + 64, Missing6Remarks5.text);

        PlayerPrefs.Save();

        Debug.Log("Set missing items 6");
    }

    public void surpluspage1()
    {
         
        PlayerPrefs.SetString("Surplus1Name" + 50, Surplus1Name1.text);
        PlayerPrefs.SetString("Surplus1Name" + 51, Surplus1Name2.text);
        PlayerPrefs.SetString("Surplus1Name" + 52, Surplus1Name3.text);
        PlayerPrefs.SetString("Surplus1Name" + 53, Surplus1Name4.text);
        PlayerPrefs.SetString("Surplus1Name" + 54, Surplus1Name5.text);

        PlayerPrefs.SetString("Surplus1PartNum" + 50, Surplus1PartNum1.text);
        PlayerPrefs.SetString("Surplus1PartNum" + 51, Surplus1PartNum2.text);
        PlayerPrefs.SetString("Surplus1PartNum" + 52, Surplus1PartNum3.text);
        PlayerPrefs.SetString("Surplus1PartNum" + 53, Surplus1PartNum4.text);
        PlayerPrefs.SetString("Surplus1PartNum" + 54, Surplus1PartNum5.text);

        PlayerPrefs.SetString("Surplus1SerialNum" + 50, Surplus1SerialNum1.text);
        PlayerPrefs.SetString("Surplus1SerialNum" + 51, Surplus1SerialNum2.text);
        PlayerPrefs.SetString("Surplus1SerialNum" + 52, Surplus1SerialNum3.text);
        PlayerPrefs.SetString("Surplus1SerialNum" + 53, Surplus1SerialNum4.text);
        PlayerPrefs.SetString("Surplus1SerialNum" + 54, Surplus1SerialNum5.text);

        PlayerPrefs.SetString("Surplus1Remarks" + 50, Surplus1Remarks1.text);
        PlayerPrefs.SetString("Surplus1Remarks" + 51, Surplus1Remarks2.text);
        PlayerPrefs.SetString("Surplus1Remarks" + 52, Surplus1Remarks3.text);
        PlayerPrefs.SetString("Surplus1Remarks" + 53, Surplus1Remarks4.text);
        PlayerPrefs.SetString("Surplus1Remarks" + 54, Surplus1Remarks5.text);

        PlayerPrefs.Save();

        Debug.Log("Set surplus items 1");

    }

    public void surpluspage2()
    {

        PlayerPrefs.SetString("Surplus2Name" + 62, Surplus2Name1.text);
        PlayerPrefs.SetString("Surplus2Name" + 63, Surplus2Name2.text);
        PlayerPrefs.SetString("Surplus2Name" + 64, Surplus2Name3.text);
        PlayerPrefs.SetString("Surplus2Name" + 65, Surplus2Name4.text);
        PlayerPrefs.SetString("Surplus2Name" + 66, Surplus2Name5.text);

        PlayerPrefs.SetString("Surplus2PartNum" + 62, Surplus2PartNum1.text);
        PlayerPrefs.SetString("Surplus2PartNum" + 63, Surplus2PartNum2.text);
        PlayerPrefs.SetString("Surplus2PartNum" + 64, Surplus2PartNum3.text);
        PlayerPrefs.SetString("Surplus2PartNum" + 65, Surplus2PartNum4.text);
        PlayerPrefs.SetString("Surplus2PartNum" + 66, Surplus2PartNum5.text);

        PlayerPrefs.SetString("Surplus2SerialNum" + 62, Surplus2SerialNum1.text);
        PlayerPrefs.SetString("Surplus2SerialNum" + 63, Surplus2SerialNum2.text);
        PlayerPrefs.SetString("Surplus2SerialNum" + 64, Surplus2SerialNum3.text);
        PlayerPrefs.SetString("Surplus2SerialNum" + 65, Surplus2SerialNum4.text);
        PlayerPrefs.SetString("Surplus2SerialNum" + 66, Surplus2SerialNum5.text);

        PlayerPrefs.SetString("Surplus2Remarks" + 62, Surplus2Remarks1.text);
        PlayerPrefs.SetString("Surplus2Remarks" + 63, Surplus2Remarks2.text);
        PlayerPrefs.SetString("Surplus2Remarks" + 64, Surplus2Remarks3.text);
        PlayerPrefs.SetString("Surplus2Remarks" + 65, Surplus2Remarks4.text);
        PlayerPrefs.SetString("Surplus2Remarks" + 66, Surplus2Remarks5.text);

        PlayerPrefs.Save();

        Debug.Log("Set surplus items 2");

    }

    public void surpluspage3()
    {

        PlayerPrefs.SetString("Surplus3Name" + 64, Surplus3Name1.text);
        PlayerPrefs.SetString("Surplus3Name" + 65, Surplus3Name2.text);
        PlayerPrefs.SetString("Surplus3Name" + 66, Surplus3Name3.text);
        PlayerPrefs.SetString("Surplus3Name" + 67, Surplus3Name4.text);
        PlayerPrefs.SetString("Surplus3Name" + 68, Surplus3Name5.text);

        PlayerPrefs.SetString("Surplus3PartNum" + 64, Surplus3PartNum1.text);
        PlayerPrefs.SetString("Surplus3PartNum" + 65, Surplus3PartNum2.text);
        PlayerPrefs.SetString("Surplus3PartNum" + 66, Surplus3PartNum3.text);
        PlayerPrefs.SetString("Surplus3PartNum" + 67, Surplus3PartNum4.text);
        PlayerPrefs.SetString("Surplus3PartNum" + 68, Surplus3PartNum5.text);

        PlayerPrefs.SetString("Surplus3SerialNum" + 64, Surplus3SerialNum1.text);
        PlayerPrefs.SetString("Surplus3SerialNum" + 65, Surplus3SerialNum2.text);
        PlayerPrefs.SetString("Surplus3SerialNum" + 66, Surplus3SerialNum3.text);
        PlayerPrefs.SetString("Surplus3SerialNum" + 67, Surplus3SerialNum4.text);
        PlayerPrefs.SetString("Surplus3SerialNum" + 68, Surplus3SerialNum5.text);

        PlayerPrefs.SetString("Surplus3Remarks" + 64, Surplus3Remarks1.text);
        PlayerPrefs.SetString("Surplus3Remarks" + 65, Surplus3Remarks2.text);
        PlayerPrefs.SetString("Surplus3Remarks" + 66, Surplus3Remarks3.text);
        PlayerPrefs.SetString("Surplus3Remarks" + 67, Surplus3Remarks4.text);
        PlayerPrefs.SetString("Surplus3Remarks" + 68, Surplus3Remarks5.text);

        PlayerPrefs.Save();

        Debug.Log("Set surplus items 3");

    }

    public void surpluspage4() //User input for Surplus items
    {

        PlayerPrefs.SetString("Surplus4Name" + 66, Surplus4Name1.text);
        PlayerPrefs.SetString("Surplus4Name" + 67, Surplus4Name2.text);
        PlayerPrefs.SetString("Surplus4Name" + 68, Surplus4Name3.text);
        PlayerPrefs.SetString("Surplus4Name" + 69, Surplus4Name4.text);
        PlayerPrefs.SetString("Surplus4Name" + 70, Surplus4Name5.text);

        PlayerPrefs.SetString("Surplus4PartNum" + 66, Surplus4PartNum1.text);
        PlayerPrefs.SetString("Surplus4PartNum" + 67, Surplus4PartNum2.text);
        PlayerPrefs.SetString("Surplus4PartNum" + 68, Surplus4PartNum3.text);
        PlayerPrefs.SetString("Surplus4PartNum" + 69, Surplus4PartNum4.text);
        PlayerPrefs.SetString("Surplus4PartNum" + 70, Surplus4PartNum5.text);

        PlayerPrefs.SetString("Surplus4SerialNum" + 66, Surplus4SerialNum1.text);
        PlayerPrefs.SetString("Surplus4SerialNum" + 67, Surplus4SerialNum2.text);
        PlayerPrefs.SetString("Surplus4SerialNum" + 68, Surplus4SerialNum3.text);
        PlayerPrefs.SetString("Surplus4SerialNum" + 69, Surplus4SerialNum4.text);
        PlayerPrefs.SetString("Surplus4SerialNum" + 70, Surplus4SerialNum5.text);

        PlayerPrefs.SetString("Surplus4Remarks" + 66, Surplus4Remarks1.text);
        PlayerPrefs.SetString("Surplus4Remarks" + 67, Surplus4Remarks2.text);
        PlayerPrefs.SetString("Surplus4Remarks" + 68, Surplus4Remarks3.text);
        PlayerPrefs.SetString("Surplus4Remarks" + 69, Surplus4Remarks4.text);
        PlayerPrefs.SetString("Surplus4Remarks" + 70, Surplus4Remarks5.text);

        PlayerPrefs.Save();

        Debug.Log("Set surplus items 4");

    }

    public void surpluspage5() //User input for Surplus items
    {

        PlayerPrefs.SetString("Surplus5Name" + 68, Surplus5Name1.text);
        PlayerPrefs.SetString("Surplus5Name" + 69, Surplus5Name2.text);
        PlayerPrefs.SetString("Surplus5Name" + 70, Surplus5Name3.text);
        PlayerPrefs.SetString("Surplus5Name" + 71, Surplus5Name4.text);
        PlayerPrefs.SetString("Surplus5Name" + 72, Surplus5Name5.text);

        PlayerPrefs.SetString("Surplus5PartNum" + 68, Surplus5PartNum1.text);
        PlayerPrefs.SetString("Surplus5PartNum" + 69, Surplus5PartNum2.text);
        PlayerPrefs.SetString("Surplus5PartNum" + 70, Surplus5PartNum3.text);
        PlayerPrefs.SetString("Surplus5PartNum" + 71, Surplus5PartNum4.text);
        PlayerPrefs.SetString("Surplus5PartNum" + 72, Surplus5PartNum5.text);

        PlayerPrefs.SetString("Surplus5SerialNum" + 68, Surplus5SerialNum1.text);
        PlayerPrefs.SetString("Surplus5SerialNum" + 69, Surplus5SerialNum2.text);
        PlayerPrefs.SetString("Surplus5SerialNum" + 70, Surplus5SerialNum3.text);
        PlayerPrefs.SetString("Surplus5SerialNum" + 71, Surplus5SerialNum4.text);
        PlayerPrefs.SetString("Surplus5SerialNum" + 72, Surplus5SerialNum5.text);

        PlayerPrefs.SetString("Surplus5Remarks" + 68, Surplus5Remarks1.text);
        PlayerPrefs.SetString("Surplus5Remarks" + 69, Surplus5Remarks2.text);
        PlayerPrefs.SetString("Surplus5Remarks" + 70, Surplus5Remarks3.text);
        PlayerPrefs.SetString("Surplus5Remarks" + 71, Surplus5Remarks4.text);
        PlayerPrefs.SetString("Surplus5Remarks" + 72, Surplus5Remarks5.text);

        PlayerPrefs.Save();

        Debug.Log("Set surplus items 5");

    }

    public void surpluspage6() //User input for Surplus items
    {

        PlayerPrefs.SetString("Surplus6Name" + 70, Surplus6Name1.text);
        PlayerPrefs.SetString("Surplus6Name" + 71, Surplus6Name2.text);
        PlayerPrefs.SetString("Surplus6Name" + 72, Surplus6Name3.text);
        PlayerPrefs.SetString("Surplus6Name" + 73, Surplus6Name4.text);
        PlayerPrefs.SetString("Surplus6Name" + 74, Surplus6Name5.text);

        PlayerPrefs.SetString("Surplus6PartNum" + 70, Surplus6PartNum1.text);
        PlayerPrefs.SetString("Surplus6PartNum" + 71, Surplus6PartNum2.text);
        PlayerPrefs.SetString("Surplus6PartNum" + 72, Surplus6PartNum3.text);
        PlayerPrefs.SetString("Surplus6PartNum" + 73, Surplus6PartNum4.text);
        PlayerPrefs.SetString("Surplus6PartNum" + 74, Surplus6PartNum5.text);

        PlayerPrefs.SetString("Surplus6SerialNum" + 70, Surplus6SerialNum1.text);
        PlayerPrefs.SetString("Surplus6SerialNum" + 71, Surplus6SerialNum2.text);
        PlayerPrefs.SetString("Surplus6SerialNum" + 72, Surplus6SerialNum3.text);
        PlayerPrefs.SetString("Surplus6SerialNum" + 73, Surplus6SerialNum4.text);
        PlayerPrefs.SetString("Surplus6SerialNum" + 74, Surplus6SerialNum5.text);

        PlayerPrefs.SetString("Surplus6Remarks" + 70, Surplus6Remarks1.text);
        PlayerPrefs.SetString("Surplus6Remarks" + 71, Surplus6Remarks2.text);
        PlayerPrefs.SetString("Surplus6Remarks" + 72, Surplus6Remarks3.text);
        PlayerPrefs.SetString("Surplus6Remarks" + 73, Surplus6Remarks4.text);
        PlayerPrefs.SetString("Surplus6Remarks" + 74, Surplus6Remarks5.text);

        PlayerPrefs.Save();

        Debug.Log("Set surplus items");

    }


    public void ReviewPageOne()
    {
        ReceivedPart1.text = PlayerPrefs.GetString("ReviewReceived" + 3);
        ReceivedPart2.text = PlayerPrefs.GetString("ReviewReceived" + 4);
        ReceivedPart3.text = PlayerPrefs.GetString("ReviewReceived" + 5);
        ReceivedPart4.text = PlayerPrefs.GetString("ReviewReceived" + 6);
        ReceivedPart5.text = PlayerPrefs.GetString("ReviewReceived" + 7);

        DamagedPart1.text = PlayerPrefs.GetString("ReviewDamaged" + 3);
        DamagedPart2.text = PlayerPrefs.GetString("ReviewDamaged" + 4);
        DamagedPart3.text = PlayerPrefs.GetString("ReviewDamaged" + 5);
        DamagedPart4.text = PlayerPrefs.GetString("ReviewDamaged" + 6);
        DamagedPart5.text = PlayerPrefs.GetString("ReviewDamaged" + 7);

        RemarksPart1.text = PlayerPrefs.GetString("ReviewRemarks" + 3);
        RemarksPart2.text = PlayerPrefs.GetString("ReviewRemarks" + 4);
        RemarksPart3.text = PlayerPrefs.GetString("ReviewRemarks" + 5);
        RemarksPart4.text = PlayerPrefs.GetString("ReviewRemarks" + 6);
        RemarksPart5.text = PlayerPrefs.GetString("ReviewRemarks" + 7);

    }
   
    public void ReviewPageTwo()
    {
        ReceivedPart6.text = PlayerPrefs.GetString("ReviewReceived" + 8);
        ReceivedPart7.text = PlayerPrefs.GetString("ReviewReceived" + 9);
        ReceivedPart8.text = PlayerPrefs.GetString("ReviewReceived" + 10);
        ReceivedPart9.text = PlayerPrefs.GetString("ReviewReceived" + 11);
        ReceivedPart10.text = PlayerPrefs.GetString("ReviewReceived" + 12);

        DamagedPart6.text = PlayerPrefs.GetString("ReviewDamaged" + 8);
        DamagedPart7.text = PlayerPrefs.GetString("ReviewDamaged" + 9);
        DamagedPart8.text = PlayerPrefs.GetString("ReviewDamaged" + 10);
        DamagedPart9.text = PlayerPrefs.GetString("ReviewDamaged" + 11);
        DamagedPart10.text = PlayerPrefs.GetString("ReviewDamaged" + 12);

        RemarksPart6.text = PlayerPrefs.GetString("ReviewRemarks" + 8);
        RemarksPart7.text = PlayerPrefs.GetString("ReviewRemarks" + 9);
        RemarksPart8.text = PlayerPrefs.GetString("ReviewRemarks" + 10);
        RemarksPart9.text = PlayerPrefs.GetString("ReviewRemarks" + 11);
        RemarksPart10.text = PlayerPrefs.GetString("ReviewRemarks" + 12);

    }

    public void ReviewPageThree()
    {
        ReceivedPart11.text = PlayerPrefs.GetString("ReviewReceived" + 13);
        ReceivedPart12.text = PlayerPrefs.GetString("ReviewReceived" + 14);
        ReceivedPart13.text = PlayerPrefs.GetString("ReviewReceived" + 15);
        ReceivedPart14.text = PlayerPrefs.GetString("ReviewReceived" + 16);
        ReceivedPart15.text = PlayerPrefs.GetString("ReviewReceived" + 17);

        DamagedPart11.text = PlayerPrefs.GetString("ReviewDamaged" + 13);
        DamagedPart12.text = PlayerPrefs.GetString("ReviewDamaged" + 14);
        DamagedPart13.text = PlayerPrefs.GetString("ReviewDamaged" + 15);
        DamagedPart14.text = PlayerPrefs.GetString("ReviewDamaged" + 16);
        DamagedPart15.text = PlayerPrefs.GetString("ReviewDamaged" + 17);

        RemarksPart11.text = PlayerPrefs.GetString("ReviewRemarks" + 13);
        RemarksPart12.text = PlayerPrefs.GetString("ReviewRemarks" + 14);
        RemarksPart13.text = PlayerPrefs.GetString("ReviewRemarks" + 15);
        RemarksPart14.text = PlayerPrefs.GetString("ReviewRemarks" + 16);
        RemarksPart15.text = PlayerPrefs.GetString("ReviewRemarks" + 17);

    }

    public void ReviewPageFour()
    {
        ReceivedPart16.text = PlayerPrefs.GetString("ReviewReceived" + 18);
        ReceivedPart17.text = PlayerPrefs.GetString("ReviewReceived" + 19);
        ReceivedPart18.text = PlayerPrefs.GetString("ReviewReceived" + 20);
        ReceivedPart19.text = PlayerPrefs.GetString("ReviewReceived" + 21);
        ReceivedPart20.text = PlayerPrefs.GetString("ReviewReceived" + 22);

        DamagedPart16.text = PlayerPrefs.GetString("ReviewDamaged" + 18);
        DamagedPart17.text = PlayerPrefs.GetString("ReviewDamaged" + 19);
        DamagedPart18.text = PlayerPrefs.GetString("ReviewDamaged" + 20);
        DamagedPart19.text = PlayerPrefs.GetString("ReviewDamaged" + 21);
        DamagedPart20.text = PlayerPrefs.GetString("ReviewDamaged" + 22);

        RemarksPart16.text = PlayerPrefs.GetString("ReviewRemarks" + 18);
        RemarksPart17.text = PlayerPrefs.GetString("ReviewRemarks" + 19);
        RemarksPart18.text = PlayerPrefs.GetString("ReviewRemarks" + 20);
        RemarksPart19.text = PlayerPrefs.GetString("ReviewRemarks" + 21);
        RemarksPart20.text = PlayerPrefs.GetString("ReviewRemarks" + 22);

    }

    public void ReviewPageFive()
    {
        ReceivedPart21.text = PlayerPrefs.GetString("ReviewReceived" + 23);
        ReceivedPart22.text = PlayerPrefs.GetString("ReviewReceived" + 24);
        ReceivedPart23.text = PlayerPrefs.GetString("ReviewReceived" + 25);
        ReceivedPart24.text = PlayerPrefs.GetString("ReviewReceived" + 26);
        ReceivedPart25.text = PlayerPrefs.GetString("ReviewReceived" + 27);

        DamagedPart21.text = PlayerPrefs.GetString("ReviewDamaged" + 23);
        DamagedPart22.text = PlayerPrefs.GetString("ReviewDamaged" + 24);
        DamagedPart23.text = PlayerPrefs.GetString("ReviewDamaged" + 25);
        DamagedPart24.text = PlayerPrefs.GetString("ReviewDamaged" + 26);
        DamagedPart25.text = PlayerPrefs.GetString("ReviewDamaged" + 27);

        RemarksPart21.text = PlayerPrefs.GetString("ReviewRemarks" + 23);
        RemarksPart22.text = PlayerPrefs.GetString("ReviewRemarks" + 24);
        RemarksPart23.text = PlayerPrefs.GetString("ReviewRemarks" + 25);
        RemarksPart24.text = PlayerPrefs.GetString("ReviewRemarks" + 26);
        RemarksPart25.text = PlayerPrefs.GetString("ReviewRemarks" + 27);


    }

    public void ReviewPageSix()
    {
        ReceivedPart26.text = PlayerPrefs.GetString("ReviewReceived" + 28);
        ReceivedPart27.text = PlayerPrefs.GetString("ReviewReceived" + 29);
        ReceivedPart28.text = PlayerPrefs.GetString("ReviewReceived" + 30);
        ReceivedPart29.text = PlayerPrefs.GetString("ReviewReceived" + 31);
        ReceivedPart30.text = PlayerPrefs.GetString("ReviewReceived" + 32);

        DamagedPart26.text = PlayerPrefs.GetString("ReviewDamaged" + 28);
        DamagedPart27.text = PlayerPrefs.GetString("ReviewDamaged" + 29);
        DamagedPart28.text = PlayerPrefs.GetString("ReviewDamaged" + 30);
        DamagedPart29.text = PlayerPrefs.GetString("ReviewDamaged" + 31);
        DamagedPart30.text = PlayerPrefs.GetString("ReviewDamaged" + 32);

        RemarksPart26.text = PlayerPrefs.GetString("ReviewRemarks" + 28);
        RemarksPart27.text = PlayerPrefs.GetString("ReviewRemarks" + 29);
        RemarksPart28.text = PlayerPrefs.GetString("ReviewRemarks" + 30);
        RemarksPart29.text = PlayerPrefs.GetString("ReviewRemarks" + 31);
        RemarksPart30.text = PlayerPrefs.GetString("ReviewRemarks" + 32);

    }

    public void ReviewPageSeven()
    {
        ReceivedPart31.text = PlayerPrefs.GetString("ReviewReceived" + 33);
        ReceivedPart32.text = PlayerPrefs.GetString("ReviewReceived" + 34);
        ReceivedPart33.text = PlayerPrefs.GetString("ReviewReceived" + 35);
        ReceivedPart34.text = PlayerPrefs.GetString("ReviewReceived" + 36);
        ReceivedPart35.text = PlayerPrefs.GetString("ReviewReceived" + 37);

        DamagedPart31.text = PlayerPrefs.GetString("ReviewDamaged" + 33);
        DamagedPart32.text = PlayerPrefs.GetString("ReviewDamaged" + 34);
        DamagedPart33.text = PlayerPrefs.GetString("ReviewDamaged" + 35);
        DamagedPart34.text = PlayerPrefs.GetString("ReviewDamaged" + 36);
        DamagedPart35.text = PlayerPrefs.GetString("ReviewDamaged" + 37);

        RemarksPart31.text = PlayerPrefs.GetString("ReviewRemarks" + 33);
        RemarksPart32.text = PlayerPrefs.GetString("ReviewRemarks" + 34);
        RemarksPart33.text = PlayerPrefs.GetString("ReviewRemarks" + 35);
        RemarksPart34.text = PlayerPrefs.GetString("ReviewRemarks" + 36);
        RemarksPart35.text = PlayerPrefs.GetString("ReviewRemarks" + 37);

    }

    public void ReviewPageEight()
    {
        ReceivedPart36.text = PlayerPrefs.GetString("ReviewReceived" + 38);
        ReceivedPart37.text = PlayerPrefs.GetString("ReviewReceived" + 39);
        ReceivedPart38.text = PlayerPrefs.GetString("ReviewReceived" + 40);
        ReceivedPart39.text = PlayerPrefs.GetString("ReviewReceived" + 41);
        ReceivedPart40.text = PlayerPrefs.GetString("ReviewReceived" + 42);

        DamagedPart36.text = PlayerPrefs.GetString("ReviewDamaged" + 38);
        DamagedPart37.text = PlayerPrefs.GetString("ReviewDamaged" + 39);
        DamagedPart38.text = PlayerPrefs.GetString("ReviewDamaged" + 40);
        DamagedPart39.text = PlayerPrefs.GetString("ReviewDamaged" + 41);
        DamagedPart40.text = PlayerPrefs.GetString("ReviewDamaged" + 42);

        RemarksPart36.text = PlayerPrefs.GetString("ReviewRemarks" + 38);
        RemarksPart37.text = PlayerPrefs.GetString("ReviewRemarks" + 39);
        RemarksPart38.text = PlayerPrefs.GetString("ReviewRemarks" + 40);
        RemarksPart39.text = PlayerPrefs.GetString("ReviewRemarks" + 41);
        RemarksPart40.text = PlayerPrefs.GetString("ReviewRemarks" + 42);

    }

    public void ReviewPageNine()
    {
        ReceivedPart41.text = PlayerPrefs.GetString("ReviewReceived" + 43);
        ReceivedPart42.text = PlayerPrefs.GetString("ReviewReceived" + 44);
        ReceivedPart43.text = PlayerPrefs.GetString("ReviewReceived" + 45);
        ReceivedPart44.text = PlayerPrefs.GetString("ReviewReceived" + 46);
        ReceivedPart45.text = PlayerPrefs.GetString("ReviewReceived" + 47);

        DamagedPart41.text = PlayerPrefs.GetString("ReviewDamaged" + 43);
        DamagedPart42.text = PlayerPrefs.GetString("ReviewDamaged" + 44);
        DamagedPart43.text = PlayerPrefs.GetString("ReviewDamaged" + 45);
        DamagedPart44.text = PlayerPrefs.GetString("ReviewDamaged" + 46);
        DamagedPart45.text = PlayerPrefs.GetString("ReviewDamaged" + 47);

        RemarksPart41.text = PlayerPrefs.GetString("ReviewRemarks" + 43);
        RemarksPart42.text = PlayerPrefs.GetString("ReviewRemarks" + 44);
        RemarksPart43.text = PlayerPrefs.GetString("ReviewRemarks" + 45);
        RemarksPart44.text = PlayerPrefs.GetString("ReviewRemarks" + 46);
        RemarksPart45.text = PlayerPrefs.GetString("ReviewRemarks" + 47);

    }

    public void ReviewPageTen()
    {
        ReceivedPart46.text = PlayerPrefs.GetString("ReviewReceived" + 48);
        ReceivedPart47.text = PlayerPrefs.GetString("ReviewReceived" + 49);
        ReceivedPart48.text = PlayerPrefs.GetString("ReviewReceived" + 50);
        ReceivedPart49.text = PlayerPrefs.GetString("ReviewReceived" + 51);
        ReceivedPart50.text = PlayerPrefs.GetString("ReviewReceived" + 52);

        DamagedPart46.text = PlayerPrefs.GetString("ReviewDamaged" + 48);
        DamagedPart47.text = PlayerPrefs.GetString("ReviewDamaged" + 49);
        DamagedPart48.text = PlayerPrefs.GetString("ReviewDamaged" + 50);
        DamagedPart49.text = PlayerPrefs.GetString("ReviewDamaged" + 51);
        DamagedPart50.text = PlayerPrefs.GetString("ReviewDamaged" + 52);

        RemarksPart46.text = PlayerPrefs.GetString("ReviewRemarks" + 48);
        RemarksPart47.text = PlayerPrefs.GetString("ReviewRemarks" + 49);
        RemarksPart48.text = PlayerPrefs.GetString("ReviewRemarks" + 50);
        RemarksPart49.text = PlayerPrefs.GetString("ReviewRemarks" + 51);
        RemarksPart50.text = PlayerPrefs.GetString("ReviewRemarks" + 52);

    }

    public void ReviewPageEleven() // review page for missing items 1
    {
        Missing_1Name1.text = PlayerPrefs.GetString("ReviewMissing1Name" + 1);
        Missing_1Name2.text = PlayerPrefs.GetString("ReviewMissing1Name" + 2);
        Missing_1Name3.text = PlayerPrefs.GetString("ReviewMissing1Name" + 3);
        Missing_1Name4.text = PlayerPrefs.GetString("ReviewMissing1Name" + 4);
        Missing_1Name5.text = PlayerPrefs.GetString("ReviewMissing1Name" + 5);

        Missing_1PartNum1.text = PlayerPrefs.GetString("ReviewMissing1PartNum" + 1);
        Missing_1PartNum2.text = PlayerPrefs.GetString("ReviewMissing1PartNum" + 2);
        Missing_1PartNum3.text = PlayerPrefs.GetString("ReviewMissing1PartNum" + 3);
        Missing_1PartNum4.text = PlayerPrefs.GetString("ReviewMissing1PartNum" + 4);
        Missing_1PartNum5.text = PlayerPrefs.GetString("ReviewMissing1PartNum" + 5);

        Missing_1SerialNum1.text = PlayerPrefs.GetString("ReviewMissing1SerialNum" + 1);
        Missing_1SerialNum2.text = PlayerPrefs.GetString("ReviewMissing1SerialNum" + 2);
        Missing_1SerialNum3.text = PlayerPrefs.GetString("ReviewMissing1SerialNum" + 3);
        Missing_1SerialNum4.text = PlayerPrefs.GetString("ReviewMissing1SerialNum" + 4);
        Missing_1SerialNum5.text = PlayerPrefs.GetString("ReviewMissing1SerialNum" + 5);

        Missing_1Remarks1.text = PlayerPrefs.GetString("ReviewMissing1Remarks" + 1);
        Missing_1Remarks2.text = PlayerPrefs.GetString("ReviewMissing1Remarks" + 2);
        Missing_1Remarks3.text = PlayerPrefs.GetString("ReviewMissing1Remarks" + 3);
        Missing_1Remarks4.text = PlayerPrefs.GetString("ReviewMissing1Remarks" + 4);
        Missing_1Remarks5.text = PlayerPrefs.GetString("ReviewMissing1Remarks" + 5);

        Debug.Log("Print review page 11");
    }

    public void ReviewPageTwelve() // review page for missing items 2
    {
        Missing_2Name1.text = PlayerPrefs.GetString("ReviewMissing2Name" + 52);
        Missing_2Name2.text = PlayerPrefs.GetString("ReviewMissing2Name" + 53);
        Missing_2Name3.text = PlayerPrefs.GetString("ReviewMissing2Name" + 54);
        Missing_2Name4.text = PlayerPrefs.GetString("ReviewMissing2Name" + 55);
        Missing_2Name5.text = PlayerPrefs.GetString("ReviewMissing2Name" + 56);

        Missing_2PartNum1.text = PlayerPrefs.GetString("ReviewMissing2PartNum" + 52);
        Missing_2PartNum2.text = PlayerPrefs.GetString("ReviewMissing2PartNum" + 53);
        Missing_2PartNum3.text = PlayerPrefs.GetString("ReviewMissing2PartNum" + 54);
        Missing_2PartNum4.text = PlayerPrefs.GetString("ReviewMissing2PartNum" + 55);
        Missing_2PartNum5.text = PlayerPrefs.GetString("ReviewMissing2PartNum" + 56);

        Missing_2SerialNum1.text = PlayerPrefs.GetString("ReviewMissing2SerialNum" + 52);
        Missing_2SerialNum2.text = PlayerPrefs.GetString("ReviewMissing2SerialNum" + 53);
        Missing_2SerialNum3.text = PlayerPrefs.GetString("ReviewMissing2SerialNum" + 54);
        Missing_2SerialNum4.text = PlayerPrefs.GetString("ReviewMissing2SerialNum" + 55);
        Missing_2SerialNum5.text = PlayerPrefs.GetString("ReviewMissing2SerialNum" + 56);

        Missing_2Remarks1.text = PlayerPrefs.GetString("ReviewMissing2Remarks" + 52);
        Missing_2Remarks2.text = PlayerPrefs.GetString("ReviewMissing2Remarks" + 53);
        Missing_2Remarks3.text = PlayerPrefs.GetString("ReviewMissing2Remarks" + 54);
        Missing_2Remarks4.text = PlayerPrefs.GetString("ReviewMissing2Remarks" + 55);
        Missing_2Remarks5.text = PlayerPrefs.GetString("ReviewMissing2Remarks" + 56);

        Debug.Log("print review page 12");
    }

    public void ReviewPageThirteen() // review page for missing items 3
    {
        Missing_3Name1.text = PlayerPrefs.GetString("ReviewMissing3Name" + 54);
        Missing_3Name2.text = PlayerPrefs.GetString("ReviewMissing3Name" + 55);
        Missing_3Name3.text = PlayerPrefs.GetString("ReviewMissing3Name" + 56);
        Missing_3Name4.text = PlayerPrefs.GetString("ReviewMissing3Name" + 57);
        Missing_3Name5.text = PlayerPrefs.GetString("ReviewMissing3Name" + 58);

        Missing_3PartNum1.text = PlayerPrefs.GetString("ReviewMissing3PartNum" + 54);
        Missing_3PartNum2.text = PlayerPrefs.GetString("ReviewMissing3PartNum" + 55);
        Missing_3PartNum3.text = PlayerPrefs.GetString("ReviewMissing3PartNum" + 56);
        Missing_3PartNum4.text = PlayerPrefs.GetString("ReviewMissing3PartNum" + 57);
        Missing_3PartNum5.text = PlayerPrefs.GetString("ReviewMissing3PartNum" + 58);

        Missing_3SerialNum1.text = PlayerPrefs.GetString("ReviewMissing3SerialNum" + 54);
        Missing_3SerialNum2.text = PlayerPrefs.GetString("ReviewMissing3SerialNum" + 55);
        Missing_3SerialNum3.text = PlayerPrefs.GetString("ReviewMissing3SerialNum" + 56);
        Missing_3SerialNum4.text = PlayerPrefs.GetString("ReviewMissing3SerialNum" + 57);
        Missing_3SerialNum5.text = PlayerPrefs.GetString("ReviewMissing3SerialNum" + 58);

        Missing_3Remarks1.text = PlayerPrefs.GetString("ReviewMissing3Remarks" + 54);
        Missing_3Remarks2.text = PlayerPrefs.GetString("ReviewMissing3Remarks" + 55);
        Missing_3Remarks3.text = PlayerPrefs.GetString("ReviewMissing3Remarks" + 56);
        Missing_3Remarks4.text = PlayerPrefs.GetString("ReviewMissing3Remarks" + 57);
        Missing_3Remarks5.text = PlayerPrefs.GetString("ReviewMissing3Remarks" + 58);


    }

    public void ReviewPageFourteen() // review page for missing items 4
    {
        Missing_4Name1.text = PlayerPrefs.GetString("ReviewMissing4Name" + 56);
        Missing_4Name2.text = PlayerPrefs.GetString("ReviewMissing4Name" + 57);
        Missing_4Name3.text = PlayerPrefs.GetString("ReviewMissing4Name" + 58);
        Missing_4Name4.text = PlayerPrefs.GetString("ReviewMissing4Name" + 59);
        Missing_4Name5.text = PlayerPrefs.GetString("ReviewMissing4Name" + 60);

        Missing_4PartNum1.text = PlayerPrefs.GetString("ReviewMissing4PartNum" + 56);
        Missing_4PartNum2.text = PlayerPrefs.GetString("ReviewMissing4PartNum" + 57);
        Missing_4PartNum3.text = PlayerPrefs.GetString("ReviewMissing4PartNum" + 58);
        Missing_4PartNum4.text = PlayerPrefs.GetString("ReviewMissing4PartNum" + 59);
        Missing_4PartNum5.text = PlayerPrefs.GetString("ReviewMissing4PartNum" + 60);

        Missing_4SerialNum1.text = PlayerPrefs.GetString("ReviewMissing4SerialNum" + 56);
        Missing_4SerialNum2.text = PlayerPrefs.GetString("ReviewMissing4SerialNum" + 57);
        Missing_4SerialNum3.text = PlayerPrefs.GetString("ReviewMissing4SerialNum" + 58);
        Missing_4SerialNum4.text = PlayerPrefs.GetString("ReviewMissing4SerialNum" + 59);
        Missing_4SerialNum5.text = PlayerPrefs.GetString("ReviewMissing4SerialNum" + 60);

        Missing_4Remarks1.text = PlayerPrefs.GetString("ReviewMissing4Remarks" + 56);
        Missing_4Remarks2.text = PlayerPrefs.GetString("ReviewMissing4Remarks" + 57);
        Missing_4Remarks3.text = PlayerPrefs.GetString("ReviewMissing4Remarks" + 58);
        Missing_4Remarks4.text = PlayerPrefs.GetString("ReviewMissing4Remarks" + 59);
        Missing_4Remarks5.text = PlayerPrefs.GetString("ReviewMissing4Remarks" + 60);


    }

    public void ReviewPageFifteen() // review page for missing items 5
    {
        Missing_5Name1.text = PlayerPrefs.GetString("ReviewMissing5Name" + 58);
        Missing_5Name2.text = PlayerPrefs.GetString("ReviewMissing5Name" + 59);
        Missing_5Name3.text = PlayerPrefs.GetString("ReviewMissing5Name" + 60);
        Missing_5Name4.text = PlayerPrefs.GetString("ReviewMissing5Name" + 61);
        Missing_5Name5.text = PlayerPrefs.GetString("ReviewMissing5Name" + 62);

        Missing_5PartNum1.text = PlayerPrefs.GetString("ReviewMissing5PartNum" + 58);
        Missing_5PartNum2.text = PlayerPrefs.GetString("ReviewMissing5PartNum" + 59);
        Missing_5PartNum3.text = PlayerPrefs.GetString("ReviewMissing5PartNum" + 60);
        Missing_5PartNum4.text = PlayerPrefs.GetString("ReviewMissing5PartNum" + 61);
        Missing_5PartNum5.text = PlayerPrefs.GetString("ReviewMissing5PartNum" + 62);

        Missing_5SerialNum1.text = PlayerPrefs.GetString("ReviewMissing5SerialNum" + 58);
        Missing_5SerialNum2.text = PlayerPrefs.GetString("ReviewMissing5SerialNum" + 59);
        Missing_5SerialNum3.text = PlayerPrefs.GetString("ReviewMissing5SerialNum" + 60);
        Missing_5SerialNum4.text = PlayerPrefs.GetString("ReviewMissing5SerialNum" + 61);
        Missing_5SerialNum5.text = PlayerPrefs.GetString("ReviewMissing5SerialNum" + 62);

        Missing_5Remarks1.text = PlayerPrefs.GetString("ReviewMissing5Remarks" + 58);
        Missing_5Remarks2.text = PlayerPrefs.GetString("ReviewMissing5Remarks" + 59);
        Missing_5Remarks3.text = PlayerPrefs.GetString("ReviewMissing5Remarks" + 60);
        Missing_5Remarks4.text = PlayerPrefs.GetString("ReviewMissing5Remarks" + 61);
        Missing_5Remarks5.text = PlayerPrefs.GetString("ReviewMissing5Remarks" + 62);


    }

    public void ReviewPageSixteen() // review page for missing items 6
    {
        Missing_6Name1.text = PlayerPrefs.GetString("ReviewMissing6Name" + 60);
        Missing_6Name2.text = PlayerPrefs.GetString("ReviewMissing6Name" + 61);
        Missing_6Name3.text = PlayerPrefs.GetString("ReviewMissing6Name" + 62);
        Missing_6Name4.text = PlayerPrefs.GetString("ReviewMissing6Name" + 63);
        Missing_6Name5.text = PlayerPrefs.GetString("ReviewMissing6Name" + 64);
    
        Missing_6PartNum1.text = PlayerPrefs.GetString("ReviewMissing6PartNum" + 60);
        Missing_6PartNum2.text = PlayerPrefs.GetString("ReviewMissing6PartNum" + 61);
        Missing_6PartNum3.text = PlayerPrefs.GetString("ReviewMissing6PartNum" + 62);
        Missing_6PartNum4.text = PlayerPrefs.GetString("ReviewMissing6PartNum" + 63);
        Missing_6PartNum5.text = PlayerPrefs.GetString("ReviewMissing6PartNum" + 64);

        Missing_6SerialNum1.text = PlayerPrefs.GetString("ReviewMissing6SerialNum" + 60);
        Missing_6SerialNum2.text = PlayerPrefs.GetString("ReviewMissing6SerialNum" + 61);
        Missing_6SerialNum3.text = PlayerPrefs.GetString("ReviewMissing6SerialNum" + 62);
        Missing_6SerialNum4.text = PlayerPrefs.GetString("ReviewMissing6SerialNum" + 63);
        Missing_6SerialNum5.text = PlayerPrefs.GetString("ReviewMissing6SerialNum" + 64);

        Missing_6Remarks1.text = PlayerPrefs.GetString("ReviewMissing6Remarks" + 60);
        Missing_6Remarks2.text = PlayerPrefs.GetString("ReviewMissing6Remarks" + 61);
        Missing_6Remarks3.text = PlayerPrefs.GetString("ReviewMissing6Remarks" + 62);
        Missing_6Remarks4.text = PlayerPrefs.GetString("ReviewMissing6Remarks" + 63);
        Missing_6Remarks5.text = PlayerPrefs.GetString("ReviewMissing6Remarks" + 64);


    }

    public void ReviewPageSeventeen() // review page for Surplus items 1 
    {
        Surplus_1Name1.text = PlayerPrefs.GetString("ReviewSurplus1Name" + 50);
        Surplus_1Name2.text = PlayerPrefs.GetString("ReviewSurplus1Name" + 51);
        Surplus_1Name3.text = PlayerPrefs.GetString("ReviewSurplus1Name" + 52);
        Surplus_1Name4.text = PlayerPrefs.GetString("ReviewSurplus1Name" + 53);
        Surplus_1Name5.text = PlayerPrefs.GetString("ReviewSurplus1Name" + 54);

        Surplus_1PartNum1.text = PlayerPrefs.GetString("ReviewSurplus1PartNum" + 50);
        Surplus_1PartNum2.text = PlayerPrefs.GetString("ReviewSurplus1PartNum" + 51);
        Surplus_1PartNum3.text = PlayerPrefs.GetString("ReviewSurplus1PartNum" + 52);
        Surplus_1PartNum4.text = PlayerPrefs.GetString("ReviewSurplus1PartNum" + 53);
        Surplus_1PartNum5.text = PlayerPrefs.GetString("ReviewSurplus1PartNum" + 54);

        Surplus_1SerialNum1.text = PlayerPrefs.GetString("ReviewSurplus1SerialNum" + 50);
        Surplus_1SerialNum2.text = PlayerPrefs.GetString("ReviewSurplus1SerialNum" + 51);
        Surplus_1SerialNum3.text = PlayerPrefs.GetString("ReviewSurplus1SerialNum" + 52);
        Surplus_1SerialNum4.text = PlayerPrefs.GetString("ReviewSurplus1SerialNum" + 53);
        Surplus_1SerialNum5.text = PlayerPrefs.GetString("ReviewSurplus1SerialNum" + 54);

        Surplus_1Remarks1.text = PlayerPrefs.GetString("ReviewSurplus1Remarks" + 50);
        Surplus_1Remarks2.text = PlayerPrefs.GetString("ReviewSurplus1Remarks" + 51);
        Surplus_1Remarks3.text = PlayerPrefs.GetString("ReviewSurplus1Remarks" + 52);
        Surplus_1Remarks4.text = PlayerPrefs.GetString("ReviewSurplus1Remarks" + 53);
        Surplus_1Remarks5.text = PlayerPrefs.GetString("ReviewSurplus1Remarks" + 54);

        Debug.Log("Print surplus items");

    }

    public void ReviewPageEighteen() // review page for Surplus items 2
    {
        Surplus_2Name1.text = PlayerPrefs.GetString("ReviewSurplus2Name" + 62);
        Surplus_2Name2.text = PlayerPrefs.GetString("ReviewSurplus2Name" + 63);
        Surplus_2Name3.text = PlayerPrefs.GetString("ReviewSurplus2Name" + 64);
        Surplus_2Name4.text = PlayerPrefs.GetString("ReviewSurplus2Name" + 65);
        Surplus_2Name5.text = PlayerPrefs.GetString("ReviewSurplus2Name" + 66);

        Surplus_2PartNum1.text = PlayerPrefs.GetString("ReviewSurplus2PartNum" + 62);
        Surplus_2PartNum2.text = PlayerPrefs.GetString("ReviewSurplus2PartNum" + 63);
        Surplus_2PartNum3.text = PlayerPrefs.GetString("ReviewSurplus2PartNum" + 64);
        Surplus_2PartNum4.text = PlayerPrefs.GetString("ReviewSurplus2PartNum" + 65);
        Surplus_2PartNum5.text = PlayerPrefs.GetString("ReviewSurplus2PartNum" + 66);

        Surplus_2SerialNum1.text = PlayerPrefs.GetString("ReviewSurplus2SerialNum" + 62);
        Surplus_2SerialNum2.text = PlayerPrefs.GetString("ReviewSurplus2SerialNum" + 63);
        Surplus_2SerialNum3.text = PlayerPrefs.GetString("ReviewSurplus2SerialNum" + 64);
        Surplus_2SerialNum4.text = PlayerPrefs.GetString("ReviewSurplus2SerialNum" + 65);
        Surplus_2SerialNum5.text = PlayerPrefs.GetString("ReviewSurplus2SerialNum" + 66);

        Surplus_2Remarks1.text = PlayerPrefs.GetString("ReviewSurplus2Remarks" + 62);
        Surplus_2Remarks2.text = PlayerPrefs.GetString("ReviewSurplus2Remarks" + 63);
        Surplus_2Remarks3.text = PlayerPrefs.GetString("ReviewSurplus2Remarks" + 64);
        Surplus_2Remarks4.text = PlayerPrefs.GetString("ReviewSurplus2Remarks" + 65);
        Surplus_2Remarks5.text = PlayerPrefs.GetString("ReviewSurplus2Remarks" + 66);

        Debug.Log("Print surplus items");

    }

    public void ReviewPageNineteen() // review page for Surplus items 3
    {
        Surplus_3Name1.text = PlayerPrefs.GetString("ReviewSurplus3Name" + 64);
        Surplus_3Name2.text = PlayerPrefs.GetString("ReviewSurplus3Name" + 65);
        Surplus_3Name3.text = PlayerPrefs.GetString("ReviewSurplus3Name" + 66);
        Surplus_3Name4.text = PlayerPrefs.GetString("ReviewSurplus3Name" + 67);
        Surplus_3Name5.text = PlayerPrefs.GetString("ReviewSurplus3Name" + 68);

        Surplus_3PartNum1.text = PlayerPrefs.GetString("ReviewSurplus3PartNum" + 64);
        Surplus_3PartNum2.text = PlayerPrefs.GetString("ReviewSurplus3PartNum" + 65);
        Surplus_3PartNum3.text = PlayerPrefs.GetString("ReviewSurplus3PartNum" + 66);
        Surplus_3PartNum4.text = PlayerPrefs.GetString("ReviewSurplus3PartNum" + 67);
        Surplus_3PartNum5.text = PlayerPrefs.GetString("ReviewSurplus3PartNum" + 68);

        Surplus_3SerialNum1.text = PlayerPrefs.GetString("ReviewSurplus3SerialNum" + 64);
        Surplus_3SerialNum2.text = PlayerPrefs.GetString("ReviewSurplus3SerialNum" + 65);
        Surplus_3SerialNum3.text = PlayerPrefs.GetString("ReviewSurplus3SerialNum" + 66);
        Surplus_3SerialNum4.text = PlayerPrefs.GetString("ReviewSurplus3SerialNum" + 67);
        Surplus_3SerialNum5.text = PlayerPrefs.GetString("ReviewSurplus3SerialNum" + 68);

        Surplus_3Remarks1.text = PlayerPrefs.GetString("ReviewSurplus3Remarks" + 64);
        Surplus_3Remarks2.text = PlayerPrefs.GetString("ReviewSurplus3Remarks" + 65);
        Surplus_3Remarks3.text = PlayerPrefs.GetString("ReviewSurplus3Remarks" + 66);
        Surplus_3Remarks4.text = PlayerPrefs.GetString("ReviewSurplus3Remarks" + 67);
        Surplus_3Remarks5.text = PlayerPrefs.GetString("ReviewSurplus3Remarks" + 68);

        Debug.Log("Print surplus items");

    }

    public void ReviewPageTwenty() // review page for Surplus items 4
    {
        Surplus_4Name1.text = PlayerPrefs.GetString("ReviewSurplus4Name" + 66);
        Surplus_4Name2.text = PlayerPrefs.GetString("ReviewSurplus4Name" + 67);
        Surplus_4Name3.text = PlayerPrefs.GetString("ReviewSurplus4Name" + 68);
        Surplus_4Name4.text = PlayerPrefs.GetString("ReviewSurplus4Name" + 69);
        Surplus_4Name5.text = PlayerPrefs.GetString("ReviewSurplus4Name" + 70);

        Surplus_4PartNum1.text = PlayerPrefs.GetString("ReviewSurplus4PartNum" + 66);
        Surplus_4PartNum2.text = PlayerPrefs.GetString("ReviewSurplus4PartNum" + 67);
        Surplus_4PartNum3.text = PlayerPrefs.GetString("ReviewSurplus4PartNum" + 68);
        Surplus_4PartNum4.text = PlayerPrefs.GetString("ReviewSurplus4PartNum" + 69);
        Surplus_4PartNum5.text = PlayerPrefs.GetString("ReviewSurplus4PartNum" + 70);

        Surplus_4SerialNum1.text = PlayerPrefs.GetString("ReviewSurplus4SerialNum" + 66);
        Surplus_4SerialNum2.text = PlayerPrefs.GetString("ReviewSurplus4SerialNum" + 67);
        Surplus_4SerialNum3.text = PlayerPrefs.GetString("ReviewSurplus4SerialNum" + 68);
        Surplus_4SerialNum4.text = PlayerPrefs.GetString("ReviewSurplus4SerialNum" + 69);
        Surplus_4SerialNum5.text = PlayerPrefs.GetString("ReviewSurplus4SerialNum" + 70);

        Surplus_4Remarks1.text = PlayerPrefs.GetString("ReviewSurplus4Remarks" + 66);
        Surplus_4Remarks2.text = PlayerPrefs.GetString("ReviewSurplus4Remarks" + 67);
        Surplus_4Remarks3.text = PlayerPrefs.GetString("ReviewSurplus4Remarks" + 68);
        Surplus_4Remarks4.text = PlayerPrefs.GetString("ReviewSurplus4Remarks" + 69);
        Surplus_4Remarks5.text = PlayerPrefs.GetString("ReviewSurplus4Remarks" + 70);

        Debug.Log("Print surplus items");

    }

    public void ReviewPageTwentyOne() // review page for Surplus items 5
    {
        Surplus_5Name1.text = PlayerPrefs.GetString("ReviewSurplus5Name" + 68);
        Surplus_5Name2.text = PlayerPrefs.GetString("ReviewSurplus5Name" + 69);
        Surplus_5Name3.text = PlayerPrefs.GetString("ReviewSurplus5Name" + 70);
        Surplus_5Name4.text = PlayerPrefs.GetString("ReviewSurplus5Name" + 71);
        Surplus_5Name5.text = PlayerPrefs.GetString("ReviewSurplus5Name" + 72);

        Surplus_5PartNum1.text = PlayerPrefs.GetString("ReviewSurplus5PartNum" + 68);
        Surplus_5PartNum2.text = PlayerPrefs.GetString("ReviewSurplus5PartNum" + 69);
        Surplus_5PartNum3.text = PlayerPrefs.GetString("ReviewSurplus5PartNum" + 70);
        Surplus_5PartNum4.text = PlayerPrefs.GetString("ReviewSurplus5PartNum" + 71);
        Surplus_5PartNum5.text = PlayerPrefs.GetString("ReviewSurplus5PartNum" + 72);

        Surplus_5SerialNum1.text = PlayerPrefs.GetString("ReviewSurplus5SerialNum" + 68);
        Surplus_5SerialNum2.text = PlayerPrefs.GetString("ReviewSurplus5SerialNum" + 69);
        Surplus_5SerialNum3.text = PlayerPrefs.GetString("ReviewSurplus5SerialNum" + 70);
        Surplus_5SerialNum4.text = PlayerPrefs.GetString("ReviewSurplus5SerialNum" + 71);
        Surplus_5SerialNum5.text = PlayerPrefs.GetString("ReviewSurplus5SerialNum" + 72);

        Surplus_5Remarks1.text = PlayerPrefs.GetString("ReviewSurplus5Remarks" + 68);
        Surplus_5Remarks2.text = PlayerPrefs.GetString("ReviewSurplus5Remarks" + 69);
        Surplus_5Remarks3.text = PlayerPrefs.GetString("ReviewSurplus5Remarks" + 70);
        Surplus_5Remarks4.text = PlayerPrefs.GetString("ReviewSurplus5Remarks" + 71);
        Surplus_5Remarks5.text = PlayerPrefs.GetString("ReviewSurplus5Remarks" + 72);

        Debug.Log("Print surplus items");

    }

    public void ReviewPageTwentyTwo() // review page for Surplus items 6
    {
        Surplus_6Name1.text = PlayerPrefs.GetString("ReviewSurplus6Name" + 70);
        Surplus_6Name2.text = PlayerPrefs.GetString("ReviewSurplus6Name" + 71);
        Surplus_6Name3.text = PlayerPrefs.GetString("ReviewSurplus6Name" + 72);
        Surplus_6Name4.text = PlayerPrefs.GetString("ReviewSurplus6Name" + 73);
        Surplus_6Name5.text = PlayerPrefs.GetString("ReviewSurplus6Name" + 74);

        Surplus_6PartNum1.text = PlayerPrefs.GetString("ReviewSurplus6PartNum" + 70);
        Surplus_6PartNum2.text = PlayerPrefs.GetString("ReviewSurplus6PartNum" + 71);
        Surplus_6PartNum3.text = PlayerPrefs.GetString("ReviewSurplus6PartNum" + 72);
        Surplus_6PartNum4.text = PlayerPrefs.GetString("ReviewSurplus6PartNum" + 73);
        Surplus_6PartNum5.text = PlayerPrefs.GetString("ReviewSurplus6PartNum" + 74);

        Surplus_6SerialNum1.text = PlayerPrefs.GetString("ReviewSurplus6SerialNum" + 70);
        Surplus_6SerialNum2.text = PlayerPrefs.GetString("ReviewSurplus6SerialNum" + 71);
        Surplus_6SerialNum3.text = PlayerPrefs.GetString("ReviewSurplus6SerialNum" + 72);
        Surplus_6SerialNum4.text = PlayerPrefs.GetString("ReviewSurplus6SerialNum" + 73);
        Surplus_6SerialNum5.text = PlayerPrefs.GetString("ReviewSurplus6SerialNum" + 74);

        Surplus_6Remarks1.text = PlayerPrefs.GetString("ReviewSurplus6Remarks" + 70);
        Surplus_6Remarks2.text = PlayerPrefs.GetString("ReviewSurplus6Remarks" + 71);
        Surplus_6Remarks3.text = PlayerPrefs.GetString("ReviewSurplus6Remarks" + 72);
        Surplus_6Remarks4.text = PlayerPrefs.GetString("ReviewSurplus6Remarks" + 73);
        Surplus_6Remarks5.text = PlayerPrefs.GetString("ReviewSurplus6Remarks" + 74);

        Debug.Log("Print surplus items");

    }

    public void editMode()
    {
        PlayerPrefs.SetInt("reviewmode", 1); // called after finish scanning 22 areas
    }

    // ===============================================ADD ON TO CODE=================================================================



}
