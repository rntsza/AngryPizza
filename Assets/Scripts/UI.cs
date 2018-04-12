using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

	public Text Score;
	
	// Use this for initialization
	void Start () {
		Score.text = "Score: 0";
	}
	
	// Update is called once per frame
	void Update () {
		Score.text = "Score: " + Score.ToString();
	}
}
