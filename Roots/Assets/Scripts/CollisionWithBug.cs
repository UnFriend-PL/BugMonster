using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CollisionWithBug : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    // Start is called before the first frame update
    private void Start()
    {
        //navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log($"HItted with {hit}");

        if (hit.gameObject.tag == "Bug")
        {
            navMeshAgent.isStopped = true;
            Debug.Log($"HItted with {hit}");
        }
    }
}
