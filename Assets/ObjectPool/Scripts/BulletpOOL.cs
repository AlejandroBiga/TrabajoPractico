using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletpOOL : MonoBehaviour
{
    public static BulletpOOL Instance { get; private set; }

    public static BulletpOOL SharedInstance;
    public List<List<GameObject>> pooledObjectsLists; // lista tipos de bala
    public List<GameObject> bulletPrefabs; // Lista de prefabs
    public int amountToPool;
    public List<int> amountsToPool; // amounts para cada uno

    void Awake()
    {
        SharedInstance = this;
    }

    void Start()
    {
        pooledObjectsLists = new List<List<GameObject>>();
        InitializePools();
    }

    void InitializePools()
    {
        if (bulletPrefabs.Count != amountsToPool.Count)
        {
            Debug.LogError("el amount debe ser igual");
            return;
        }
        foreach (GameObject prefab in bulletPrefabs)
        {
            List<GameObject> bulletType = new List<GameObject>();
            for (int i = 0; i < amountToPool; i++)
            {
                GameObject obj = Instantiate(prefab);
                obj.SetActive(false);
                bulletType.Add(obj);
            }
            pooledObjectsLists.Add(bulletType);
        }
    }

    public GameObject GetPooledObject(int bulletType)
    {
        List<GameObject> selectedList = pooledObjectsLists[bulletType - 1]; 

        for (int i = 0; i < selectedList.Count; i++)
        {
            if (!selectedList[i].activeInHierarchy)
            {
                return selectedList[i];
            }
        }

        return null;
    }
}
