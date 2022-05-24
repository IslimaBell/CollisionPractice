using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleBoxDetect : MonoBehaviour
{
    public GameObject  circle, box, I;

    // Update is called once per frame
    void Update()
    {
        float CAX = circle.transform.position.x;
        float CAY = circle.transform.position.y;
        float CAR = circle.transform.position.x / 2;

        float top, bottom, left, right;
        top = box.transform.position.y + box.transform.localScale.y / 2; 
        bottom = box.transform.position.y - box.transform.localScale.y / 2;
        right = box.transform.position.x + box.transform.localScale.x / 2;
        left = box.transform.position.x - box.transform.localScale.x / 2;

        

        bool hasCollision = VGDCollisionEngine.CircleBox(CAX, CAY, CAR, top, bottom, left, right);
        I.GetComponent<Indicate>().setValue(hasCollision);

    }
}
