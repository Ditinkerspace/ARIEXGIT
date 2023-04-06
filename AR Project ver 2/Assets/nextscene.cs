using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class nextscene : MonoBehaviour
{
    // Start is called before the first frame update
    public void nxtscene()
    {
        SceneManager.LoadScene(1);
    }
}
