using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JimCode : MonoBehaviour
{

 
        public GameObject C, B, I;  //Circle, Box, Indicator


        void Update()
        {
            float Cx = C.transform.position.x;
            float Cy = C.transform.position.y;
            float Cr = C.transform.localScale.x / 2;

            float top, bottom, left, right;
            top = B.transform.position.y + B.transform.localScale.y / 2;
            bottom = B.transform.position.y - B.transform.localScale.y / 2;
            right = B.transform.position.x + B.transform.localScale.x / 2;
            left = B.transform.position.x - B.transform.localScale.x / 2;

            bool hasCollision = VGDCollisionEngine.CircleBox(Cx, Cy, Cr, top, bottom, left, right);
            I.GetComponent<Indicate>().setValue(hasCollision);
        }
}


