using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongManager : MonoBehaviour {

    private int random;
    public AudioClip clip1, clip2, clip3, clip4, clip5;
    private AudioSource song;

	// Use this for initialization
	void Start () {
        song = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        song.pitch = (1 / ColourTrigger.con);
        
        if (!song.isPlaying)
        {
            random = Random.Range(0, 5);
            
            switch (random)
            {
                case 0:
                    song.PlayOneShot(clip1);
                    break;
                case 1:
                    song.PlayOneShot(clip2);
                    break;
                case 2:
                    song.PlayOneShot(clip3);
                    break;
                case 3:
                    song.PlayOneShot(clip4);
                    break;
                case 4:
                    song.PlayOneShot(clip5);
                    break;
            }
        }
	}
}
