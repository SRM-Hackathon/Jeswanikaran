using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getoriginposition : MonoBehaviour {
    circle c;
     public static Vector2 origin;
	// Use this for initialization
	void Start () {
        c = this.GetComponent<circle>();
	}
	
	// Update is called once per frame
	void Update () {
        origin = new Vector2(c.a, c.b);
	}
}
