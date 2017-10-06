using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b2 : MonoBehaviour {

	public static bool touch2;
	public static Vector3 ball2;
	// Use this for initialization
	void Start () {
		ball2 = gameObject.transform.position;
	}

	// Update is called once per frame
	void Update () {

	}

	void  OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("Respawn")) {
			touch2 = true;
		}
	}

	void  OnTriggerStay2D(Collider2D other){
		if (other.gameObject.CompareTag ("Respawn")) {
			if (touch2)
				ball2 = gameObject.transform.position;
		}
	}

	void  OnTriggerExit2D(Collider2D other){
		if (other.gameObject.CompareTag ("Respawn")) {
			touch2 = false;
		}
	}
}
