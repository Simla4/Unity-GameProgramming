using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public void Movement(int speed)
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
