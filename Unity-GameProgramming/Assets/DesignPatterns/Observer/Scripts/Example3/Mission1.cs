using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission1 : MonoBehaviour
{
    private int key = 0;

    private void OnEnable() => Achievements.AchivementsDetection += Mission;
    private void OnDisable() => Achievements.AchivementsDetection -= Mission;

    private void Mission()
    {
        key++;
        if(key >= 12)
        {
            Debug.Log("Mission1 Completed...");
        }
    }
}
