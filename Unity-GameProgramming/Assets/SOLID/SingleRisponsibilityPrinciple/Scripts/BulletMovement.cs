using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;

    // Update is called once per frame
    void Update()
    {
        BulletMove();
    }

    private void BulletMove()
    {
         transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);

    }
}
