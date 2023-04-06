using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIParticularsInputField : MonoBehaviour
{
    public static UIParticularsInputField uIParticularsInputField;                                                   
    public InputField userName;
    public InputField workID;
    

    public string user_name;
    public string user_id;


    private void Awake()
    {
        if(uIParticularsInputField == null)
        {
            uIParticularsInputField = this;
            DontDestroyOnLoad(gameObject);
        }else
        {
            Destroy(gameObject);
        }
    }

    public void SetUserName()
    {
        user_name = userName.text;
        user_id = workID.text;

        SceneManager.LoadSceneAsync(1);

    }

}
