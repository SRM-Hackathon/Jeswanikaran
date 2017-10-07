using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spectrum1 : MonoBehaviour {
   
	bool exec;
        float x; int n;
        public GameObject prefab;
        public int numberOfObjects = 20;
    public GameObject[] cubes1,cube;
	public float[] xpos;
        public Material mat;
    spectrum s;
        // Use this for initialization
        void Start ()
        {
		exec = true;
		cube = new GameObject[100];
        s = this.gameObject.GetComponent<spectrum>();
            n = 0;
		int k = 0;
            for (int i = 0; i < numberOfObjects; i++)
            {
                n++;
                x = (float)(3.6 / numberOfObjects);
			   Vector3 pos = new Vector3(n * x, 2, 2);
			 Instantiate(prefab, pos, Quaternion.identity);
                Vector3 pos1 = new Vector3(-n * x, 2, 2);
			 Instantiate(prefab, pos1, Quaternion.identity);
			k = k + 2;

            }
           cubes1 = GameObject.FindGameObjectsWithTag("cubes1");
       
        
      /*  for (int b = 0; b < (2 * numberOfObjects); b++)
            {
                cubes1[b].GetComponent<MeshRenderer>().material = mat;


            }
*/
        }
	
	// Update is called once per frame
	void FixedUpdate () {
		if (effectsmanager.effectsn == 5.5f) {
			for (int b = 0; b < (2 * numberOfObjects); b++) {
				if(fourbutrot.materials!=null)
				cubes1 [b].GetComponent<MeshRenderer> ().material = fourbutrot.materials;

			}
		}
		if (effectsmanager.effectsn == 5.5f&&exec) {

			StartCoroutine ("strt");
			exec = false;

		}


    }
	IEnumerator strt(){
		yield return new WaitForSeconds (4f);
		for (int b = 0; b < (2 * numberOfObjects); b++)
		{
			//cubes1[b].GetComponent<MeshRenderer>().material = fourbutrot.materials;
			for (int c = 0; c < (2 * numberOfObjects); c++)
			{
				cubes1[c].SetActive(true);
			}

		}

	}

}
