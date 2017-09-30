using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEvent : MonoBehaviour
{
    AudioSource click;

    private void Awake()
    {
        click = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        click.Play();
    }
    
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("부딪히중");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("부딪히기 끝");
    }
}
