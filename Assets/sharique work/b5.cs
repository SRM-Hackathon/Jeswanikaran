using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b5 : MonoBehaviour {

	public static bool touch5;
	public static Vector3 ball5;
	// Use this for initialization
	void Start () {
		ball5 = gameObject.transform.position;
	}

	// Update is called once per frame
	void Update () {

	}

	void  OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.CompareTag("Respawn"))
		touch5 = true;
	}

	void  OnTriggerStay2D(Collider2D other){
		if (other.gameObject.CompareTag ("Respawn")) {
			if (touch5)
				ball5 = gameObject.transform.position;
		}
	}

	void  OnTriggerExit2D(Collider2D other){
		if(other.gameObject.CompareTag("Respawn"))
		touch5 = false;
	}
}
