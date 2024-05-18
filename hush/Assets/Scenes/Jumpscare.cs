using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpScare : MonoBehaviour
{

    public GameObject JumpScareImg;
    public AudioSource audioSource;

    void Start()
    {
        JumpScareImg.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ah");
        if (other.gameObject.tag == "Enemy")
        {
            JumpScareImg.SetActive(true);
            audioSource.Play();
            StartCoroutine(DisableImg());
        }

    }

    IEnumerator DisableImg()
    {
         yield return new WaitForSeconds(2);
         JumpScareImg.SetActive(false);
    }

    


}
