using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triangle : MonoBehaviour {

	public GameObject line1,line2,line3;


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (linere2.hg) {
			line1.SetActive (true);
			line2.SetActive (true);
			line3.SetActive (true);


		} else {

			line1.SetActive (false);
			line2.SetActive (false);
			line3.SetActive (false);
		}
	}
}
