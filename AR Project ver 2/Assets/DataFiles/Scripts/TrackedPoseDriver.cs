using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackedPoseDriver : MonoBehaviour
{
    private TrackedPoseDriver trackedPoseDriver;
    private void Start()
    {
        trackedPoseDriver = GetComponent<TrackedPoseDriver>();
    }

    // Update is called once per frame
    private void Update()
    {
   
    Vector3 position = transform.position;
    Quaternion rotation = transform.rotation;

    // Use the tracked position and rotation data
    // ...
    }
}
