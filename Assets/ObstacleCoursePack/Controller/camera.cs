using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Camera Startcamera;
    public Camera MainCamera;
    // Start is called before the first frame update
    void Start()
    {
        Startcamera.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetKeyDown("space"))
    {
        Startcamera.enabled = false;
        MainCamera.enabled = true;
    }
    }
}
