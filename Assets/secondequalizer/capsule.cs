using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsule : MonoBehaviour {
    public GameObject prefab,arc;
    Vector3 pos;
    float x, y,theta;
    public float r;
    GameObject[] capsules;
    int numberofobjects;
    public static float[] spectrum;
	// Use this for initialization
	void Start () {
        for (theta = 0; theta <= 3.14f; theta += 0.02f)
        {
            x = r * Mathf.Cos(theta - 3.14f);
            y = r * Mathf.Sin(theta);
            pos = new Vector3(x, y, 0) + arc.transform.position;

            Instantiate(prefab, pos, Quaternion.Euler(0, 0, -theta * 57 + 270));

        }
        capsules = GameObject.FindGameObjectsWithTag("capsule");
        numberofobjects = 158;
       
    }
	
	// Update is called once per frame
	void Update () {


         spectrum = AudioListener.GetSpectrumData(1024, 0, FFTWindow.Hamming);
        for (int a = 0; a < numberofobjects; a++)
        {
            Vector3 previousScale = capsules[a].transform.localScale;
            previousScale.y =5* spectrum[a] ;
			if(previousScale.y>0.5f)
				previousScale.y=5f*spectrum[a];
            capsules[a].transform.localScale = previousScale;
        }
    }
	void OnDisable(){
		for (int a = 0; a < numberofobjects; a++)
			Destroy (capsules [a]);


	}
}
