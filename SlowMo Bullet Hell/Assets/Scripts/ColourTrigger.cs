using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColourTrigger : MonoBehaviour {

	private Animator anim;
    public Slider slider;

    public static float con = 1;
    public static bool fast = false;
    public static bool slow = false;
    private float power = 5;

	// Use this for initialization
	void Start () {
		this.anim = GetComponent<Animator> ();
		anim.SetBool ("isBlue", false);
		anim.SetBool ("isRed", false);
	}

    public void slowButton()
    {
        if (power == 5) {
            slow = !slow;
            fast = false;
        }
    }

    public void fastButton()
    {
        fast = !fast;
        slow = false;
    }

    public void slowFastButton()
    {
        fast = false;
    }

    // Update is called once per frame
    void Update () {
        if (!slow)
        {
            power += Time.deltaTime;
        }

        if (power >= 5)
        {
            power = 5;
        }

		if (Input.GetKey (KeyCode.Space) || fast) {
			anim.SetBool ("isBlue", true);
			anim.SetBool ("isRed", false);
			Time.timeScale = 4;
			anim.speed = 0.5f;
			con = 0.5f;
		} else if (Input.GetKey (KeyCode.LeftShift) || slow && power >= 0) {
			anim.SetBool ("isBlue", false);
			anim.SetBool ("isRed", true);
			Time.timeScale = 1f;
			anim.speed = 2;
			con = 2;
            power -= Time.deltaTime * con;
		} else {
			anim.SetBool ("isBlue", false);
			anim.SetBool ("isRed", false);
			Time.timeScale = 2;
			con = 1;
			anim.speed = 1;
            slow = false;
            fast = false;
		}

        slider.value = power / 5f;
	}
}
