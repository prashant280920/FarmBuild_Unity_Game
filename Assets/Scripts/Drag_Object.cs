using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag_Object : MonoBehaviour{
    private bool isDrag;
    public Vector3 startRotation;
    public int speed;
    Rigidbody2D rbody2D;
    float hor, ver;
    bool iscolide;
    public void OnMouseDown(){
        isDrag = true;   
    }
    
    public void OnMouseUp(){
        isDrag = false;
    }
    void Start(){
        rbody2D = GetComponent<Rigidbody2D>();
        transform.eulerAngles = startRotation;
        speed = 35;
        iscolide = true;
    }
    
   
    void Update(){
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
    }

    void FixedUpdate(){
        if(isDrag){
            if(Input.GetKey(KeyCode.Q)){
                rbody2D.bodyType = RigidbodyType2D.Kinematic;
                transform.Rotate(Vector3.forward,speed*Time.deltaTime);
            }
            if((hor!=0 || ver!=0) && iscolide){
                rbody2D.bodyType = RigidbodyType2D.Dynamic;
                Vector2 position = rbody2D.position;
                position.x += 2.5f*hor*Time.deltaTime;
                position.y += 2.5f*ver*Time.deltaTime;
                rbody2D.MovePosition(position);
            }
        }
        if(Input.GetKey(KeyCode.E)){    
            rbody2D.bodyType = RigidbodyType2D.Static;
        }
    }

}
