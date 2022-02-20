using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManagerV2 : MonoBehaviour
{
    [SerializeField] private CarV2 car;

    private void Update()
    {
        car.Movement();
    }

}
