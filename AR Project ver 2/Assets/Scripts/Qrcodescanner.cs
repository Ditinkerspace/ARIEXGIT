using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZXing;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Qrcodescanner : MonoBehaviour
{
    [SerializeField]
    private RawImage _rawimageBackground;

    [SerializeField]
    private AspectRatioFitter _aspectratiofitter;

    [SerializeField]
    private TextMeshProUGUI _textout;

    [SerializeField]
    private TextMeshProUGUI _textout1;

    [SerializeField]
    private RectTransform _scanZone;

    private bool _isCamAvailable;
    private WebCamTexture _cameratexture;
    float elapsed = 1f;
    float elapsed1 = 0f;
    // Start is called before the first frame update
    void Start()
    {
        SetUpCamera();
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCameraRender();
        if (elapsed > 0f)
        {
            elapsed += Time.deltaTime;
            if (elapsed >= 2f)
                    {
                        elapsed = elapsed % 1f;
                        OutputTime();
                        Scan();
                    }
        }

        if (elapsed1 > 0f)
        {
            elapsed1 += Time.deltaTime;
            if (elapsed1 >= 2f)
            {
                elapsed1 = elapsed1 % 1f;
                OutputTime();
                Scan1();
            }
        }



    }

    void OutputTime()
    {
        Debug.Log(Time.time);


    }

    private void SetUpCamera()
    {
        WebCamDevice[] devices = WebCamTexture.devices;

        if(devices.Length == 0)
        {
            _isCamAvailable = false;
            return;
        }
        for(int i = 0; i<devices.Length;i++)
        {
            if (devices[i].isFrontFacing == false)
            {
                _cameratexture = new WebCamTexture(devices[i].name, (int) _scanZone.rect.width,(int) _scanZone.rect.height);
            }

        }
        _cameratexture.Play();
        _rawimageBackground.texture = _cameratexture;
        _isCamAvailable = true;
    }
    private void UpdateCameraRender()
    {
        if(_isCamAvailable == false)
        { return; 
        }
        float ratio = (float)_cameratexture.width / (float)_cameratexture.height;
        _aspectratiofitter.aspectRatio = ratio;

        int orientation = -_cameratexture.videoRotationAngle;
        _rawimageBackground.rectTransform.localEulerAngles = new Vector3(0, 0, orientation);
    }
    public void OnClickScan()
    {
        Scan();
    }
    private void Scan()
    {
        Debug.Log("Scanning in progress");
        try
        {
            IBarcodeReader barcodeReader = new BarcodeReader();
            Result result = barcodeReader.Decode(_cameratexture.GetPixels32(), _cameratexture.width, _cameratexture.height);
            if(result != null)
            {
                _textout.text = result.Text;
                filterresult();
            }
            else
            {
                _textout.text = "Please Scan QR code on the floor";
            }
        }
        catch
        {
            _textout.text = "Failed in try!";
        }

    }

    private void filterresult()
    {
        if(_textout.text == "63781")
        {
            elapsed = 0f;
            elapsed1 = 1f;
            _textout.text = "Verified! Please Scan QR code on engine stand now.";

        }
        else
        {
            _textout.text = "Please Scan QR code on the floor";
        }
    }

    private void Scan1()
    {
        Debug.Log("Scanning in progress");
        try
        {
            IBarcodeReader barcodeReader = new BarcodeReader();
            Result result = barcodeReader.Decode(_cameratexture.GetPixels32(), _cameratexture.width, _cameratexture.height);
            if (result != null)
            {
                _textout.text = result.Text;
                filterresult1();
                
            }
            else
            {
                _textout.text = "Please Scan QR code on the engine stand.";
            }
        }
        catch
        {
            _textout.text = "Failed in try!";
        }

    }
    private void filterresult1()
    {
        if (_textout.text == "637811")
        {
            
            _textout.text = "Verified!";
            SceneManager.LoadScene(1);

        }
        else
        {
            _textout.text = "Please Scan QR code on the engine stand.";
        }
    }

}
