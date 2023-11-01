using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip move;
    public AudioClip death;
    public Animator animatorController;
    // Start is called before the first frame update
    void Start()
    {
        this.audioSource = this.GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) {
            animatorController.SetTrigger("W");
            this.gameObject.transform.position+=new Vector3(0, 1, 0);
            this.audioSource.clip = move;
            this.audioSource.Play();
        }
        if (Input.GetKeyDown(KeyCode.A)) {
            animatorController.SetTrigger("A");
            this.gameObject.transform.position += new Vector3(-1, 0, 0);
            this.audioSource.clip = move;
            this.audioSource.Play();
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            animatorController.SetTrigger("S");
            this.gameObject.transform.position += new Vector3(0, -1, 0);
            this.audioSource.clip = move;
            this.audioSource.Play();
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            animatorController.SetTrigger("D");
            this.gameObject.transform.position += new Vector3(1, 0, 0);
            this.audioSource.clip = move;
            this.audioSource.Play();
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            animatorController.SetTrigger("Death");
            this.audioSource.clip = death;
            this.audioSource.Play();
        }
    }
}
