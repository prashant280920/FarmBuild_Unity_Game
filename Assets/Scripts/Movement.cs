using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float xspeed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();            
    }

    void Move(){
        if(Input.GetKey(KeyCode.D)){
            transform.position += new Vector3(xspeed, 0, 0);
        }
        if(Input.GetKey(KeyCode.A)){
            transform.position -= new Vector3(xspeed, 0, 0);
        }
        if(Input.GetKey(KeyCode.W)){
            transform.position += new Vector3(0, 0.05f, 0);
        }
        if(Input.GetKey(KeyCode.S)){
            transform.position -= new Vector3(0, 0.05f, 0);
        }
    }
}
