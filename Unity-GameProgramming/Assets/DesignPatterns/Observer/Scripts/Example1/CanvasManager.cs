using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
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
        Debug.Log("Canvas Manager");
    }
}
