using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleRing : MonoBehaviour {

	public GameObject prefab;
	public GameObject lh, rh;
	public GameObject sphere;
	float size;
	public ParticleSystem ps;


	// Use this for initialization
	void Start () {
		
		ps = GetComponent<ParticleSystem> ();
	}
	
	// Update is called once per frame
	void Update () {

		if((lh.transform.position.x>rh.transform.position.x)){

			size = Random.Range (1.0f, 2.0f);
			gameObject.transform.position = lh.transform.position;
			ps.startSize = size;
			ps.Play ();
			for (int i = 0; i < 10; i++){
				Instantiate(prefab, new Vector3(i * .3f, 0, 0), Quaternion.identity);
			}
				
	}
		if((rh.transform.position.z<=-0.2f)){
			size = Random.Range (1.0f, 5.0f);
			gameObject.transform.position = rh.transform.position;
			ps.startSize = size;
			ps.Play ();

		}
}
}
