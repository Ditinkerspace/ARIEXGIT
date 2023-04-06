using UnityEngine;
using UnityEngine.UI;
using WearHFPlugin;

public class ChecklistVC : MonoBehaviour
{
    private WearHF m_wearHF;
    public Button Savebtn;
    public Button Backbtn;
    // Start is called before the first frame update
    void Start()
    {
        m_wearHF = GameObject.Find("WearHF Manager").GetComponent<WearHF>();
        
        
    }

    private void OnEnable()
    {
        m_wearHF.AddVoiceCommand("Select Save", Savebtnselected);
        m_wearHF.AddVoiceCommand("Select Back", backbtnselected);
    }

    private void Savebtnselected(string voiceCommand)
    {
        
        Savebtn.onClick.Invoke();

    }

    private void backbtnselected(string voiceCommand)
    {
        Clearallcommands();
        Backbtn.onClick.Invoke();
    }

    public void Clearallcommands()
    {
        m_wearHF.ClearCommands();
    }
    private void OnDisable()
    {
        Clearallcommands();
    }

}
