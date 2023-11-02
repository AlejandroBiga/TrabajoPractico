using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public rockF Rock;
    public treeF Tree;
    public bushF Bush;
    public Transform spawner;
    private GameObject OBinstance = null;

    public void SpawnRock()
    {
        InstanceOB(Rock.CreateObject(spawner.position));
        
    }

    public void SpawnTree()
    {
        InstanceOB(Tree.CreateObject(spawner.position));
        
    }

    public void SpawnBush()
    {
        InstanceOB(Bush.CreateObject(spawner.position));
        
    }

    private void InstanceOB(GameObject newOB)
    {
        if (OBinstance != null)
        {
            Destroy(OBinstance);
        }
        OBinstance = newOB;
    }
}
