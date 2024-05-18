using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject Light;
    bool flag = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)&&!flag)
        {
            Light.SetActive(true);
            flag = true;
        }
        else if (Input.GetKeyDown(KeyCode.F) &&flag)
        {
            Light.SetActive(false);
            flag = false;   
        }
    
    }
}
