using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBeam1 : MonoBehaviour {

    private int stop = 1;
    private bool jalan = true;
    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, -2f * Time.deltaTime * stop, 0);
        if (transform.position.y <= 3.5 && jalan)
        {
            stop = 0;
            jalan = false;

            for (int i = 0; i < gameObject.transform.childCount ; i++)
            {

                gameObject.transform.GetChild(i).gameObject.SetActive(true);
            }

            anim.SetTrigger("Die");
        }

        if (transform.position.y <= 3.5) {
            int x = 0;
            for (int i = 0; i < gameObject.transform.childCount; i++)
            {
                if (!gameObject.transform.GetChild(i).gameObject.activeInHierarchy)
                {
                    x++;
                }
                if (x == gameObject.transform.childCount)
                {
                    stop = 1;
                    jalan = true;
                    anim.SetTrigger("Live");
                    gameObject.SetActive(false);
                }
            }
        }
    }
}
