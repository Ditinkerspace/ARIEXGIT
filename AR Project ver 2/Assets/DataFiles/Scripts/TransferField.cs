using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransferField : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField sourceField1;
    public InputField targetField1;

    public void TransferInputField()
    {
        
        string text = sourceField1.text; // Get the text from the source input field

        // Set the text of the target input field to the text from the source input field
        targetField1.text = text;
    }
}
