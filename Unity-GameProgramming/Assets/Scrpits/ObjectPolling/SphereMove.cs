using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMove : MonoBehaviour
{
    
    void Update()
    {
        transform.Translate(Vector3.forward * 15 * Time.deltaTime);
    }
}
