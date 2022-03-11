using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver1 : MonoBehaviour {

    public GameObject gameOver;
    public GameObject black;
    public GameObject bullet;

    private float timer = 0;

    // Use this for initialization
    void Start () {
        PlayerController1.life = GameManager.maxLife;
        PlayerController2.life = GameManager.maxLife;
        PlayerController3.life = GameManager.maxLife;
    }
	
	// Update is called once per frame
	void Update () {
        
        if (GameManager1.noPesawat == 0 ? PlayerController1.life < 0 : (GameManager1.noPesawat == 1 ? PlayerController3.life < 0 : PlayerController2.life < 0) && GameManager.hold2)
        {
            if (timer == 0)
            {
                print("gerak");
                black.SetActive(true);
                bullet.SetActive(false);
            }

            if (timer < 3)
            {
                timer += Time.deltaTime;
            }else
            {
                BulletPool.time = 1;
                BulletPool.timeHold = 1;
                gameOver.SetActive(true);
                GameManager.hold2 = false;
            }
        }
    }

    void prevLevel()
    {
        SceneManager.LoadScene(1);
    }
}
