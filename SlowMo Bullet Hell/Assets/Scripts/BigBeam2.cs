using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBeam2 : MonoBehaviour {

    private int stop = 1;
    private bool jalan = true;
    private Animator anim;
    private float timer = 0.2f;
    private int idx = 0;
    private bool hancur = true;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -2f * Time.deltaTime * stop, 0);
        if (transform.position.y <= 4 && jalan)
        {
            stop = 0;
            jalan = false;
            anim.SetTrigger("Die");
        }

        timer += Time.deltaTime;

        if (timer >= 0.1f && transform.position.y <= 4 && hancur)
        {
            gameObject.transform.GetChild(idx).gameObject.SetActive(true);
            idx++;
            timer = 0;

            if (idx == 40)
            {
                hancur = false;
                idx = 0;
            }
        }

        if (transform.position.y <= 4)
        {
            int x = 0;

            for (int i = 0; i < gameObject.transform.childCount; i++)
            {
                if (!gameObject.transform.GetChild(i).gameObject.activeInHierarchy)
                {
                    x++;
                }
            }

            if (x == gameObject.transform.childCount)
            {
                stop = 1;
                jalan = true;
                anim.SetTrigger("Live");
                gameObject.SetActive(false);
                idx = 0;
                hancur = true;
            }
        }
    }
}
