using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public int myNumber;
    private float minutes;
    private float seconds;
    private float time;
    public Text text;
    public Slider health;
    public static int maxLife;

    public static bool hold = true;
    public static bool hold1;
    public static bool hold2 = true;

    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (hold)
        {
            switch (GameManager1.noDiff)
            {
                case 0:
                    maxLife = 4;
                    hold = false;
                    break;
                case 1:
                    maxLife = 2;
                    hold = false;
                    break;
                case 2:
                    maxLife = 0;
                    hold = false;
                    break;
            }

            switch (GameManager1.noPesawat)
            {
                case 0:
                    obj1.SetActive(true);
                    hold = false;
                    break;
                case 1:
                    obj2.SetActive(true);
                    hold = false;
                    break;
                case 2:
                    obj3.SetActive(true);
                    hold = false;
                    break;
            }
        }
        if (ColourTrigger.con == 1)
        {
            time += Time.deltaTime * (0.5f);
        }
        else if (ColourTrigger.con == 2)
        {
            time += Time.deltaTime * (0.5f);
        }
        else
        {
            time += Time.deltaTime * (1f);
        }
        minutes = Mathf.Floor(time / 60);
        seconds = Mathf.Floor(time % 60);


        if (GameManager1.noDiff == 0)
        {
            if (Mathf.Floor(seconds) % 15 == 0)
            {
                BulletPool.timeHold++;
            }
        }else if (GameManager1.noDiff == 1)
        {
            if (Mathf.Floor(seconds) % 10 == 0)
            {
                BulletPool.timeHold++;
            }
        }
        else
        {
            if (Mathf.Floor(seconds) % 7 == 0)
            {
                BulletPool.timeHold++;
            }
        }

        text.text = minutes + " : " + seconds;


        switch (GameManager1.noPesawat)
        {
            case 0:
                health.value = (float)PlayerController1.health / 50f;
                break;
            case 1:
                health.value = (float)PlayerController3.health / 25f;
                break;
            case 2:
                health.value = (float)PlayerController2.health / 150f;
                break;
        }
    }

    public void nextLevel()
    {
        SceneManager.LoadScene(2);
    }

    public void prevLevel()
    {
        hold = true;
        SceneManager.LoadScene(1);
        GameManager1.hold = true;
        GameManager1.hold1 = true;
    }
}
