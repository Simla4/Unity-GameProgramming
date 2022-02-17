using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private ObjectPooler objectPooler = null;
    [SerializeField] private float spawnInterval = 1;

    private void Start()
    {
        StartCoroutine(nameof(SpawnRoutine));
    }

    private IEnumerator SpawnRoutine()
    {
        while(true)
        {
            var obj = objectPooler.GetPooledObject();

            obj.transform.position = Vector3.zero;

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
