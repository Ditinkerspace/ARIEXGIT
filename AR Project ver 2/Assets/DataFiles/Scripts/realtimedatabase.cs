using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proyecto26;
using UnityEngine.UI;

public class realtimedatabase : MonoBehaviour
{
    public string database_url = "https://jarvis-a7252-default-rtdb.firebaseio.com/";
    [SerializeField]Text TCFaultRemarks;
    [SerializeField]Text TCAdditionalRemarks;
    [SerializeField] Text TBFaultRemarks;
    [SerializeField] Text TBAdditionalRemarks;
    [SerializeField] Text HPTCCVFaultRemarks;
    [SerializeField] Text HPTCCVAdditionalRemarks;
    [SerializeField] Text GTBFaultRemarks;
    [SerializeField] Text GTBAdditionalRemarks;
    User user = new User();

    public GameObject summarylist;
    public GameObject saveloadpg;
    

    // Start is called before the first frame update


    public void savedata()
    {
        user.FaultRemarks = TCFaultRemarks.text;
        user.AdditionalRemarks = TCAdditionalRemarks.text;
        RestClient.Post(database_url+"/"+TCFaultRemarks.text+".json",user);
        user.FaultRemarks = TBFaultRemarks.text;
        user.AdditionalRemarks = TBAdditionalRemarks.text;
        RestClient.Post(database_url + "/" + TBFaultRemarks.text + ".json", user);
        user.FaultRemarks = GTBFaultRemarks.text;
        user.AdditionalRemarks = GTBAdditionalRemarks.text;
        RestClient.Post(database_url + "/" + GTBFaultRemarks.text + ".json", user);
        user.FaultRemarks = HPTCCVFaultRemarks.text;
        user.AdditionalRemarks = HPTCCVAdditionalRemarks.text;
        RestClient.Post(database_url + "/" + HPTCCVFaultRemarks.text + ".json", user);

    }

     
    // Update is called once per frame
    void Update()
    {
        
    }
}
