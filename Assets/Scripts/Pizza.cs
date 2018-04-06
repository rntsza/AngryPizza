using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Collections;

public class Pizza : MonoBehaviour {

	public GameObject pepperonis, tiros;
	private float vel = 2.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");
		transform.Translate (new Vector3 (h * Time.deltaTime, v * Time.deltaTime, 0));

		if(Input.GetKeyDown(KeyCode.Space)){
			Instantiate (pepperonis, new Vector3 (tiros.transform.position.x, tiros.transform.position.y, tiros.transform.position.z), tiros.transform.rotation);
		}
	}
}