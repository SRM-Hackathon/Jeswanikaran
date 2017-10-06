using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonrotation : MonoBehaviour {
    public GameObject handl, kneel,p0,p1,p2,p3,p4,p5,p6,p7,p8,p9,p10,p11,p12,p13,p14,p15,p16,p17,p18,p19,p20,p21,p22,p23;
    Animator a;
    int n;
	// Use this for initialization
	void Start () {
        a = this.gameObject.GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update() {
        if (handl.transform.position.y < kneel.transform.position.y)
        {
            a.enabled = true;
            p0.SetActive(true);
            p1.GetComponent<ParticleSystem>().Play();
            p2.GetComponent<ParticleSystem>().Play();
            p3.GetComponent<ParticleSystem>().Play();
            p4.SetActive(true);
            p5.GetComponent<ParticleSystem>().Play();
            p6.GetComponent<ParticleSystem>().Play();
            p7.GetComponent<ParticleSystem>().Play();
            p8.SetActive(true);
            p9.GetComponent<ParticleSystem>().Play();
            p10.GetComponent<ParticleSystem>().Play();
            p11.GetComponent<ParticleSystem>().Play();
            p12.SetActive(true);
            p13.GetComponent<ParticleSystem>().Play();
            p14.GetComponent<ParticleSystem>().Play();
            p15.GetComponent<ParticleSystem>().Play();
            p16.SetActive(true);
            p17.GetComponent<ParticleSystem>().Play();
            p18.GetComponent<ParticleSystem>().Play();
            p19.GetComponent<ParticleSystem>().Play();
            p20.SetActive(true);
            p21.GetComponent<ParticleSystem>().Play();
            p22.GetComponent<ParticleSystem>().Play();
            p23.GetComponent<ParticleSystem>().Play();
        }
        else a.enabled = false;
        
            }
}
