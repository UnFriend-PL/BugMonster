using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Update()
    {
        GetComponent<NavMeshPlus.Components.NavMeshSurface>().BuildNavMesh();
       
    }
}
