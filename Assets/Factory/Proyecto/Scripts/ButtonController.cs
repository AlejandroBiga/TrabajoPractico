using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public rockF Rock;
    public treeF Tree;
    public bushF Bush;
    public Transform spawner; // Objeto vac�o que act�a como spawner en la escena.

    public void SpawnRock()
    {
        GameObject newRock = Rock.CreateObject(spawner.position);
        // Aqu� puedes configurar propiedades adicionales si es necesario.
    }

    public void SpawnTree()
    {
        GameObject newTree = Tree.CreateObject(spawner.position);
        // Configura propiedades adicionales si es necesario.
    }

    public void SpawnBush()
    {
        GameObject newBush = Bush.CreateObject(spawner.position);
        // Configura propiedades adicionales si es necesario.
    }
}
