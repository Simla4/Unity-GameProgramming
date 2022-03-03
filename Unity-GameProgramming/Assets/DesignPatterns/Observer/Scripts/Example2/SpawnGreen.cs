using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGreen : MonoBehaviour
{
    private void OnEnable()
    {
        CubeSpawner.OnSpawnGreenCube += SpawnGreenCube;
    }

    private void OnDisable()
    {
        CubeSpawner.OnSpawnGreenCube -= SpawnGreenCube;
    }

    private void SpawnGreenCube(CubeSpawner spawner)
    {
        Debug.Log("Green Cube");
        Instantiate(spawner.cube);
    }
}
