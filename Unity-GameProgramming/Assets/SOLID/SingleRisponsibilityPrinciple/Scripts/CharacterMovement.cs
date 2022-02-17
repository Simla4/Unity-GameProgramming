using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    // Update is called once per frame
    void Update()
    {
        CharacterMove();
    }

    private void CharacterMove()
    {
        if (Input.GetKeyDown("w"))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

    }
}
