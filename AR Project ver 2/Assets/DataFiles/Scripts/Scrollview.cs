
using UnityEngine;
using UnityEngine.UI;

public class Scrollview : MonoBehaviour
{
    private ScrollRect _scrollRect;

    [SerializeField] private scrollupdown _UpButton;
    [SerializeField] private scrollupdown _DownButton;
    [SerializeField] private scrollupdown _LeftButton;
    [SerializeField] private scrollupdown _RightButton;
    [SerializeField] private float scrollSpeed = 0.01f;
    void Start()
    {
        _scrollRect = GetComponent<ScrollRect>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_UpButton != null)
        {
            if (_UpButton.isDown)
            {
                ScrollUp();
            }
        }
        if (_DownButton != null)
        {
            if (_DownButton.isDown)
            {
                ScrollDown();
            }
        }
        if (_LeftButton != null)
        {
            if (_UpButton.isDown)
            {
                ScrollLeft();
            }
        }
        if (_RightButton != null)
        {
            if (_DownButton.isDown)
            {
                ScrollRight();
            }
        }
    }

    private void ScrollUp()
    {
        if(_scrollRect != null)
        {
            if(_scrollRect.verticalNormalizedPosition <= 1f)
            {
                _scrollRect.verticalNormalizedPosition += scrollSpeed;
            }
        }
    }
    private void ScrollDown()
    {
        if (_scrollRect != null)
        {
            if (_scrollRect.verticalNormalizedPosition >= 0f)
            {
                _scrollRect.verticalNormalizedPosition -= scrollSpeed;
            }
        }
    }
    private void ScrollLeft()
    {
        if (_scrollRect != null)
        {
            if (_scrollRect.verticalNormalizedPosition >= 0f)
            {
                _scrollRect.verticalNormalizedPosition -= scrollSpeed;
            }
        }
    }
    private void ScrollRight()
    {
        if (_scrollRect != null)
        {
            if (_scrollRect.verticalNormalizedPosition <= 1f)
            {
                _scrollRect.verticalNormalizedPosition += scrollSpeed;
            }
        }
    }

}
