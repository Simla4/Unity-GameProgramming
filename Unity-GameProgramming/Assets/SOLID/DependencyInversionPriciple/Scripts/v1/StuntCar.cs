using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuntCar : MonoBehaviour
{

    [SerializeField] private float turnSpeed = 7.5f;
    [SerializeField] private float speed = 5f;

    public void Movement()
    {

        transform.Rotate(Vector3.up  * Time.deltaTime * turnSpeed);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
