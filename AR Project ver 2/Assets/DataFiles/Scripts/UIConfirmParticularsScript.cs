using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIConfirmParticularsScript : MonoBehaviour
{
    public TextMeshProUGUI display_user_name;
    public TextMeshProUGUI display_user_ID;

    public void Awake()
    {
        display_user_name.text = "Welcome Back Mr. " + UIParticularsInputField.uIParticularsInputField.user_name;
        display_user_ID.text = "ID No. " + UIParticularsInputField.uIParticularsInputField.user_id;
    }

}
