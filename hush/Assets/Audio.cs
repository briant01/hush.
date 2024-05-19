using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public List<AudioClip> audioClips;
    public AudioClip currentClip;
    public AudioClip jumpscare;
    public AudioSource source;

    public float minWaitBetweenPlays = 30f;
    public float maxWaitBetweenPlays = 60f;
    public float waitTimeCountdown = -1f;

    void Start()
    {
        source = GetComponent<AudioSource>();

    }

    void Update()
    {
        if (!source.isPlaying)
        {
            if (waitTimeCountdown < 0f)
            {
                currentClip = audioClips[Random.Range(0, audioClips.Count)];
                source.clip = currentClip;
                source.Play();
                waitTimeCountdown = Random.Range(minWaitBetweenPlays, maxWaitBetweenPlays);
            }
            else
            {
                waitTimeCountdown -= Time.deltaTime;
            }
        }
    }
    public void Jumpscare()
    {
        source.clip = jumpscare;
        source.Play();
    }
}
