using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour {

	[Header("Player Stats")]
	public static int health;
    public static int max = 50;
    public static int life;
    public static float speed = 5;
    public static float invi = 2;
    private int inviint = 0;
    private int multi;

	private float timer;
    private float timer2 = 0;
    private Vector3 target;
	private Animator anim;
	[HideInInspector]
	public Collider monsterCollider;
	public static Transform myPosition;

    private void Start()
    {
        life = GameManager.maxLife;
        GameManager.hold2 = true;
    }

    void OnEnable(){
        invi = 2;
        health = 50;
		myPosition = transform;
		anim = GetComponent<Animator> ();
		target = transform.position;
	}

    void Update(){
        multi = 1;

        if (life < 0)
        {
            gameObject.SetActive(false);
            return;
        }

        if (invi >= 0)
        {
            invi -= Time.deltaTime;
        }
        else
        {
            inviint = 1;
            anim.SetBool("Done", true);
        }

        if (health <= 0)
        {
            Vector3 spawn = new Vector3(0.01f, -3.83f, 0);
            gameObject.transform.position = spawn;
            health = max;
            invi = 3f;
            target = gameObject.transform.position;
            anim.SetBool("Done", false);
            inviint = 0;
            life--;
        }

        if (Input.GetMouseButton (0)){
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			RaycastHit hit;
			if(Physics.Raycast(ray, out hit, 1000)){
				target = hit.point;
			}

            if (target.y >= 3.5)
            {
                multi = 2;
                target = gameObject.transform.position;
            }
		}
		MoveObject ();
	}

	void MoveObject(){
		if(transform.position == target){
			return;
		}

        if (health <= 0)
        {
            return;
        }

		transform.position = Vector3.Lerp (transform.position, target * multi, speed * Time.deltaTime * ColourTrigger.con * 0.5f);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Peluru")
        {
            health -= 5 * inviint;
        }

        if (collision.gameObject.tag == "PeluruLemah")
        {
            health -= 1 * inviint;
        }

        if (collision.gameObject.tag == "PeluruKuat")
        {
            health -= 20 * inviint;
        }
    }
}
