using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Garage_Spawn : MonoBehaviour
{
    [SerializeField]
    private GameObject[] prefabs;
    public int objects;
    public GameObject objectLeftText, score, item2x;
    // public GameObject objectLeftText;
    private int randomInt;
    private Vector2 mousePos;
    private bool[] hold;
    public static int garage_area;
    // public static int level = 1;
    void Start()
    {
        hold = new bool[8];
        for(int i=0; i<8; i++) hold[i] = false;
        // Debug.Log(level);
        garage_area = 0;
        TextMeshProUGUI olt = objectLeftText.GetComponent<TextMeshProUGUI>();
        olt.text = ": "+objects;
        TextMeshProUGUI s = score.GetComponent<TextMeshProUGUI>();
        s.text = ": "+Main.total_score;
        TextMeshProUGUI item = item2x.GetComponent<TextMeshProUGUI>();
        item.text = ": "+Main.item2x;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Alpha1) && hold[0] == false){
            hold[0] = true;
            garage_area+=100;
            spawn(0);
        }
        else if(!Input.GetKey(KeyCode.Alpha1)) hold[0] = false;
        
        if(Input.GetKey(KeyCode.Alpha2) && hold[1] == false){
            hold[1] = true;
            garage_area+=100;
            spawn(1);
        }
        else if(!Input.GetKey(KeyCode.Alpha2)) hold[1] = false;
        
        if(Input.GetKey(KeyCode.Alpha3) && hold[2] == false){
            hold[2] = true;
            garage_area+=100;
            spawn(2);
        }
        else if(!Input.GetKey(KeyCode.Alpha3)) hold[2] = false;
        
        if(Input.GetKey(KeyCode.Alpha4) && hold[3] == false){
            hold[3] = true;
            garage_area+=100;
            spawn(3);
        }
        else if(!Input.GetKey(KeyCode.Alpha4)) hold[3] = false;
        
        if(Input.GetKey(KeyCode.Alpha5) && hold[4] == false){
            hold[4] = true;
            garage_area+=100;
            spawn(4);
        }
        else if(!Input.GetKey(KeyCode.Alpha5)) hold[4] = false;
        
        if(Input.GetKey(KeyCode.Alpha6) && hold[5] == false){
            hold[5] = true;
            garage_area+=100;
            spawn(5);
        }
        else if(!Input.GetKey(KeyCode.Alpha6)) hold[5] = false;
        
        if(Input.GetKey(KeyCode.Alpha7) && hold[6] == false){
            hold[6] = true;
            garage_area+=200;
            spawn(6);
        }
        else if(!Input.GetKey(KeyCode.Alpha7)) hold[6] = false;
        
        if(Input.GetKey(KeyCode.Alpha8) && hold[7] == false){
            hold[7] = true;
            garage_area+=200;
            spawn(7);
        }
        else if(!Input.GetKey(KeyCode.Alpha8)) hold[7] = false;
    }

    void spawn(int i){
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(mousePos);
        if(objects>0 && mousePos.x<2 && mousePos.x>-9 && mousePos.y<3.5 && mousePos.y>-2.7){
            Instantiate(prefabs[i], mousePos, Quaternion.identity);
            objects = objects - 1;
            TextMeshProUGUI olt = objectLeftText.GetComponent<TextMeshProUGUI>();
        olt.text = ": "+objects;
        }
    }
}
