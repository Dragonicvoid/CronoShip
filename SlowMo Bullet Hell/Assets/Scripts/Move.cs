using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        
        transform.Translate (0, -2f * Time.deltaTime, 0);
        

        if (transform.position.x > 3.5f || transform.position.x < -3.5f || transform.position.y > 5.5f || transform.position.y < -5.5f)
        {
            gameObject.SetActive(false);
            transform.position = gameObject.transform.parent.transform.position;
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            transform.position = gameObject.transform.parent.transform.position;
        }
    }
}
