using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{
    public void resetScan ()
    {
        SceneManager.LoadScene(1); // return back to scan scene
    }

}
