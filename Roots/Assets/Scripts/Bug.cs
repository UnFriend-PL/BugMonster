using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Bug : MonoBehaviour
{

    [SerializeField] NavMeshAgent agent;

    Vector2 startPos;
    public int HP = 2;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        StartCoroutine(Repeat());
    }

    Vector2 lastPos;
    private void Update()
    {
        SetAgentPosition();
        var deltaPos = (Vector2)transform.position - lastPos;
        if (deltaPos.magnitude > 0.001f)
        {
            transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(deltaPos.y, deltaPos.x) * Mathf.Rad2Deg - 90);
        }
        lastPos = transform.position;
    }

    System.Random rand = new System.Random();


    IEnumerator Repeat()
    {
        while (true)
        {
            SetAgentPosition();
            Debug.Log("Function is repeating every 1 second");
            yield return new WaitForSeconds(3f);
        }
    }

    void SetAgentPosition()
    {
        int randomx = rand.Next((int)(startPos.x)-4, (int)(startPos.x)+4);
        int randomy = rand.Next((int)(startPos.y)-4, (int)(startPos.y)+4);
        agent.SetDestination(new Vector3(randomx, randomy, transform.position.z));
        //agent.transform.rotation = Quaternion.LookRotation(secondPos - transform.position, Vector3.forward);
    }
}
