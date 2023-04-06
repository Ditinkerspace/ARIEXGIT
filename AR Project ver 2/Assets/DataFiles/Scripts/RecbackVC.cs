using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using WearHFPlugin;

public class RecbackVC : MonoBehaviour
{
    private WearHF m_wearHF;
    public Button Backbutton;
    public GameObject PagetoLoad;
    public GameObject PagetoUnload;
    public GameObject Loadpreviousscript;
    // Start is called before the first frame update
    void Start()
    {
        m_wearHF = GameObject.Find("WearHF Manager").GetComponent<WearHF>();
    }

    private void OnEnable()
    {
        m_wearHF.AddVoiceCommand("Select Back", Voicedetected);
        print("Script enabled");
    }

    private void Voicedetected(string voiceCommand)
    {
        removecommand();
        Invoke("loadthepreviousscript", 0.5f);
        Backbutton.onClick.Invoke();

    }

    void loadthepreviousscript()
    {
        Loadpreviousscript.SetActive(true);

    }
    public void removecommand()
    {
        m_wearHF.RemoveVoiceCommand("Select Back");
    }
    private void OnDisable()
    {
        
        print("Script disabled");
    }
}
