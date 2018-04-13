using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour {

	public AudioSource BGM;
	public AudioClip AudioSource;
	// Use this for initialization
    bool bmgScene1;
	bool startBMG;

	void Start () {
		BGM = GetComponent<AudioSource>();
        bmgScene1 = true;
	}
	
	// Update is called once per frame
	void Update () {
		   if (bmgScene1 == true && startBMG == true)
        {
            BGM.Play();
            startBMG = false;
        }
        if (bmgScene1 == false && startBMG == true)
        {
            BGM.Stop();
            startBMG = false;
		}
	}
    /* 
	void OnGUI()
    {
        bmgScene1 = GUI.Toggle(new Rect(10, 10, 100, 30), bmgScene1, "Play Music");
        if (GUI.changed)
        {
            startBMG = true;
        }
	}   */
}
