
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

using WearHFPlugin;
using UnityEngine.EventSystems;


public class Scene1 : MonoBehaviour
{
    private WearHF m_wearHF;

    public InputField userID;

    public GameObject menuPage;
    public GameObject confirmPage;
    public GameObject instruction1;
    public GameObject instruction2;
    public GameObject instruction3; // 
    public GameObject instructionLAST; // 
    public GameObject modeselectpage;
    public GameObject warningTextNameEmpty;
    public GameObject warningTextIDEmpty;
    public GameObject FiveBmode;
    public GameObject SevenBmode;
    public Button Quitbtn;
    public GameObject sevenbpage;
    public Button chosensevenb;
    public Button chosenfiveb;
    public AudioClip clip1;
    public GameObject warningInvalidID;
    public TextMeshProUGUI display_user_id;
    public TextMeshProUGUI display_invalid_id;
    public string user_id;
    public string user_id_integer; // try

    private int currentPage = 1;
    private int error = 0;

    public InputField workidinput;

    public GameObject InvalidIDaudio;
    public GameObject EnterIDaudio;
    public Button Inputvccmd;

    
    // maybe can add count = 0, when user input integer it adds on to the value of count > if the input is invalid count = 0 again 
    void Start()
    {
        m_wearHF = GameObject.Find("WearHF Manager").GetComponent<WearHF>(); //Find the WearHF library
        m_wearHF.AddVoiceCommand("Select Log in", Loginselected);//Adds in VC for the Login button
        m_wearHF.AddVoiceCommand("Select Quit", QuitSelected);// Adds in VC for the Quit button
        m_wearHF.AddVoiceCommand("Select Work", workidinputbox);// Adds in VC for the input field of the workidinputbox
        m_wearHF.RemoveVoiceCommand("Select 1");// Removes VC of the Select 1 button
        m_wearHF.RemoveVoiceCommand("Select 2"); // Removes VC of the Select 2 button
        m_wearHF.RemoveVoiceCommand("Select Log out");// Removes VC of the Logout button
       

        menuPage.SetActive(true); // Sets the menupage GameObject as Active
        confirmPage.SetActive(false); //  Sets the confirm GameObject as Inactive
        modeselectpage.SetActive(false); // Sets the modeselectpage GameObject as Inactive
        FiveBmode.SetActive(false);// Sets the FiveBmode GameObject as Inactive
        SevenBmode.SetActive(false);// Sets the SevenBmode as Inactive
        InvalidIDaudio.SetActive(false);// Sets the InvalidIDaudio as Inactive
        EnterIDaudio.SetActive(false);// Sets the EnterIDaudio as Inactive
        
        currentPage = 1;
        
    }

    
    
    private void workidinputbox(string voiceCommand)
    {
        EventSystem.current.SetSelectedGameObject(null);// Unselects the inputfield that has been selected
        workidinput.Select();// Selects the inputfield for typing
    }

    
    private void Loginselected(string voiceCommand)
    {
        CheckParticulars();//Activate valid employee ID filter system
        SetUserName();//Activate valid employee Username system
    }
    private void QuitSelected(string voiceCommand)
    {
        Quitbtn.onClick.Invoke();// Clicks the GameObject Quitbtn 
    }
    public void CheckParticulars()
    {


        user_id = userID.text;


        string input2 = user_id; //Converts the user_id text as string


        warningTextIDEmpty.SetActive(false); //Turns off the warningTextIDEmpty GameObject
        warningInvalidID.SetActive(false); //Turns off the warningInvalidID GameObject
        InvalidIDaudio.SetActive(false);// Turns off the InvalidIDaudio GameObject
        EnterIDaudio.SetActive(false);// Turns off the EnterIDaudio GameObject


        if (string.IsNullOrEmpty(input2)) // if user did not input both 
        {
            warningTextIDEmpty.SetActive(true);//Turns on the warningTextIDEmpty GameObject
            error = 1;//Invalid
            EnterIDaudio.SetActive(true); // Turns on the EnterIDaudio GameObject
        }



        else if (string.IsNullOrEmpty(input2)) // if user only input user name
        {
            warningTextIDEmpty.SetActive(true);//Turns on the warningTextIDEmpty GameObject
            error = 1; // Invalid
            EnterIDaudio.SetActive(true); // Turns on the EnterIDaudio GameObject
        }

        else
        {
            Debug.Log("ID is valid");
            int.TryParse(input2, out int result); // try
            if (result > 70000000 && result < 89999999)
            {
                Debug.Log("Move onto next page !");
                error = 0;// Valid
            }
            else
            {
                Debug.Log(result);
                warningInvalidID.SetActive(true);
                error = 1;//Invalid
                InvalidIDaudio.SetActive(true);
            }
        }
    }

    public void SetUserName()
    {
        if (error == 0)
        {
            InvalidIDaudio.SetActive(false); //Turns off the InvalidIDaudio GameObject
            EnterIDaudio.SetActive(false); //Turns off the EnterIDaudio GameObject

            m_wearHF.ClearCommands(); // clears all VC that has been added in 
     
            
            menuPage.SetActive(false);// Turns off the menuPage GameObject
            confirmPage.SetActive(true);// Turns on the confirmPage GameObject
            


            display_user_id.text = user_id; //sets the text value of the display_user_id GameObject to the value of the user_id variable.


            PlayerPrefs.SetString("UserID", user_id);// store user ID

            int.TryParse(user_id, out int result); // parse the string "user_id" into an integer value and stores the result in the "result" variable.
            PlayerPrefs.SetInt("UserID", result);//Stores User ID 
            m_wearHF.AddVoiceCommand("testing 1", Fivebselected);//Adds in VC to activate Fivebselected
            m_wearHF.AddVoiceCommand("Select 2", SevenbSelected);// Adds in VC to activate Sevenbselected
            m_wearHF.AddVoiceCommand("Select Log out", Logoutselected);// Adds in VC to activate Logoutselected
            m_wearHF.RemoveVoiceCommand("Select Log in");// Removes VC for login in
            m_wearHF.RemoveVoiceCommand("Select Quit");// Removes VC for quiting the app
            m_wearHF.RemoveVoiceCommand("Select 1");// Removes VC for Select 1 command

            currentPage = 2;
        }


    }

    


    private void Fivebselected(string voiceCommand)
    {
        chosesevenb();
        
    }

    private void SevenbSelected(string voiceCommand)
    {
        chosensevenb.onClick.Invoke();
    }
    
    private void Logoutselected(string voiceCommand)
    {
        ExitMainMenu();// returns from Welcome Page to Login Page
        m_wearHF.AddVoiceCommand("Select Log in", Loginselected);// add in VC for Loginselected function
        m_wearHF.AddVoiceCommand("Select Quit", QuitSelected);//add in VC for QuitSelected function
        m_wearHF.AddVoiceCommand("Select Work", workidinputbox);// add in VC for workidinputbox function
        m_wearHF.RemoveVoiceCommand("Select 1");//remove VC "Select 1"
        m_wearHF.RemoveVoiceCommand("Select 2");// remove VC "Select 2"
        m_wearHF.RemoveVoiceCommand("Select Log out");// remove VC "Select Log out"

    }
    public void ExitMainMenu()
    {
        menuPage.SetActive(true);// Turns on the menuPage GameObject
        confirmPage.SetActive(false);//Turns off the confirmPage GameObject
        instruction1.SetActive(false);//Turns off the instruction1 GameObject
        
        
        userID.text = "";// set UserId input field as blank



        currentPage = 1;// turns the currentPage counter to 1
    }



    public void Instruct1()
    {
        menuPage.SetActive(false);
        confirmPage.SetActive(false);
        instruction1.SetActive(true);
        instruction2.SetActive(false);
        instruction3.SetActive(false);
        instructionLAST.SetActive(false);
        modeselectpage.SetActive(false);
    }

    public void Instruct2()
    {
        menuPage.SetActive(false);
        confirmPage.SetActive(false);
        instruction1.SetActive(false);
        instruction2.SetActive(true);
        instruction3.SetActive(false);
        instructionLAST.SetActive(false);
        modeselectpage.SetActive(false);
    }
    public void Instruct3()
    {
        menuPage.SetActive(false);
        confirmPage.SetActive(false);
        instruction1.SetActive(false);
        instruction2.SetActive(false);
        instruction3.SetActive(true);
        instructionLAST.SetActive(false);
        modeselectpage.SetActive(false);
    }

    public void InstructLAST()
    {
        menuPage.SetActive(false);
        confirmPage.SetActive(false);
        instruction1.SetActive(false);
        instruction2.SetActive(false);
        instruction3.SetActive(false);
        instructionLAST.SetActive(true);
        modeselectpage.SetActive(false);
    }

    public void PreviousPageNumber()
    {
        currentPage -= 1;
    }

    public void Nextscene()
    {
        Debug.Log("Next Scene!");
        SceneManager.LoadScene(1);
    }

    public void skip()
    {
        menuPage.SetActive(false);
        confirmPage.SetActive(true);
        instruction1.SetActive(false);
        instruction2.SetActive(false);
        instruction3.SetActive(false);
        instructionLAST.SetActive(false);
        modeselectpage.SetActive(false);
        FiveBmode.SetActive(false);
        SevenBmode.SetActive(false);

    }
    public void chosefiveb()
    {

        
        confirmPage.SetActive(false);// turns off the confirmPage GameObject
        
        sevenbpage.SetActive(true);// turns on the sevenbpage GameObject
        m_wearHF.RemoveVoiceCommand("Select 1");// Remove VC "Select 1 "
        m_wearHF.RemoveVoiceCommand("Select 2");// Remove VC "Select 2 "
        m_wearHF.RemoveVoiceCommand("Select Log out");// Remove VC "Select Logout "
    }
    public void chosesevenb()
    {
        confirmPage.SetActive(false);// turns off the confirmPage GameObject
        m_wearHF.RemoveVoiceCommand("Select 1"); // Remove VC "Select 1 "
        m_wearHF.RemoveVoiceCommand("Select 2");// Remove VC "Select 2 "
        m_wearHF.RemoveVoiceCommand("Select Log out");// Remove VC "Select Logout "
    }
    public void BackToScanner()
    {
        SceneManager.LoadScene(1);
    }

    public void gobacktomenu()
    {
        
        sevenbpage.SetActive(false);//turns off the sevenbpage GameObject
        confirmPage.SetActive(true);//turns on the confirmPage GameObject
        m_wearHF.AddVoiceCommand("testing 1", Fivebselected);// Add the VC for the Fivebselected function
        m_wearHF.AddVoiceCommand("Select 2", SevenbSelected);// Add the VC for the SevenbSelected function 
        m_wearHF.AddVoiceCommand("Select Log out", Logoutselected);// Add the VC for the Logoutselected function
        
    }

    public void addbacklogout()
    {
        m_wearHF.AddVoiceCommand("Select Log out", Logoutselected); // Add the VC for the Logoutselected function
    }
}   
