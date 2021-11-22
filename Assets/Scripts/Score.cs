using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //public Spawn a;
    //public int t;
    public GameObject congo,buttonText,mainText;
    public int t;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Score"+ Spawn.level);
        Debug.Log("Score area"+ Spawn.area);
        t = 1;
        TextMeshProUGUI c = congo.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI mt = mainText.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI bt = buttonText.GetComponent<TextMeshProUGUI>();
        if(Spawn.level == 1){
            if(Spawn.area>124000){
                c.text = "Congratulation !! :)";
                mt.text = "You earned " + Spawn.area*500/1040000 + " points !!\n Hurrraayyy";
                if(header.item_use) t=2;
                else t=1;
                Main.total_score+=t*Spawn.area*500/1040000;
                bt.text = "Next Level!";
                // Spawn.level = 2;
            }else{
                c.text = "Opps !! :)";
                mt.text = "You earned " + Spawn.area*500/1040000 + " points < 200!!\n Try Again";
                bt.text = "Play Again !";
            } 
        }

        else if(Spawn.level == 2){
            if(Spawn.area>124000){
                c.text = "Congratulation !! :)";
                mt.text = "You earned " + Spawn.area*500/1040000 + " points !!\n Hurrraayyy";
                if(header.item_use) t=2;
                else t=1;
                Main.total_score+=t*Spawn.area*500/1040000;
                bt.text = "Next Level!";
                // Spawn.level = 3;
            }else{
                c.text = "Opps !! :)";
                mt.text = "You earned " + Spawn.area*500/1040000 + " points < 200!!\n Try Again";
                bt.text = "Play Again !";
            } 
        }

        else if(Spawn.level == 3){
            if(Spawn.area>80000){
                c.text = "Congratulation !! :)";
                mt.text = "You earned " + Spawn.area*500/1040000 + " points !!\n Congratulating for completing the game :)";
                if(header.item_use) t=2;
                else t=1;
                Main.total_score+=t*Spawn.area*500/1040000;
                
                bt.text = "Click Next";
            }else{
                c.text = "Opps !! :)";
                mt.text = "You earned " + Spawn.area*500/1040000 + " points < 200!!\n Try Again";
                bt.text = "Play Again !";
            } 
        }

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Area covered"+t);
        //Debug.Log("S"+Spawn.area);
    }
}
