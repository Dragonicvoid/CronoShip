using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    private float timer = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer >= (3f - (BulletPool.diff * 0.07f) < 1 ? 1 : (3f - (BulletPool.diff * 0.07f))))
        {
            GameObject peluru = BulletPool.pool.AmbilPeluru();
            if (peluru == null)
            {
                return;
            }

            int x = Random.Range(-6 , 6);
            Vector3 hold = new Vector3(transform.position.x + (x * 0.5f), gameObject.transform.position.y , 0);
            peluru.transform.position = hold;
            peluru.SetActive(true);
            timer = 0;
        }
	}
}
