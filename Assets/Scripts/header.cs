using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class header : MonoBehaviour
{
    public GameObject item2x;
    public static bool item_use;
    public void use_item(){
        if(Main.item2x>0){
            Main.item2x--;
            item_use = true; 
            TextMeshProUGUI i = item2x.GetComponent<TextMeshProUGUI>();
            i.text = "2X : "+Main.item2x;
        }
        
    }
}
