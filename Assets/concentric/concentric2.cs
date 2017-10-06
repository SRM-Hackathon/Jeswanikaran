using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class concentric2 : MonoBehaviour {
	public GameObject hl1, hr1,spine,leg;
	float n;int mag;

	float dist1,dist2,diff;
	Rigidbody2D rb1;
	// Use this for initialization
	void Start () {
		mag = 100;
		rb1 = GetComponent<Rigidbody2D>();

	}

	// Update is called once per frame
	void Update () {


		dist1 = hl1.transform.position.y - leg.transform.position.y;
		//diff = hl1.transform.position.y - leg.transform.position.y;
		if(linere2.lol==true&&effectsmanager.effectsn==7)
			gameObject.transform.Rotate (0, 0, 100*dist1);
		if(effectsmanager.effectsn==7&&linere2.lol==false)
			gameObject.transform.rotation = Quaternion.Euler (0,0,360*dist1);
		/*n=mag*Mathf.Abs((hl1.transform.position.y-hr1.transform.position.y));
		if (hl1.transform.position.y > hr1.transform.position.y)
        {
			dist1 = hl1.transform.position.y - spine.transform.position.y;
			gameObject.transform.rotation = Quaternion.Euler (dist1, 0, 0);
        }
        else
        {	
			dist2 = hl1.transform.position - spine.transform.position;
			gameObject.transform.rotation = Quaternion.Euler (dist2, 0, 0);
            rb1.angularVelocity = -n;

        }*/
	}
}
