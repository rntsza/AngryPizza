using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Collections;

public class GameController : Pizza {

    float posX = 0;
    float posYmin = 0;
    float posYmax = 0;

    public GameObject Inimigo;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Instantiate(Inimigo, new Vector3(posX = transform.position.x, posYmin = transform.position.y, posYmax = transform.position.z), tiros.transform.rotation);
    }
}