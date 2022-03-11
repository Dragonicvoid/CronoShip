using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager1 : MonoBehaviour {

    public static GameManager gm = null;

    public static int noPesawat = 0;
    public static int noDiff = 0;
    public static int maxLife = 0;
    public static bool hold = false;
    public static bool hold1 = true;

    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;

    void Awake()
    {
        if (gm == null)
        {
            DontDestroyOnLoad(this.gameObject);
        }
        else if (gm != this)
        {
            Destroy(this.gameObject);
        }
    }

    private void Update()
    {
        
    }

    public void Pesawat(int n)
    {
        noPesawat = n;
    }

    public void Difficulty(int n)
    {
        noDiff = n;
    }

    public void nextLevel()
    {
        GameManager.hold = true;
        SceneManager.LoadScene(2);
    }

    public void exit()
    {
        Application.Quit();
    }
}
