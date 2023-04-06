using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nobtn : MonoBehaviour
{
    public Text textObject2;

    public void ButtonClicked()
    {
        textObject2.text = "Amend the orientation and screenshot again"; // Sets the textObject2 text object as the sentence
    }

}
