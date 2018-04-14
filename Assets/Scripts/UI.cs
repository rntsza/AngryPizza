using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

	public Text Score, tiro1, tiro2, tiro3, tiro4;

    // Use this for initialization
    void Start () {
		Score.text = "Score: 0";
		tiro1.text = ("Tiro 1: 0" );
		tiro2.text = ("Tiro 2: 0" );
		tiro3.text = ("Tiro 3: 0" );
		tiro4.text = ("Tiro 4: 0" );
		}
	
	// Update is called once per frame
	void Update () {
		Score.text = ("Score: " );
		//tiro1.text = ("Tiro 1: " + tiroinfinito );
		//tiro2.text = ("Tiro 2: " + azeiQt.ToString() );
		//tiro3.text = ("Tiro 3: " +  );
		//tiro4.text = ("Tiro 4: " +  );
	}
}
