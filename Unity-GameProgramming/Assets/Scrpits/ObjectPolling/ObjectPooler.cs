using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    private Queue<GameObject> polledObjects;

    [SerializeField] private GameObject objectPrafab;
    [SerializeField] private int poolSize;

    private void Awake()
    {
        polledObjects = new Queue<GameObject>();

        for(int i = 0; i < poolSize; i++)
        {
            var obj = Instantiate(objectPrafab);

            obj.SetActive(false);
            polledObjects.Enqueue(obj);
        }
    }
}
