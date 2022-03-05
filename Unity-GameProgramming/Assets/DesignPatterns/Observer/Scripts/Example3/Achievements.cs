using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Achievement : MonoBehaviour
{
    public static Action AchivementsDetection;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            AchivementsDetection?.Invoke();
        }
    }
}
