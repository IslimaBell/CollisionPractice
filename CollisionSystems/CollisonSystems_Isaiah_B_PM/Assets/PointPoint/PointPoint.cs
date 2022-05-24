using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointPoint : MonoBehaviour
{

    public GameObject A, B, I;


    // Update is called once per frame
    void Update()
    {

        float Ax = A.transform.position.x;
        float Ay = A.transform.position.y;
        float Bx = B.transform.position.x;
        float By = B.transform.position.y;

        bool hasCollided = VGDCollisionEngine.PointPoint(Ax, Ay, Bx, By);
        I.GetComponent<Indicate>().setValue(hasCollided);

    }
}
