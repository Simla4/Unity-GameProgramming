using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public abstract class CarV2 : MonoBehaviour
{

    [SerializeField] protected float turnSpeed;
    [SerializeField] protected float speed;

    public abstract void Movement();

}


