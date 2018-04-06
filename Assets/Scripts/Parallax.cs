using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour {

	public float vel = 0.1f;
	public Renderer quad;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 offset = new Vector2 (vel * Time.deltaTime, 0);
		quad.material.mainTextureOffset += offset;
	}
}
