using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnim : MonoBehaviour {

    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (ColourTrigger.slow == true)
        {
            anim.SetBool("Slow", true);
        }
        else
        {
            anim.SetBool("Slow", false);
        }
	}
}
