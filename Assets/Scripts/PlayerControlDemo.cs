using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlDemo : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip move;
    public AudioClip death;
    public Animator animatorController;
    public float timer = 0.0f;
    public int second = 0;
    public float speed = 1.0f;

    private Vector3 pointA;
    private Vector3 pointB;
    private Vector3 pointC;
    private Vector3 pointD;

    private float aStart = -1;
    private float bStart = -1;
    private float cStart = -1;
    private float dStart = -1;

    // Start is called before the first frame update
    void Start()
    {
        this.pointA = this.transform.position;
        this.pointB = this.pointA + new Vector3(5, 0, 0);
        this.pointC = this.pointB + new Vector3(0, -4, 0);
        this.pointD = this.pointC + new Vector3(-5, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.timer - this.second > 0) {
            this.second++;
            audioSource.clip = move;
            audioSource.Play();
        }
        if (this.second == 0) {
            this.animatorController.SetTrigger("D");
        }
        if (this.second > 0 && this.second < 6) {
            if (this.aStart == -1) {
                this.aStart = Time.time;
            }
            float dist = Vector3.Distance(this.transform.position, this.pointB);
            if (dist > 0.1f) {
                this.transform.position = Vector3.Lerp(this.pointA, this.pointB, (Time.time - this.aStart) / 5);
            } else {
                this.transform.position = this.pointB;
            }
        }
        if (this.second == 6) {
            this.animatorController.SetTrigger("S");
            this.aStart = -1;
        }
        if (this.second > 5 && this.second < 10) {
            if (this.bStart == -1) {
                this.bStart = Time.time;
            }
            float dist = Vector3.Distance(this.transform.position, this.pointC);
            if (dist > 0.1f) {
                this.transform.position = Vector3.Lerp(this.pointB, this.pointC, (Time.time - this.bStart) / 4);
            } else {
                this.transform.position = this.pointC;
            }
        }
        if (this.second == 10) {
            this.animatorController.SetTrigger("A");
            this.bStart = -1;
        }
        if (this.second > 9 && this.second < 15) {
            if (this.cStart == -1) {
                this.cStart = Time.time;
            }
            float dist = Vector3.Distance(this.transform.position, this.pointD);
            if (dist > 0.1f) {
                this.transform.position = Vector3.Lerp(this.pointC, this.pointD, (Time.time - this.cStart) / 5);
            } else {
                this.transform.position = this.pointD;
            }
        }
        if (this.second == 15) {
            this.animatorController.SetTrigger("W");
            this.cStart = -1;
        }
        if (this.second > 14 && this.second < 19) {
            if (this.dStart == -1) {
                this.dStart = Time.time;
            }
            float dist = Vector3.Distance(this.transform.position, this.pointA);
            if (dist > 0.1f) {
                this.transform.position = Vector3.Lerp(this.pointD, this.pointA, (Time.time - this.dStart) / 4);
            } else {
                this.transform.position = this.pointA;
            }
        }
        if (this.second == 19) {
            this.animatorController.SetTrigger("D");
            this.dStart = -1;
            this.second = 0;
            this.timer = 0;
        }
        this.timer += Time.deltaTime;
    }
}
