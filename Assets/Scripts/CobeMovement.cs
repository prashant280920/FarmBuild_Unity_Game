using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CobeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // QualitySettings.vSyncCount = 0;
        // Application.targetFrameRate = 25;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move(){
        float hor = Input.GetAxis("Horizontal"), ver = Input.GetAxis("Vertical");
        transform.position += new Vector3(2.5f*hor*Time.deltaTime,2.5f*ver*Time.deltaTime); 
    }
}
