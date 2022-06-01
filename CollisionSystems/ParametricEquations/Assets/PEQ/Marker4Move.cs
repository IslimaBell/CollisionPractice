using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker4Move : MonoBehaviour
{
    TrailRenderer TR;

    // Start is called before the first frame update
    void Start()
    {
        TR = GetComponent<TrailRenderer>();
        TR.enabled = false;
        transform.position = PEQ.Hypocycloid(0,7);
        TR.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time;
        transform.position = PEQ.Hypocycloid(2*t,7); //mult to go faster, divide to slower, - to opposite
    }
}
