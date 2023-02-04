using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private Rigidbody2D _rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * _moveSpeed;
        float moveY = Input.GetAxis("Vertical") * Time.deltaTime * _moveSpeed;
        transform.position += new Vector3(moveX,moveY,0);
    }
}
