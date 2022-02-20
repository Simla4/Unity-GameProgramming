using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricCarV2 : CarV2
{
    public override void Movement()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

}
