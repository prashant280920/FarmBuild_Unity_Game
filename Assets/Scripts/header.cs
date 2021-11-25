using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class header : MonoBehaviour
{
    public GameObject item2x;
    public static bool item_use=false;
    public void use_item(){
        if(Main.item2x>0 && !item_use){
            Main.item2x--;
            item_use = true; 
            TextMeshProUGUI i = item2x.GetComponent<TextMeshProUGUI>();
            i.text = ": "+Main.item2x;
        }
        
    }
}
