using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class domino : MonoBehaviour {

    public float theta_scale = 0.1f;             //Set lower to add more points

    public float angle;
    public GameObject prefab;
    public float radius;
    Vector3 pos;
    GameObject[] dominoes;
    int numberofobjects;
    // Use this for initialization
    void Start () {
 for(float theta=0;theta<=angle;theta+=theta_scale)
        {
            pos = this.gameObject.transform.position + new Vector3(radius * Mathf.Cos(theta-3.14f), radius * Mathf.Sin(theta));
            Instantiate(prefab, pos, Quaternion.Euler(0,0,-theta*57+270));
        }
        dominoes = GameObject.FindGameObjectsWithTag("domino");
        numberofobjects = (int)(angle / theta_scale + 1);
        for(int i=0;i<numberofobjects;i++)
        {

            
            Vector3 previousScale = dominoes[i].transform.localScale;
            previousScale.y = Random.Range(0.1f, 0.3f);
            dominoes[i].transform.localScale = previousScale;
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
