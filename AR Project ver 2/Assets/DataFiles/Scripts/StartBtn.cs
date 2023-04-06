using UnityEngine;
using WearHFPlugin;
using UnityEngine.UI;

public class StartBtn : MonoBehaviour
{
    private WearHF m_wearHF;
    public Button Startbtn;
    // Start is called before the first frame update
    void Start()
    {
        m_wearHF = GameObject.Find("WearHF Manager").GetComponent<WearHF>();

        m_wearHF.AddVoiceCommand("Select Ready", btnselected);
    }


    private void btnselected(string voiceCommand)
    {
        Startbtn.onClick.Invoke();
    }



}
