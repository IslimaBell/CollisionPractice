using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentMove : MonoBehaviour
{
    public GameObject end1, end2;
    LineRenderer lr;

    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        lr.SetPosition(0, end1.transform.localPosition);
        lr.SetPosition(1, end2.transform.localPosition);
    }
}
