using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricCar : MonoBehaviour
{
    [SerializeField] private float turnSpeed = 15f;
    [SerializeField] private float speed = 10f;

    public void Movement()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
