using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xchange : MonoBehaviour {
    float ip;
    Vector3 rot;
    Rigidbody rb;
    public GameObject[] cube;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        
        rot = gameObject.transform.eulerAngles;
	}
	
	// Update is called once per frame
	void Update () {
		rb.isKinematic = false;
	}
    private void OnCollisionEnter(Collision collision)
    {
        {
            rb.velocity = new Vector3(0, 2, 0);
           // rb.isKinematic = true;
            rb.useGravity = false;
            gameObject.transform.eulerAngles = rot;
            // this.gameObject.transform.position = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y + (collision.gameObject.transform.localScale.y) / 2, collision.gameObject.transform.position.z);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        rb.velocity = new Vector3(0, 4, 0);
        rb.useGravity = true;

        gameObject.transform.eulerAngles = rot;
    }
	public void OnCollisionStay(Collision col){
		rb.velocity = new Vector3 (0, 4, 0);

	}
}
