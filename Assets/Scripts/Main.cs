using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Main : MonoBehaviour
{
    public static int total_score = 200, item2x = 2;

    public GameObject score, item;
    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUGUI s = score.GetComponent<TextMeshProUGUI>();
        s.text = "Score: "+total_score;
        TextMeshProUGUI i = item.GetComponent<TextMeshProUGUI>();
        i.text = "2X : "+item2x;
    }

    public void buy_item(){
        if(total_score>100){
            total_score-=100;
            item2x++;
            TextMeshProUGUI s = score.GetComponent<TextMeshProUGUI>();
            s.text = "Score: "+total_score;
            TextMeshProUGUI i = item.GetComponent<TextMeshProUGUI>();
            i.text = "2X : "+item2x;
        }
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
