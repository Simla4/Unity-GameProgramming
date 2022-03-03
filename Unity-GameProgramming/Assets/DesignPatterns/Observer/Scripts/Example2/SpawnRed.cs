using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRed : MonoBehaviour
{
    private void OnEnable()
    {
        CubeSpawner.OnSpawnRedCube += SpawnRedCube;
    }

    private void OnDisable()
    {
        CubeSpawner.OnSpawnRedCube -= SpawnRedCube;
    }

    private void SpawnRedCube(CubeSpawner spawner)
    {
        Debug.Log("Red Cube");
        Instantiate(spawner.cube);
    }
}
