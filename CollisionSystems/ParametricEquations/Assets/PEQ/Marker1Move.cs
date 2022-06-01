using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker1Move : MonoBehaviour
{
    TrailRenderer TR;

    // Start is called before the first frame update
    void Start()
    {
        TR = GetComponent<TrailRenderer>();
        TR.enabled = false;
        transform.position = PEQ.Circle(0,10f);
        TR.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time;
        transform.position = PEQ.Circle(t, 10f); //mult to go faster, divide to slower, - to opposite
    }
}
