using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour
{
    [SerializeField] private StuntCar stuntCar;
    [SerializeField] private ElectricCar electricCar;
    [SerializeField] private GasolineCar gasolineCar;
     
    void Update()
    {
        CarMovement();
    }

    private void CarMovement()
    {
        stuntCar.Movement();
        electricCar.Movement();
        gasolineCar.Movement();
    }
}
