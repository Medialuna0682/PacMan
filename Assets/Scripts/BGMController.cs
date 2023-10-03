using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip intro;
    public AudioClip normal;
    // Start is called before the first frame update
    void Start()
    {
        this.audioSource.clip = intro;
        this.audioSource.loop = false;
        this.audioSource.Play();
        StartCoroutine(WaitForAudioEnd());
    }

    IEnumerator WaitForAudioEnd() {
        while(this.audioSource.isPlaying) {
            yield return null;
        }
        this.audioSource.clip = normal;
        this.audioSource.loop = true;
        this.audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        // TODO
    }
}
