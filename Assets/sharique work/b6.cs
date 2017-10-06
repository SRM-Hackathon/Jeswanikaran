using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b6 : MonoBehaviour {

	public static bool touch6;
	public static Vector3 ball6;
	// Use this for initialization
	void Start () {
		ball6 = gameObject.transform.position;
	}

	// Update is called once per frame
	void Update () {

	}

	void  OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.CompareTag("Respawn"))
		touch6 = true;
	}

	void  OnTriggerStay2D(Collider2D other){
		if (other.gameObject.CompareTag ("Respawn")) {
			if (touch6)
				ball6 = gameObject.transform.position;
		}
	}

	void  OnTriggerExit2D(Collider2D other){
		if(other.gameObject.CompareTag("Respawn"))
		touch6 = false;
	}
}
