using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P38Move : MonoBehaviour {

    public float moveSpeed = 20.0f;

	void Update ()
    {
        //내 기준 앞방향으로 이동
//        transform.Translate(0, 0, moveSpeed * Time.deltaTime, Space.Self);
        transform.position += transform.forward * moveSpeed * Time.deltaTime;

        //세상기준 앞 방향 이동
        //transform.Translate(0, 0, moveSpeed * Time.deltaTime, Space.World);
        //transform.position +=  Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
