using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CubeSpawner : MonoBehaviour
{
    public static Action<CubeSpawner> OnSpawnRedCube;
    public static Action<CubeSpawner> OnSpawnBlueCube;
    public static Action<CubeSpawner> OnSpawnYellowCube;
    public static Action<CubeSpawner> OnSpawnGreenCube;

    public GameObject cube;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            RamdomColor();
            OnSpawnRedCube?.Invoke(this);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            RamdomColor();
            OnSpawnBlueCube?.Invoke(this);
        }
        else if(Input.GetKeyDown(KeyCode.Y))
        {
            RamdomColor();
            OnSpawnYellowCube?.Invoke(this);
        }
        else if(Input.GetKeyDown(KeyCode.G))
        {
            RamdomColor();
            OnSpawnGreenCube?.Invoke(this);
        }
    }

    private void RamdomColor()
    {
        cube.GetComponent<Renderer>().material.color = UnityEngine.Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}
