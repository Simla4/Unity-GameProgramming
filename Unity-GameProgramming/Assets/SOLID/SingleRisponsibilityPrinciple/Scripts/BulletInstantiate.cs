using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletInstantiate : MonoBehaviour
{
    [SerializeField] private GameObject bullet;

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(BulletClone());
    }

    private IEnumerator BulletClone()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(bullet);
            yield return new WaitForSeconds(1);
        }

        
    }
}
