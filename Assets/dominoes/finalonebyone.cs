using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalonebyone : MonoBehaviour {
    GameObject[] go;
	float i;
	public GameObject ps;
	// Use this for initialization
	void Start () {
		ps.SetActive (false);
		i = 0;
        
		for (int a = 0; a < 105; a++)
			go[a] = GameObject.FindGameObjectWithTag ("domino");
	}

    // Update is called once per frame
    void Update()
    {
		ps.SetActive (true);
		go[(int)(i)].SetActive(true);
		ps.transform.position = go [(int)i].transform.position;
		i+=0.1f;
        
         

    }
}
