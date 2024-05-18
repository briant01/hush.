using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
        
        if(playerInventory != null )
        {
            playerInventory.KeyCollected(); 
            gameObject.SetActive(false);
        }
    }
}
