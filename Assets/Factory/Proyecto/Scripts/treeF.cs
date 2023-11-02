using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeF : MonoBehaviour, IFactory
{
    public GameObject tree;
    public GameObject CreateObject(Vector3 spawnPosition)
    {
        // Coloca la lógica para instanciar una roca aquí
        return Object.Instantiate(tree, spawnPosition, Quaternion.identity) as GameObject; ;
    }
}
