using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveA : MonoBehaviour
{

    public float scale = 1;

    private void FixedUpdate()
    {
        float mvvs = scale * Time.deltaTime;
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += move * mvvs;
    }
}
