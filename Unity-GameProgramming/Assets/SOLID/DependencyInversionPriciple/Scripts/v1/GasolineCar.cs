using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasolineCar : MonoBehaviour
{
    [SerializeField] private float turnSpeed = 20f;
    [SerializeField] private float speed = 15f;

    public void Movement()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
