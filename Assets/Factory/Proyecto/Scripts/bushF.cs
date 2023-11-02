using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bushF : MonoBehaviour, IFactory
{
    public GameObject bush;
    public GameObject CreateObject(Vector3 spawnPosition)
    {
        
        return Object.Instantiate(bush, spawnPosition, Quaternion.identity) as GameObject; ;
    }
}
