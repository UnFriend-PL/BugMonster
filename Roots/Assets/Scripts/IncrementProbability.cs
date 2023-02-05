using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncrementProbability : MonoBehaviour
{
    [SerializeField] private GameObject block;

    private void OnMouseDown() {
        block.GetComponent<Block>().probabilityOfFood += 2;

    }
    // Start is called before the first frame update



}
