using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control : MonoBehaviour
{
    public Animator animatorController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) {
            animatorController.SetTrigger("W");
        }
        if (Input.GetKeyDown(KeyCode.A)) {
            animatorController.SetTrigger("A");
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            animatorController.SetTrigger("S");
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            animatorController.SetTrigger("D");
        }
    }
}
