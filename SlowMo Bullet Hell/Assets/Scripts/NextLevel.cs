using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

    float asd;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        asd += Time.deltaTime;

        if (asd > 0.5f)
        {
            SceneManager.LoadScene(1);
        }
	}
}
