using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class cubegeneration : MonoBehaviour
{
    // Start is called before the first frame update
    public float Adjacent;
    public float Opposite;
    public float Angle;
    float x3;
    float z3;
    public GameObject cube;
    Testcoordinates script = new Testcoordinates();
    //Vector3 temp;
    public void Calculate()
    {
        Angle = Mathf.Atan(Opposite / Adjacent);
        Debug.Log(Angle*(180/Math.PI));
    }
    
    public void changecubesize()
    {
        //temp = transform.localScale;

        //x3  = script.x2 - script.x1;
        //z3 = script.z2 - script.z1;
        //temp.x += script.x2;
        //temp.z += script.z2;
        cube.transform.localScale = new Vector3(script.x2, 0f, script.z2);
        
    }
   

}
