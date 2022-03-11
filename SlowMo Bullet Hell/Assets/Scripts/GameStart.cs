using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour {

    float hold = 1.5f;
    private Animator anim;
    private bool hold1 = true;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();	
	}

    private void OnEnable()
    {
        hold = 1.5f;
    }

    // Update is called once per frame
    void Update () {

        if (hold > 0)
        {
            hold -= Time.deltaTime;
        }else if(hold1)
        {
            gameObject.SetActive(false);
            hold1 = false;
        }
	}
}
