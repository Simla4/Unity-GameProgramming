using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    private void OnEnable()
    {
        PlayerController.OnPlayerDead += PlayerDead;
    }

    private void OnDisable()
    {
        PlayerController.OnPlayerDead -= PlayerDead;
    }

    private void PlayerDead(PlayerController player)
    {
        Debug.Log("object manager");
    }
}
