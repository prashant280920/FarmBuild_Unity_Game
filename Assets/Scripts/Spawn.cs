using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    private GameObject[] prefabs;
    public int objects;
    public GameObject objectLeftText, score, item2x;
    private int randomInt;
    private Vector2 mousePos;
    private bool hold;
    public static int area;
    public static int level = 1;
    void Start()
    {
        hold = false;
        Debug.Log(level);
        area = 0;
        TextMeshProUGUI olt = objectLeftText.GetComponent<TextMeshProUGUI>();
        olt.text = "Object Left: "+objects;
        TextMeshProUGUI s = score.GetComponent<TextMeshProUGUI>();
        s.text = "Score: "+Main.total_score;
        TextMeshProUGUI i = item2x.GetComponent<TextMeshProUGUI>();
        i.text = "2X : "+Main.item2x;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.R) && hold == false){
            hold = true;
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(objects>0 && mousePos.x<2 && mousePos.x>-9 && mousePos.y<3.5 && mousePos.y>-2.7) spawn(mousePos);
        }
        else if(!Input.GetKey(KeyCode.R)) hold = false;
    }
    void spawn(Vector2 mousePos){   
        randomInt = Random.Range(0, prefabs.Length);
        
        areaCalculation(randomInt);
        Debug.Log(area);
        Instantiate(prefabs[randomInt], mousePos, Quaternion.identity);
        objects = objects-1;
        TextMeshProUGUI olt = objectLeftText.GetComponent<TextMeshProUGUI>();
        olt.text = "Object Left: "+objects;
    }

    void areaCalculation(int i){
        if(level==1){
            if(randomInt==i) area+=65144;
            else if(randomInt==i) area+=31144;
            else if(randomInt==i) area+=28600;
            else if(randomInt==i) area+=73170;
            else if(randomInt==i) area+=10000;
            else if(randomInt==i) area+=10200;
        }
        else if(level==2){
            if(randomInt==i) area+=65144;
            else if(randomInt==i) area+=31144;
            else if(randomInt==i) area+=28600;
            else if(randomInt==i) area+=73170;
            else if(randomInt==i) area+=10000;
            else if(randomInt==i) area+=10200;
        }
        else if(level==3){
            if(randomInt==i) area+=65144;
            else if(randomInt==i) area+=31144;
            else if(randomInt==i) area+=28600;
            else if(randomInt==i) area+=73170;
            else if(randomInt==i) area+=10000;
            else if(randomInt==i) area+=10200;
        }
    }
}
