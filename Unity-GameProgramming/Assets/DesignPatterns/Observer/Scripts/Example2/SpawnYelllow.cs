using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnYelllow : MonoBehaviour
{
    private void OnEnable()
    {
        CubeSpawner.OnSpawnYellowCube += SpawnYellowCube;
    }

    private void OnDisable()
    {
        CubeSpawner.OnSpawnYellowCube -= SpawnYellowCube;
    }

    private void SpawnYellowCube(CubeSpawner spawner)
    {
        Debug.Log("Yellow Cube");
        Instantiate(spawner.cube);
    }
}
