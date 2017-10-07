using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meshanimdj : MonoBehaviour {
	public GameObject webmesh;
	Animator an;
	public int n;
	// Use this for initialization
	void Start () {
		an = webmesh.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Respawn"))
			{
			if (n == 1)
				an.SetTrigger ("1");
			else if (n == 2)
				an.SetTrigger ("2");
			else if (n == 3)
				an.SetTrigger ("3");
			else if (n == 4)
				an.SetTrigger ("4");
		}
	}
	private void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Respawn"))
			an.SetTrigger ("empty");
	}
}
