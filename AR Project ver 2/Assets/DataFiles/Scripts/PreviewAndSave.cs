using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
public class PreviewAndSave : MonoBehaviour {


	public GameObject PanelScreenShot;
	public GameObject PanelPreview;
	public Image PreviewImage;
	public Image SumImage;
	public Image OrientationImage;
	public GameObject JobID;
	public string path;


	Texture2D tex;

	CaptureAndSave snapShot ;
	[SerializeField]
	private string path1;
	[SerializeField]
	[Range(1, 5)]
	private int size = 1;
	void Start()
	{
		snapShot = GameObject.FindObjectOfType<CaptureAndSave>(); //captures the snapshot and becomes a variable called "snapShot"
	}

	void OnEnable()
	{
		CaptureAndSaveEventListener.onError += OnError;
		CaptureAndSaveEventListener.onSuccess += OnSuccess;
		CaptureAndSaveEventListener.onScreenShotInvoker += OnScreenShot;
	}

	void OnDisable()
	{
		CaptureAndSaveEventListener.onError -= OnError;
		CaptureAndSaveEventListener.onSuccess -= OnSuccess;
		CaptureAndSaveEventListener.onScreenShotInvoker -= OnScreenShot;
	}

	void OnError(string error)
	{
		Debug.Log ("Error : "+error);
	}

	void OnSuccess(string msg)
	{
		Debug.Log ("Success : "+msg);
	}

	void OnScreenShot(Texture2D tex2D)
	{
		// assign screenshot
		tex = tex2D;
	}

	public void TakeScreenshot()
    {
		StartCoroutine(TakeCapture()); // allows the image to be captured and saved while letting other GameObjects run
		PanelScreenShot.SetActive(false);//turns off the PanelScreenShot GameObject
		path1 += "screenshot"; // saved as the name of saved image in the shared folder
		path1 += System.Guid.NewGuid().ToString() + ".png"; // finds the located path in the computer
		ScreenCapture.CaptureScreenshot(path1, size);// saves image to path1 & size = quality & size of image
	}
	
	IEnumerator TakeCapture()
    {

		yield return new WaitForEndOfFrame();
		snapShot.GetFullScreenShot(ImageType.JPG);
		
		
		yield return new WaitForSeconds(1f);
		PanelScreenShot.SetActive(true);
		PanelPreview.SetActive(true);

		SaveScreenshot();
    }
	
	public void SaveScreenshot()
    {
		
		
		Sprite sp = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
		PreviewImage.GetComponent<Image>().sprite = sp;// converts the image "PreviewImage" to a sprite
		SumImage.GetComponent<Image>().sprite = sp;// converts the image "SumImage" to a sprite
		OrientationImage.GetComponent<Image>().sprite = sp;// converts the image "OrientationImage" to a sprite

	}


	
}
