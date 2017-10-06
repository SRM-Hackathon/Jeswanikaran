using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerrot : MonoBehaviour {/*
	public static  bool rotate;
	Animator an;
	public GameObject pare;
	GameObject[] a=new GameObject[2];
	PolygonCollider2D p1,p2;
	public GameObject play5;
	// Use this for initialization
	//bool pop;
	void Start () {
		//pop = false;
		an=pare.GetComponent<Animator> ();
		a = GameObject.FindGameObjectsWithTag ("legl");
		p1 = a [0].GetComponent<PolygonCollider2D> ();
		p2 = a [1].GetComponent<PolygonCollider2D> ();
		rotate = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (an.GetCurrentAnimatorStateInfo (0).IsName ("buttoncollectionrotation"))
		{
			p1.enabled = false;
			p2.enabled = false;
		}else
		{
			p1.enabled = true;
			p2.enabled = true;
		}
	
}
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("legl")) {
			
			play5.GetComponent<AudioSource> ().Play ();	
		
			audio3.music.Pause ();
			audio4.music.Pause ();
			audio5.music.Pause ();
			/*audio17.music.Stop ();
			audio26.music.Stop ();*/
		/*	StartCoroutine("stopping");
		}
	}

	IEnumerator stopping(){

		an.SetTrigger ("New Trigger");
		yield return new WaitForSecondsRealtime (5.0f);
		audio3.music.Play ();
		audio4.music.Play ();
		audio5.music.Play ();

	}
*/
}
