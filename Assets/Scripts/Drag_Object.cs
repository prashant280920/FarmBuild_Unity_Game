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
            // if(Input.GetKey(KeyCode.E)){
            //     Destroy(Rigidbody2D);
            // }
  
    }

    void FixedUpdate(){
        if(isDrag){
             if(Input.GetKey(KeyCode.Q)){
                transform.Rotate(Vector3.forward,speed*Time.deltaTime);
            }
            if((hor!=0 || ver!=0) && iscolide){
               // Debug.Log(isDrag);
                Vector2 position = rbody2D.position;
                position.x += 2.5f*hor*Time.deltaTime;
                position.y += 2.5f*ver*Time.deltaTime;
                //Debug.Log(position);
                rbody2D.MovePosition(position);
            }
             
        }
    }
    private void OnTriggerEnter2D(Collider2D collider){
        Debug.Log("Trigger");
        iscolide = false;
    }
}
