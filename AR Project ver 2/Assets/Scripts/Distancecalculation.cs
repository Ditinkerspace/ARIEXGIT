using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distancecalculation : MonoBehaviour
{
    public GameObject Player_;
    public GameObject Cube;
    public float Distance_x;
    public float Distance_z;
    public Text posx;
    public Text posz;
    public Text posy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance_z = Cube.transform.position.z - Player_.transform.position.z;
        Distance_x = Cube.transform.position.x - Player_.transform.position.x;
        Debug.Log("X:" + Distance_x);
        Debug.Log("Z:" + Distance_z);
        posx.text = "x:" + Distance_x;
        posz.text = "z:" + Distance_z;


    }
}
