using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateNavMash : MonoBehaviour
{
    void Update()
    {
        GetComponent<NavMeshPlus.Components.NavMeshSurface>().BuildNavMesh();
       
    }
}
