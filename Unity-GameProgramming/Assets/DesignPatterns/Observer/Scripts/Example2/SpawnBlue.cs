using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlue : MonoBehaviour
{
    private void OnEnable()
    {
        CubeSpawner.OnSpawnBlueCube += SpawnBlueCube;
    }

    private void OnDisable()
    {
        CubeSpawner.OnSpawnBlueCube -= SpawnBlueCube;
    }

    private void SpawnBlueCube(CubeSpawner spawner)
    {
        Debug.Log("BlueCube");
        Instantiate(spawner.cube);
    }
}
