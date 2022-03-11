using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour {

    private bool jalan = true;
    private float timer = 0;
    private Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        anim.SetTrigger("Live");

        if (jalan && timer > 3.1f) {
            transform.Translate(0, -20f * Time.deltaTime, 0);
        }


        if (transform.position.x > 3.5f || transform.position.x < -3.5f || transform.position.y > 5.5f || transform.position.y < -5.5f)
        {
            transform.position = gameObject.transform.parent.transform.position;
            jalan = true;
            timer = 0;
            anim.SetTrigger("Die");
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            transform.position = gameObject.transform.parent.transform.position;
            jalan = true;
            timer = 0;
            anim.SetTrigger("Die");
            gameObject.SetActive(false);
        }
    }
}
