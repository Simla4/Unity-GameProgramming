using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace minimap
{
    public class PlayerController : MonoBehaviour
    // Start is called before the first frame update
    {
        [SerializeField] private Transform player;
        [SerializeField] private float speed;

        void Update()
        {
            MovementInput();
        }

        private void MovementInput()
        {
            if(Input.GetKey(KeyCode.W))
            {
                player.Translate(Vector3.forward * speed * Time.deltaTime);
            }
            else if(Input.GetKey(KeyCode.S))
            {
                player.Translate(Vector3.forward * -speed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                player.Translate(Vector3.right * speed * Time.deltaTime);
            }
            else if(Input.GetKey(KeyCode.A))
            {
                player.Translate(Vector3.right * -speed * Time.deltaTime);
            }
        }
    }

}
