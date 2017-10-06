using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b7 : MonoBehaviour {

	public static bool touch7;
	public static Vector3 ball7;
	// Use this for initialization
	void Start () {
		ball7 = gameObject.transform.position;
	}

	// Update is called once per frame
	void Update () {

	}

	void  OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.CompareTag("Respawn"))
		touch7 = true;
	}

	void  OnTriggerStay2D(Collider2D other){
		if (other.gameObject.CompareTag ("Respawn")) {
			if (touch7)
				ball7 = gameObject.transform.position;
		}
	}

	void  OnTriggerExit2D(Collider2D other){
		if(other.gameObject.CompareTag("Respawn"))
		touch7 = false;
	}
}
