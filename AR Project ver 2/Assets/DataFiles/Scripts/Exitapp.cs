using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exitapp : MonoBehaviour
{
    public void ExitApp()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
