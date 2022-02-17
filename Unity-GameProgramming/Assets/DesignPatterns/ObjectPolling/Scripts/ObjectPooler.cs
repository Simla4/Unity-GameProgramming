using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    private Queue<GameObject> pooledObjects;

    [SerializeField] private GameObject objectPrafab;
    [SerializeField] private int poolSize;

    private void Awake()
    {
        pooledObjects = new Queue<GameObject>();

        for(int i = 0; i < poolSize; i++)
        {
            var obj = Instantiate(objectPrafab);

            obj.SetActive(false);
            pooledObjects.Enqueue(obj);
        }
    }

    public GameObject GetPooledObject()
    {
        var obj = pooledObjects.Dequeue();
        obj.SetActive(true);

        pooledObjects.Enqueue(obj);

        return obj;

    }
}
