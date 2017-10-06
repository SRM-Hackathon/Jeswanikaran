using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicselector : MonoBehaviour {
	public string songaddress;
	public WWW addressofsong;
	bool played=false ;
	bool assigned=false;

	void OnStart () {
		//addressofsong = FileSelectorExample.path;
		GetComponent<AudioSource> ().clip =addressofsong. GetAudioClip(true);

	}

	// Update is called once per frame
	void Update () {
		if (System.IO.File.Exists (songaddress)) {

		//	print ("11");
		}
		if (!played) {
			addressofsong = new WWW("file:///"+songaddress);
			assigned = true;

		}
		if (played == false&&assigned) {
			GetComponent<AudioSource> ().clip = addressofsong.GetAudioClip(true);
			//GetComponent<AudioSource> ().Play ();
			played = true;
			print ("paste");
			StartCoroutine ("play");

		}
	}
	IEnumerator play(){

		yield return new WaitForEndOfFrame ();
		yield return new WaitForEndOfFrame ();
		GetComponent<AudioSource> ().enabled = true;
		GetComponent<AudioSource> ().PlayDelayed (1);

	}

}
