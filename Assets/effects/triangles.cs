using UnityEngine;
using System.Collections;

public class triangles : MonoBehaviour
{
    LineRenderer tr;
    public GameObject g1;
    public GameObject g2;
    public GameObject hr;
    public GameObject hl;
    bool hg;
    public GameObject head;

    // Use this for initialization
    void Start()
    {
        tr = this.GetComponent<LineRenderer>();
        hg = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ((hr.gameObject.transform.position.y >= (head.transform.position.y + 0.2f) && (hl.transform.position.y >= (head.transform.position.y + 0.2f)) || hg))
        {
            hg = true;
            tr.SetWidth(0.05f, 0.05f);
            tr.SetPosition(0, this.gameObject.transform.position);
            tr.SetPosition(1, g1.transform.position);
            tr.SetPosition(2, g2.transform.position);
            tr.SetPosition(3, this.gameObject.transform.position);
        }
        if ((hr.gameObject.transform.position.x - hl.transform.position.x) < 0.1f && (hr.gameObject.transform.position.x - hl.transform.position.x) > (-0.1f))
        {
            tr.SetWidth(0f, 0f);
            hg = false;
        }
    }
}
