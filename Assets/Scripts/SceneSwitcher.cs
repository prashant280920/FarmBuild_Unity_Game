using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    public void Play()
    {
        SceneManager.LoadScene("ChooseField");
    }
    public void LoadScene(string screenName){
        if(screenName=="Field"){ Spawn.level=1; }
        SceneManager.LoadScene(screenName);
    }
    public void LevelSwitch(){
        Debug.Log("Screen"+ Spawn.level);
        Debug.Log("Screen area"+ Spawn.area);
        if(Spawn.level == 1){
            if(Spawn.area > 124000){
               Spawn.level = 2;
               Spawn.area = 0;
               SceneManager.LoadScene("2"); 
            }else{
                Spawn.level = 1;
                Spawn.area = 0;
                SceneManager.LoadScene("Field");
            }
        }
        else if(Spawn.level == 2){
            if(Spawn.area > 124000){
               Spawn.level = 3;
               Spawn.area = 0;
               SceneManager.LoadScene("3"); 
            }else{
                Spawn.level = 2;
                Spawn.area = 0;
                SceneManager.LoadScene("2");
            }
        }
        else if(Spawn.level == 3){

            if(Spawn.area > 80000){
            //    Spawn.level = 3;
               Spawn.area = 0;
               SceneManager.LoadScene("Main"); 
            }else{
                // Spawn.level = 3;
                Spawn.area = 0;
                SceneManager.LoadScene("Choose");
            }
        }
    }
    public void Exit()
    {
        Application.Quit();
    }
}
