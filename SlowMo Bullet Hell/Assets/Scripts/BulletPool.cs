using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour {

    public static BulletPool pool = null;
    public GameObject bulletPrefab1;
    public GameObject bulletPrefab2;
    public GameObject bulletPrefab3;

    public int jumlahPeluru = 1;
    public static int diff = 1;
    private bool diffHold = false;

    public static int time = 1;
    public static int timeHold = 1;

    public List<GameObject> listPeluru1;
    public List<GameObject> listPeluru2;
    public List<GameObject> listPeluru3;

    void Awake()
    {
        pool = this;
    }

    // Use this for initialization
    void Start () {
        for (int i = 0; i < 1; i++)
        {
            GameObject obj = Instantiate(bulletPrefab1);
            obj.transform.parent = transform;
            obj.SetActive(false);
            listPeluru1.Add(obj);
        }

        for (int i = 0; i < 0; i++)
        {
            GameObject obj = Instantiate(bulletPrefab2);
            obj.transform.parent = transform;
            obj.SetActive(false);
            listPeluru2.Add(obj);
        }

        for (int i = 0; i < 0; i++)
        {
            GameObject obj = Instantiate(bulletPrefab3);
            obj.transform.parent = transform;
            obj.SetActive(false);
            listPeluru3.Add(obj);
        }
	}

    public GameObject AmbilPeluru()
    {
        if (time != timeHold)
        {
            time = 0;
            timeHold = 0;
            diffHold = true;
            diff++;
        }

        int x = Random.Range(0, 3);

        switch (x)
        {
            case 0:
                for (int i = 0; i < listPeluru1.Count; i++)
                {
                    if (!listPeluru1[i].activeInHierarchy)
                    {
                        return listPeluru1[i].gameObject;
                    }
                }

                GameObject obj = Instantiate(bulletPrefab1);
                obj.transform.parent = transform;
                listPeluru1.Add(obj);
                return obj;

            case 1:
                if (diff % 3 == 0 && diffHold)
                {
                    obj = Instantiate(bulletPrefab2);
                    obj.transform.parent = transform;
                    listPeluru2.Add(obj);
                    diffHold = false;
                    return obj;
                }

                for (int i = 0; i < listPeluru2.Count; i++)
                {
                    if (!listPeluru2[i].activeInHierarchy)
                    {
                        return listPeluru2[i].gameObject;
                    }
                }

                break;

            case 2:
                if (diff % 2 == 0 && diffHold)
                {
                    obj = Instantiate(bulletPrefab3);
                    obj.transform.parent = transform;
                    listPeluru3.Add(obj);
                    diffHold = false;
                    return obj;
                }

                for (int i = 0; i < listPeluru3.Count; i++)
                {
                    if (!listPeluru3[i].activeInHierarchy)
                    {
                        return listPeluru3[i].gameObject;
                    }
                }

                break;
        }

        return null;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
