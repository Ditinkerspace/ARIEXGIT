using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class marklessAR : MonoBehaviour
{
    private Gyroscope gyro;
    private GameObject cameraContainer;
    private Quaternion rotation;

    private WebCamTexture cam;
    public RawImage background;
    public AspectRatioFitter fit;
    public Text direction_;

    private bool arReady = false;

    private void Start()
    {
        if(!SystemInfo.supportsGyroscope)
        {
            Debug.Log("No Gyroscope!");
            return;
        }

        for (int i = 0; i < WebCamTexture.devices.Length; i++)
        {
            if(!WebCamTexture.devices[i].isFrontFacing)
            {
                cam = new WebCamTexture(WebCamTexture.devices[i].name, Screen.width, Screen.height);
                break;
            }
        }
        if (cam == null)
        {
            Debug.Log("No Back camera!");
            return;
        }

        cameraContainer = new GameObject("Camera Container");
        cameraContainer.transform.position = transform.position;
        transform.SetParent(cameraContainer.transform);

        gyro = Input.gyro;
        gyro.enabled = true;
        cameraContainer.transform.rotation = Quaternion.Euler(90f, 0, 0);
        rotation = new Quaternion(0, 0, 1, 0);

        cam.Play();
        background.texture = cam;

        arReady = true;
    }
    private void Update()
    {
        if(arReady)
        {
            float ratio = (float)cam.width / (float)cam.height;
            fit.aspectRatio = ratio;

            float scaleY = cam.videoVerticallyMirrored ? -1.0f : 1.0f;
            background.rectTransform.localScale = new Vector3(1f, scaleY, 1f);
            int orient = -cam.videoRotationAngle;
            background.rectTransform.localEulerAngles = new Vector3(0, 0, orient);
            transform.localRotation = gyro.attitude * rotation;
            
            Debug.Log(gyro.attitude);

        }
    }

}
