using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFull : MonoBehaviour
{
    /*
     We have a character. This character can move and fire. Let the character has health. 
     Let write all of these in a single script. 
     This is not applicable for Single Responsibility Prencible.
    */

    [SerializeField] private float speed;
    [SerializeField] private GameObject bullet;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private int HP;
 
    // Update is called once per frame
    void Update()
    {
        CharacterMovement();
        StartCoroutine(BulletMovement());
    }

    private void CharacterMovement()
    {
        if(Input.GetKeyDown("w"))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Obstacle"))
        {
            HP --;
        }
    }

    private IEnumerator BulletMovement()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(bullet);
            bullet.transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);

            yield return new WaitForSeconds(1);
        }
    }
}
