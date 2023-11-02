using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockF : MonoBehaviour, IFactory
{

    public GameObject rock;
    public GameObject CreateObject(Vector3 spawnPosition)
    {
        
        return Object.Instantiate(rock, spawnPosition, Quaternion.identity) as GameObject; ;
    }

}
