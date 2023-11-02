using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockF : MonoBehaviour, IFactory
{

    public GameObject rock;
    public GameObject CreateObject(Vector3 spawnPosition)
    {
        // Coloca la lógica para instanciar una roca aquí
        return Object.Instantiate(rock, spawnPosition, Quaternion.identity) as GameObject; ;
    }

}
