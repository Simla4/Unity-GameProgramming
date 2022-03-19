using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission2 : MonoBehaviour
{
    private int key = 0;

    private void OnEnable() => Achievements.AchivementsDetection += Mission;
    private void OnDisable() => Achievements.AchivementsDetection -= Mission;

    private void Mission()
    {
        key++;
        if (key >= 5)
        {
            Debug.Log("Mission2 Completed...");
        }
    }
}
