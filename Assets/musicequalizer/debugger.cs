using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debugger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (effectsmanager.effectsn == 5||effectsmanager.effectsn==6) {
			gameObject.SetActive (false);



		}

	}

}
