﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubecolor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (effectsmanager.effectsn == 5.5f) {
			gameObject.GetComponent<MeshRenderer> ().enabled = true;
		}
		
	}
}
