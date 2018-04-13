using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Azeitona : MonoBehaviour {

	public float forca;
    public Rigidbody2D rb;
	public float zRotation;
	public GameObject azeitona;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb.AddForce(transform.up * forca);
        zRotation--;
        azeitona.transform.eulerAngles = new Vector3(0, 0, zRotation);


	}
}
