using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class End : MonoBehaviour
{
    public GameObject end;
    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUGUI e = end.GetComponent<TextMeshProUGUI>();
        e.text = "Your Extra Points are : "+Garage_Spawn.garage_area+"\nThank You For Playing ";
    }

}
