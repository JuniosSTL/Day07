using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPush : MonoBehaviour
{
    Rigidbody ball;

    private void Awake()
    {
        ball = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if ( Input.GetButtonDown("Fire1") )
        {
            Vector3 dir = transform.forward; //자기의 앞방향을 세상 기준(월드)으로 표현

            ball.AddForce(dir * 10.0f, ForceMode.Impulse);
        }
    }
}
