using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBoxDetect : MonoBehaviour
{
    public GameObject box, box2, I;

    // Update is called once per frame
    void Update()
    {
        float top, bottom, left, right;
        top = box.transform.position.y + box.transform.localScale.y / 2;
        bottom = box.transform.position.y - box.transform.localScale.y / 2;
        right = box.transform.position.x + box.transform.localScale.x / 2;
        left = box.transform.position.x - box.transform.localScale.x / 2;

        float top2, bottom2, left2, right2;
        top2 = box2.transform.position.y + box.transform.localScale.y / 2;
        bottom2 = box2.transform.position.y - box.transform.localScale.y / 2;
        right2 = box2.transform.position.x + box.transform.localScale.x / 2;
        left2 = box2.transform.position.x - box.transform.localScale.x / 2;

        bool hasCollision = VGDCollisionEngine.BoxBox(top, bottom, left, right, top2, bottom2, left2, right2);
        I.GetComponent<Indicate>().setValue(hasCollision);
    }
}
