using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Achievements : MonoBehaviour
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
