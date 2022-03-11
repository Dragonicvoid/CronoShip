using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

    float hold = 1.5f;
    private Animator anim;
    private bool hold1;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {
        if (PlayerController1.life < 0)
        {
            anim.SetBool("coba", true);
        }
    }
}
