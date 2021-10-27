using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher2 : MonoBehaviour
{
     public void Start()
    {
        SceneManager.LoadScene("Field");
    }
    public void Back()
    {
        SceneManager.LoadScene("Main");
    }
}
