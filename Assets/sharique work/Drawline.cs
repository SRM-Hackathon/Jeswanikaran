using UnityEngine;
using System.Collections;

public class Drawline : MonoBehaviour {

	//AudioSource sound;

	//public LineRenderer[] lineRenderer=new LineRenderer[5];
	public static int linesformed;
	public static bool executed;
	//bool[] executed = new bool[21];
	public GameObject[] concentriccircle = new GameObject[15];

	//public LineRenderer lr1,lr2,lr3,lr4,lr5;

	void Start()
	{executed = false;
		linesformed = 0;
	//	sound = GetComponent<AudioSource> ();

		//for(int i=0;i<5;i++)
		//lineRenderer[i].SetWidth (0.05f, 0.05f);

		//StartCoroutine ("changecolor1");
		
	}

	void Update()
	{/*
		if (b1.touch1 && b2.touch2&&executed[0])
		{	//linesformed++;
			lineRenderer[linesformed].SetPosition (0, b1.ball1);
			lineRenderer[linesformed].SetPosition (1, b2.ball2);
			linesformed++;
			//sound.Play ();
			//linesformed++;
			executed [0] = false;
	    }
		if (b1.touch1 && b3.touch3&&executed[1])
		{
			
			lineRenderer[linesformed].SetPosition (0, b1.ball1);
			lineRenderer[linesformed].SetPosition (1, b3.ball3);
			//sound.Play ();
			linesformed++;
			executed [1] = false;
		}
		if (b1.touch1 && b4.touch4&&executed[2])
		{
			lineRenderer[linesformed].SetPosition (0, b1.ball1);
			lineRenderer[linesformed].SetPosition (1, b4.ball4);
			//sound.Play ();
			linesformed++;
			executed [2] = false;
		}
		if (b1.touch1 && b5.touch5&&executed[3])
		{
			lineRenderer[linesformed].SetPosition (0, b1.ball1);
			lineRenderer[linesformed].SetPosition (1, b5.ball5);
			//sound.Play ();
			linesformed++;
			executed [3] = false;
		}
		if (b1.touch1 && b6.touch6&&executed[4])
		{
			lineRenderer[linesformed].SetPosition (0, b1.ball1);
			lineRenderer[linesformed].SetPosition (1, b6.ball6);
			//sound.Play ();
			linesformed++;
			executed [4] = false;
		}
		if (b1.touch1 && b7.touch7&&executed[5])
		{
			lineRenderer[linesformed].SetPosition (0, b1.ball1);
			lineRenderer[linesformed].SetPosition (1, b7.ball7);
			//sound.Play ();
			linesformed++;
			executed [5] = false;
		}
		if (b2.touch2 && b3.touch3&&executed[6])
		{
			lineRenderer[linesformed].SetPosition (0, b2.ball2);
			lineRenderer[linesformed].SetPosition (1, b3.ball3);
			//sound.Play ();
			linesformed++;
			executed [6] = false;

		}if (b2.touch2 && b4.touch4&&executed[7])
		{
			lineRenderer[linesformed].SetPosition (0, b2.ball2);
			lineRenderer[linesformed].SetPosition (1, b4.ball4);
			//sound.Play ();
			linesformed++;
			executed [7] = false;

		}if (b2.touch2 && b5.touch5&&executed[8])
		{
			lineRenderer[linesformed].SetPosition (0, b2.ball2);
			lineRenderer[linesformed].SetPosition (1, b5.ball5);
			//sound.Play ();
			linesformed++;
			executed [8] = false;

		}if (b2.touch2 && b6.touch6&&executed[9])
		{
			lineRenderer[linesformed].SetPosition (0, b2.ball2);
			lineRenderer[linesformed].SetPosition (1, b6.ball6);
			//sound.Play ();
			linesformed++;
			executed [9] = false;
		}if (b2.touch2 && b7.touch7&&executed[10])
		{
			lineRenderer[linesformed].SetPosition (0, b2.ball2);
			lineRenderer[linesformed].SetPosition (1, b7.ball7);
			//sound.Play ();
			linesformed++;
			executed [10] = false;
		}if (b3.touch3 && b4.touch4&&executed[11])
		{
			lineRenderer[linesformed].SetPosition (0, b3.ball3);
			lineRenderer[linesformed].SetPosition (1, b4.ball4);
			//sound.Play ();
			linesformed++;
			executed [11] = false;
		}if (b3.touch3 && b5.touch5&&executed[12])
		{
			lineRenderer[linesformed].SetPosition (0, b3.ball3);
			lineRenderer[linesformed].SetPosition (1, b5.ball5);
			//sound.Play ();
			linesformed++;
			executed [12] = false;
		}if (b3.touch3 && b6.touch6&&executed[13])
		{
			lineRenderer[linesformed].SetPosition (0, b3.ball3);
			lineRenderer[linesformed].SetPosition (1, b6.ball6);
			//sound.Play ();
			linesformed++;
			executed [13] = false;
		}if (b3.touch3 && b7.touch7&&executed[14])
		{
			lineRenderer[linesformed].SetPosition (0, b3.ball3);
			lineRenderer[linesformed].SetPosition (1, b7.ball7);
			//sound.Play ();
			linesformed++;
			executed [14] = false;
		}if (b4.touch4 && b5.touch5&&executed[15])
		{
			lineRenderer[linesformed].SetPosition (0, b4.ball4);
			lineRenderer[linesformed].SetPosition (1, b5.ball5);
			////sound.Play ();
			linesformed++;
			executed [15] = false;
		}if (b4.touch4 && b6.touch6&&executed[16])
		{
			lineRenderer[linesformed].SetPosition (0, b4.ball4);
			lineRenderer[linesformed].SetPosition (1, b6.ball6);
			//sound.Play ();
			linesformed++;
			executed [16] = false;
		}if (b4.touch4 && b7.touch7&&executed[17])
		{
			lineRenderer[linesformed].SetPosition (0, b4.ball4);
			lineRenderer[linesformed].SetPosition (1, b7.ball7);
			//sound.Play ();
			linesformed++;
			executed [17] = false;
		}if (b5.touch5 && b6.touch6&&executed[18])
		{
			lineRenderer[linesformed].SetPosition (0, b5.ball5);
			lineRenderer[linesformed].SetPosition (1, b6.ball6);
			//sound.Play ();
			linesformed++;
			executed [18] = false;
		}if (b5.touch5 && b7.touch7&&executed[19])
		{
			lineRenderer[linesformed].SetPosition (0, b5.ball5);
			lineRenderer[linesformed].SetPosition (1, b7.ball7);
			//sound.Play ();
			linesformed++;
			executed [19] = false;
		}if (b6.touch6 && b7.touch7&&executed[20])
		{
			lineRenderer[linesformed].SetPosition (0, b6.ball6);
			lineRenderer[linesformed].SetPosition (1, b7.ball7);
		//	sound.Play ();
			linesformed++;
			executed [20] = false;
		}*/
		//Debug.Log (linesformed);
		if(!executed)
		switch (linesformed) {
		case 0:
			break;
			case 1:
		//	if (!(concentriccircle [0].transform.rotation.z > 180))
				concentriccircle [0].GetComponent<Animation> ().enabled = true;
				concentriccircle [5].GetComponent<Animation> ().enabled = true;
				concentriccircle [10].GetComponent<Animation> ().enabled = true;
				concentriccircle [0].GetComponent<Animation> ().Play ();
				concentriccircle [5].GetComponent<Animation> ().Play ();
				concentriccircle [10].GetComponent<Animation> ().Play ();
				executed = true;
			break;
		case 2:
			//if(!(concentriccircle[1].transform.rotation.z>180))
			concentriccircle [1].GetComponent<Animation> ().enabled = true;
			concentriccircle [6].GetComponent<Animation> ().enabled = true;
			concentriccircle [11].GetComponent<Animation> ().enabled = true;
			concentriccircle [1].GetComponent<Animation> ().Play ();
			concentriccircle [6].GetComponent<Animation> ().Play ();

			concentriccircle [11].GetComponent<Animation> ().Play ();
			executed = true;
			break;
		case 3:
			//if(!(concentriccircle[2].transform.rotation.z>180))
			concentriccircle [2].GetComponent<Animation> ().enabled=true;
			concentriccircle [7].GetComponent<Animation> ().enabled=true;
			concentriccircle [12].GetComponent<Animation> ().enabled=true;
			concentriccircle [2].GetComponent<Animation> ().Play ();
			concentriccircle [7].GetComponent<Animation> ().Play ();
			concentriccircle [12].GetComponent<Animation> ().Play ();
			executed = true;
			break;
		case 4:
			//if(!(concentriccircle[3].transform.rotation.z>180))
			concentriccircle [3].GetComponent<Animation> ().enabled=true;
			concentriccircle [8].GetComponent<Animation> ().enabled=true;
			concentriccircle [13].GetComponent<Animation> ().enabled=true;
			concentriccircle [3].GetComponent<Animation> ().Play ();
			concentriccircle [8].GetComponent<Animation> ().Play ();
			concentriccircle [13].GetComponent<Animation> ().Play ();
			executed = true;
			break;
		case 5:
		//	if(!(concentriccircle[4].transform.rotation.z>180))
			concentriccircle [4].GetComponent<Animation> ().enabled=true;
			concentriccircle [9].GetComponent<Animation> ().enabled=true;
			concentriccircle [14].GetComponent<Animation> ().enabled=true;
			concentriccircle [4].GetComponent<Animation> ().Play ();
			concentriccircle [9].GetComponent<Animation> ().Play ();
			concentriccircle [14].GetComponent<Animation> ().Play ();
			executed = true;
			break;
		

		}

	}
/*	IEnumerator changecolor1(){
		while (true) {
			yield return new WaitForSeconds (0.1f);
			for (int j = 0; j < 5; j++) {
				for (int i = 0; i < lineRenderer [i].materials.Length; i++)
					lineRenderer [j].materials [i].color = Random.ColorHSV (0f, 1f, 0f, 1f, 1f, 1f);
			}
		}


	}*/
}

