using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeSelect : MonoBehaviour
{
    // Start is called before the first frame update

    public void receiveMode()
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.SetString("Mode", "Receive");
    }

    public void dispatchMode()
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.SetString("Mode", "Dipatch");
    }
}
