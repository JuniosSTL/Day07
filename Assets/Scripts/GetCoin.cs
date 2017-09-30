using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCoin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.GetComponent<AudioSource>().Play();
            //GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>().Play();
            Destroy(gameObject);
        }
    }
}
