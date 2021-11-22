using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Interactable : MonoBehaviour
{
    public Button Level2, Level3;
    public GameObject Lock1, Lock2;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Spawn.level);
        if(Spawn.level<2){ 
            Level2.interactable=false; 
            Lock1.SetActive(true);
        }
        else{ 
            Level2.interactable=true; 
            Lock1.SetActive(false);
        }

        if(Spawn.level<3){ 
            Level3.interactable=false; 
            Lock2.SetActive(true);
        }
        else{ 
            Level3.interactable=true;
            Lock2.SetActive(false);
        }
    }

}
