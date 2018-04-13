using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Collections;

public class Pizza : MonoBehaviour {

	public GameObject tiros, tiro2, tiro3, tiro4;
	public GameObject pepperonis, azeitona;
	private float vel = 2.5f;
	public int azeiQt = 4;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");
		transform.Translate (new Vector3 (h * (Time.deltaTime * vel), v * (Time.deltaTime * vel), 0));
		// Tiros
		// Tiro Padrão
		if(Input.GetKey(KeyCode.Space)){
			Instantiate (pepperonis, new Vector3 (tiros.transform.position.x, tiros.transform.position.y, tiros.transform.position.z), tiros.transform.rotation);
		}
		if (Input.GetKeyDown(KeyCode.C) && azeiQt > 0){
			Instantiate (azeitona, new Vector3 (tiro4.transform.position.x, tiro4.transform.position.y, tiro4.transform.position.z), tiro4.transform.rotation);
			azeiQt--;
		}

	}
}