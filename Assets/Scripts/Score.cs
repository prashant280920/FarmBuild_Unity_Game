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
        Debug.Log("Score area"+ Spawn.area*500/1040000);
        t = 1;
        TextMeshProUGUI c = congo.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI mt = mainText.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI bt = buttonText.GetComponent<TextMeshProUGUI>();
        if(Spawn.level == 1){
            if(header.item_use){
                    t = 2;
                    header.item_use = false;
                }
                else t=1;
            if(t*Spawn.area>124000){
                
                c.text = "Congratulation !! :)";
                mt.text = "You earned " + t*Spawn.area*500/1040000 + " points !!\n Hurrraayyy";
                
                Main.total_score+=t*Spawn.area*500/1040000;
                bt.text = "Next Level!";
                // Spawn.level = 2;
            }else{
                c.text = "Opps !! :)";
                mt.text = "You earned " + Spawn.area*500/1040000 + " points < 60!!\n Try Again";
                bt.text = "Play Again !";
            } 
        }

        else if(Spawn.level == 2){
            if(header.item_use){
                    t = 2;
                    header.item_use = false;
                }
                else t=1;
            if(t*Spawn.area>124000){
                
                c.text = "Congratulation !! :)";
                mt.text = "You earned " + t*Spawn.area*500/1040000 + " points !!\n Hurrraayyy";
                
                Main.total_score+=t*Spawn.area*500/1040000;
                bt.text = "Next Level!";
                // Spawn.level = 3;
            }else{
                c.text = "Opps !! :)";
                mt.text = "You earned " + Spawn.area*500/1040000 + " points < 60!!\n Try Again";
                bt.text = "Play Again !";
            } 
        }

        else if(Spawn.level == 3){
            if(header.item_use){
                    t = 2;
                    header.item_use = false;
                }
                else t=1;
            if(t*Spawn.area>80000){
                
                c.text = "Congratulation !! :)";
                mt.text = "You earned " + t*Spawn.area*500/1040000 + " points !!\n Congratulating for completing the game :)";
                
                Main.total_score+=t*Spawn.area*500/1040000;
                
                bt.text = "Main Menu";
            }else{
                c.text = "Opps !! :)";
                mt.text = "You earned " + Spawn.area*500/1040000 + " points < 38!!\n Try Again";
                bt.text = "Play Again !";
            } 
        }

    }

}
