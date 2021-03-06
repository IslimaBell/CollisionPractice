using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker6Move : MonoBehaviour
{
    TrailRenderer TR;

    // Start is called before the first frame update
    void Start()
    {
        TR = GetComponent<TrailRenderer>();
        TR.enabled = false;
        transform.position = PEQ.Cissoid(5,3);
        TR.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time;
        transform.position = PEQ.Cissoid(t,3); //mult to go faster, divide to slower, - to opposite
    }
}
