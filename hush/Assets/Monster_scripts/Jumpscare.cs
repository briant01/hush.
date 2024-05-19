using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JumpScare : MonoBehaviour
{

    public GameObject JumpScareImg;
    public AudioSource audioSource;

    public GameObject player;

    void Start()
    {
        JumpScareImg.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
      
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
        SceneManager.LoadScene(0);
    }

    


}
