using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P38Rotate : MonoBehaviour {

    public float angularSpeed = 60.0f;


    void Update ()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 rotDir = new Vector3(v, 0, -h);

        transform.Rotate(rotDir * angularSpeed * Time.deltaTime);

	}
}
