using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectLineRect : MonoBehaviour
{
    public GameObject box, end1, end2, I;
    //public float buffer;

    // Update is called once per frame
    void Update()
    {

        float e1X = end1.transform.position.x;
        float e1Y = end1.transform.position.y;
        float e2X = end2.transform.position.x;
        float e2Y = end2.transform.position.y;

        float top, bottom, left, right;
        top = box.transform.position.y + box.transform.localScale.y / 2;
        bottom = box.transform.position.y - box.transform.localScale.y / 2;
        right = box.transform.position.x + box.transform.localScale.x / 2;
        left = box.transform.position.x - box.transform.localScale.x / 2;

        bool hasCollided = VGDCollisionEngine.LineRect(e1X, e1Y, e2X, e2Y, top, left, right, bottom);
       I.GetComponent<Indicate>().setValue(hasCollided);
    }
}
