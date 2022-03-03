using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
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
        Debug.Log("Audio Manager" + player.value);
    }
}
