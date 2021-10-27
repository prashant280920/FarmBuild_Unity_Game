using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    private GameObject[] prefabs;
    public int objects;
    private int randomInt;
    private Vector2 mousePos;
    private bool hold;
    // Start is called before the first frame update
    void Start()
    {
        hold = false;
        objects = 10;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(hold);
        if(Input.GetKey(KeyCode.R) && hold == false){
           // Debug.Log("hi");
            hold = true;
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(objects>0 && mousePos.x<2 && mousePos.x>-9 && mousePos.y<3.5 && mousePos.y>-2.7) spawn(mousePos);
        }
        else if(!Input.GetKey(KeyCode.R)) hold = false;
        // foreach(KeyCode kcode in System.Enum.GetValues(typeof(KeyCode)))
        // {   
        //     if (Input.GetKey(kcode))
        //         // KeyCode s = Alpha1; 
        //         // if(kcode == 1){
        //         //     Debug.Log(1);
        //         // }
        //         Debug.Log("KeyCode down: " + kcode);
        // }
        //Debug.Log( Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }
    void spawn(Vector2 mousePos){
        
        randomInt = Random.Range(0, prefabs.Length);
        Instantiate(prefabs[randomInt], mousePos, Quaternion.identity);
        objects = objects-1;
    }
}
