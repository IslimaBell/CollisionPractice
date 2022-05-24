using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PSDetect : MonoBehaviour
{
    public GameObject P, end1, end2, I;
    public float buffer = 0.05f;

    // Update is called once per frame
    void Update()
    {
        float px = P.transform.position.x;
        float py = P.transform.position.y;

        float e1X = end1.transform.position.x;
        float e1Y = end1.transform.position.y; 
        float e2X = end2.transform.position.x;
        float e2Y = end2.transform.position.y;

        bool hasCollided = VGDCollisionEngine.PointSegment(px, py, e1X, e1Y, e2X, e2Y, buffer);
        I.GetComponent<Indicate>().setValue(hasCollided);
    }
}
