using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlaneNow : MonoBehaviour {

    public GameObject button;
    public GameObject button1;
    public GameObject button2;

    private bool start;
    private int hold;

    // Use this for initialization
    void Start()
    {
        hold = GameManager1.noDiff;
        start = true;
    }

    // Update is called once per frame
    void Update()
    {
            GameObject eventSystem = GameObject.Find("EventSystem");
            switch (GameManager1.noPesawat)
            {
                case 0:
                    eventSystem.GetComponent<EventSystem>().SetSelectedGameObject(button);
                    start = false;
                    break;
                case 1:
                    eventSystem.GetComponent<EventSystem>().SetSelectedGameObject(button1);
                    start = false;
                    break;
                case 2:
                    eventSystem.GetComponent<EventSystem>().SetSelectedGameObject(button2);
                    start = false;
                    break;
            }
    }
}
