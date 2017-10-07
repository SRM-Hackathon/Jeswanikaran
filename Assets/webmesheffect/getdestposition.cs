using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getdestposition : MonoBehaviour {
   public static Vector2 dest;
    circle c;
	// Use this for initialization
	void Start () {
        c = GetComponent<circle>();
	}
	
	// Update is called once per frame
	void Update () {
        dest = new Vector2(c.a, c.b);
	}
}
