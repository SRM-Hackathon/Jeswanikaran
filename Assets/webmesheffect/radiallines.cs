using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radiallines : MonoBehaviour {
    LineRenderer lr; public float angle;
    Vector2 start, end;
    
	// Use this for initialization
	void Start () {
        lr = GetComponent<LineRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        start.x = getoriginposition.origin.x * Mathf.Cos(angle);
        start.y = getoriginposition.origin.y * Mathf.Sin(angle);
        end.x = getdestposition.dest.x * Mathf.Cos(angle);
        end.y = getdestposition.dest.y * Mathf.Sin(angle);
        lr.SetPosition(0, start);
        lr.SetPosition(1, end);
    }
}
