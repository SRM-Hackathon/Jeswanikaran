using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonvibration : MonoBehaviour {
    Vector3 ip,fp;
    int i;
    public GameObject pare;
    Animator an;
    PolygonCollider2D thisp,p1, p2;
    buttonvibration bv;
    GameObject[] hands;
	bool fadee;
	// Use this for initialization
	void Start () {
		fadee = false;
        ip = this.gameObject.transform.position;
        thisp = GetComponent<PolygonCollider2D>();
        an = pare.GetComponent<Animator>();
        bv = GetComponent<buttonvibration>();
        hands = GameObject.FindGameObjectsWithTag("Respawn");
        p1 = hands[0].GetComponent<PolygonCollider2D>();
        p2 = hands[1].GetComponent<PolygonCollider2D>();
		StartCoroutine("fade");
	}
	
	// Update is called once per frame
	void Update () {
        if (an.GetCurrentAnimatorStateInfo(0).IsName("buttoncollectionrotation"))
        {
            p1.enabled = false;
            p2.enabled = false;
            thisp.enabled = false;
			fadee = false;

        }
        else
        {
            p1.enabled = true;
            p2.enabled = true;
            thisp.enabled = true;
        }

	}
    private void OnTriggerEnter2D(Collider2D collision)
	{if(collision.gameObject.CompareTag("Respawn")&&effectsmanager.effectsn<3)
		fadee = true;

     /*   if(collision.gameObject.CompareTag("Respawn"))
     	StartCoroutine("fade");
     	*/
    }
    private void OnTriggerStay2D(Collider2D other)
    {
		/*
        if(other.gameObject.CompareTag("Respawn"))
        StartCoroutine("fade");
        */
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {	/*
        if(collision.gameObject.CompareTag("Respawn"))
        this.gameObject.transform.position = ip;
        */fadee = false;
		//
		if(effectsmanager.effectsn<3&&!an.GetCurrentAnimatorStateInfo (0).IsName ("buttoncollectionrotation"))
		gameObject.transform.position = ip;
    }

    IEnumerator fade()
    {
		while (true) {yield return new WaitForSeconds (0.05f);
			if (fadee &&!an.GetCurrentAnimatorStateInfo (0).IsName ("buttoncollectionrotation")&&effectsmanager.effectsn<3) {
				
				fp.x = ip.x + Random.Range (0, 0.1f);
				fp.y = ip.y + Random.Range (0, 0.1f);
				fp.z = ip.z;
				this.gameObject.transform.position = fp;

			} else if (!an.GetCurrentAnimatorStateInfo (0).IsName ("buttoncollectionrotation")&&effectsmanager.effectsn<3)
				gameObject.transform.position = ip;

				

		}
    }
  
}
