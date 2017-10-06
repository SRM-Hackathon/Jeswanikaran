using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b4 : MonoBehaviour {

	public static bool touch4;
	public static Vector3 ball4;
	// Use this for initialization
	void Start () {
		ball4 = gameObject.transform.position;
	}

	// Update is called once per frame
	void Update () {

	}

	void  OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.CompareTag("Respawn"))
		touch4 = true;
	}

	void  OnTriggerStay2D(Collider2D other){
		if (other.gameObject.CompareTag ("Respawn")) {
			if (touch4)
				ball4 = gameObject.transform.position;
		}
	}
	void  OnTriggerExit2D(Collider2D other){
		if(other.gameObject.CompareTag("Respawn"))
		touch4 = false;
	}
}
