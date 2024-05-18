using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 

public class PlayerInventory : MonoBehaviour
{
    public int NumberofKeys { get; private set; }

    public UnityEvent<PlayerInventory> OnKeyCollected;

    public void KeyCollected()
    {
        NumberofKeys++;
        OnKeyCollected.Invoke(this);
    }
}
