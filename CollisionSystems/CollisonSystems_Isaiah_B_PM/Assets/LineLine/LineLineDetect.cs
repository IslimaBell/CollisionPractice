using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineLineDetect : MonoBehaviour
{
    public GameObject end1, end2, end3, end4, I;

    // Update is called once per frame
    void Update()
    {
        float e1X = end1.transform.position.x;
        float e1Y = end1.transform.position.y;
        float e2X = end2.transform.position.x;
        float e2Y = end2.transform.position.y;

        float e3X = end3.transform.position.x;
        float e3Y = end3.transform.position.y;
        float e4X = end4.transform.position.x;
        float e4Y = end4.transform.position.y;

        bool hasCollided = VGDCollisionEngine.LineLine(e1X,e2X,e3X,e4X,e1Y,e2Y,e3Y,e4Y);
        I.GetComponent<Indicate>().setValue(hasCollided);
    }
}
