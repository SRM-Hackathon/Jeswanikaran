using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avatarentry : MonoBehaviour {
	
	void OnEnable(){

		gameObject.transform.localScale = new Vector3 (0, 0, 0);

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.localScale.x < 1.09) {
			gameObject.transform.transform.localScale = gameObject.transform.transform.localScale + new Vector3 (0.01f, 0.01f, 0.01f);

		}
		if (gameObject.transform.rotation.eulerAngles.y < 180) {

			gameObject.transform.Rotate (new Vector3 (0, 1f, 0));
		} else {
			gameObject.transform.rotation=Quaternion.Euler(0, 180, 0);
		}
	}
}
