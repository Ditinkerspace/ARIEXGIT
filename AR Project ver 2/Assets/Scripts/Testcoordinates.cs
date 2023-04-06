using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Testcoordinates : MonoBehaviour
{
    // Start is called before the first frame update

    public Text posx;

    public Text posz;
    private Rigidbody2D r2d;
    public Vector3 acceleration;
    public float x1;
    public float x2;
    public float z1;
    public float z2;
    public GameObject cube;
    Distancecalculation script = new Distancecalculation();
    private Vector3 nextPoint;

    public void Start(float desiredAccuracyInMeters)
    {
        Vector3 pos = transform.position;
        r2d = GetComponent<Rigidbody2D>();
        Input.location.Start();


    }

    public void Update()
    {
        Debug.Log("x:" + transform.position.x);

        Debug.Log("z:" + transform.position.z);
        posx.text = "x:" + transform.position.x;
        
        posz.text = "z:" + transform.position.z;
        Debug.Log("r2d:"+r2d);
        Debug.Log(Input.location.lastData.altitude);
        findangle();
        

    }
    public void Storefirstcoordinates()
    {
        x1 = transform.position.x;
        z1 = transform.position.z;
    }
    public void StoreSecondcoordinates()
    {
        x2 = transform.position.x;
        z2 = transform.position.z;
        changecubesize();
    }
    public void findangle()
    {
        var relativePos = nextPoint - transform.position;

        var forward = transform.forward;
        var angle = Vector3.Angle(relativePos, forward);
        Debug.Log(angle);
    }
    public void changecubesize()
    {
        
        cube.transform.localScale = new Vector3(x2, 2f, z2);

    }









}
