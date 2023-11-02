using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeF : MonoBehaviour, IFactory
{
    public GameObject tree;
    public GameObject CreateObject(Vector3 spawnPosition)
    {
        
        return Object.Instantiate(tree, spawnPosition, Quaternion.identity) as GameObject; ;
    }
}
