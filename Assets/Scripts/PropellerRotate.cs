using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotate : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 0, 540 * Time.deltaTime);
    }
}
