using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveInput : MonoBehaviour
{
    public InputField inputField;
    public Text displayText;

    public InputField inputField1;
    public Text displayText1;

    public InputField inputField2;
    public Text displayText2;

    public InputField inputField3;
    public Text displayText3;

    public InputField inputField4;
    public Text displayText4;

    public InputField inputField5;
    public Text displayText5;

    public InputField inputField6;
    public Text displayText6;

    public InputField inputField7;
    public Text displayText7;

    public void OnButtonClick()
    {
        string inputText = inputField.text;
        displayText.text = inputText;

        string inputText1 = inputField1.text;
        displayText1.text = inputText1;

        string inputText2 = inputField2.text;
        displayText2.text = inputText2;

        string inputText3 = inputField3.text;
        displayText3.text = inputText3;

        string inputText4 = inputField4.text;
        displayText4.text = inputText4;

        string inputText5 = inputField5.text;
        displayText5.text = inputText5;

        string inputText6 = inputField6.text;
        displayText6.text = inputText6;

        string inputText7 = inputField7.text;
        displayText7.text = inputText7;
    }
}
