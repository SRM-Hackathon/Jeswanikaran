using UnityEngine;
using System.Collections;

public class line : MonoBehaviour {

	//Color [] colors=new Color[4];
	private LineRenderer lineRenderer;
	public static Vector3[] inside;
	Material m;
	float starttime;
	Vector3 initpos;

	// Use this for initialization
	//void OnEnable(){
		//starttime = Time.time;



	//}
	void OnEnable () {
		initpos = gameObject.transform.position;
		starttime = Time.time;
		initpos = gameObject.transform.position;
		/*colors [0] = Color.yellow;
		colors [1] = Color.green;
		colors [2] = Color.white;
		colors [3] = Color.blue;*/
		lineRenderer = gameObject.GetComponent<LineRenderer> ();
		inside = new Vector3[20];

		StartCoroutine("makeline");
		m = linere2.m0;


	}
	
	// Update is called once per frame
	void Update () {

	}
	IEnumerator makeline() 
	{
		
		int b = 0;
		while (b < 1) {
			lineRenderer.SetVertexCount (20);
			lineRenderer.SetWidth (0.01f, 0.01f);
			//lineRenderer.SetColors (Color.green, Color.blue);



			for (int i = 0; i < 19; i++) {

				lineRenderer.GetComponent<LineRenderer>().materials[0] = linere2.m0;
				Vector2 k = 0.7f*Random.insideUnitCircle;
				inside [i] = new Vector3(k.x,k.y,0)+gameObject.transform.position;
				lineRenderer.SetPosition (i, inside [i]);

			}
			lineRenderer.SetPosition (19, inside [0]);

			yield return new WaitForSeconds (0.1f);
			//lineRenderer.material.shader = Shader.Find ("Particles");
			//lineRenderer.material.SetColor ("", Color.colors [Random.Range (0, 3)]);
		}
	}
	void FixedUpdate(){
		gameObject.GetComponent<Rigidbody2D> ().velocity = gameObject.transform.position ;
		if(Time.time>starttime+1f&&gameObject.transform.position!=initpos){
			gameObject.SetActive (false);
			gameObject.transform.position = initpos;



	}
}
}
