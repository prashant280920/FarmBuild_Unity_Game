using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Camera cameraComponent;
    public float zoomSize = 0.01f;
    // Start is called before the first frame update
    // void Start()
    // {
    //     cameraComponent = GetComponent<Camera>();
    // }

    // Update is called once per frame
    void Update()
    {
        CameraSizeZoomInZoomOut();
    }

    void CameraSizeZoomInZoomOut (){
        if(Input.GetKey(KeyCode.E)){
            cameraComponent.orthographicSize += zoomSize;
        }
        if(Input.GetKey(KeyCode.Q)){
            cameraComponent.orthographicSize -= zoomSize;
        }
    }
}
