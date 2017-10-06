using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b3 : MonoBehaviour {

	public static bool touch3;
	public static Vector3 ball3;
	// Use this for initialization
	void Start () {
		ball3 = gameObject.transform.position;
	}

	// Update is called once per frame
	void Update () {

	}

	void  OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.CompareTag("Respawn"))
		touch3 = true;
	}

	void  OnTriggerStay2D(Collider2D other){
		if (other.gameObject.CompareTag ("Respawn")) {
			if (touch3)
				ball3 = gameObject.transform.position;
		}
	}
	void  OnTriggerExit2D(Collider2D other){
		if(other.gameObject.CompareTag("Respawn"))
		touch3 = false;
	}
}
