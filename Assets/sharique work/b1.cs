using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b1 : MonoBehaviour {

	public static bool touch1;
	public static Vector3 ball1;
	// Use this for initialization
	void Start () {
		ball1 = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	void  OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.CompareTag("Respawn"))
		touch1 = true;
	}

	void  OnTriggerStay2D(Collider2D other){
		if (other.gameObject.CompareTag ("Respawn")) {
			if (touch1)
				ball1 = gameObject.transform.position;
		}
	}

	void  OnTriggerExit2D(Collider2D other){
		if(other.gameObject.CompareTag("Respawn"))
		touch1 = false;
	}
}
