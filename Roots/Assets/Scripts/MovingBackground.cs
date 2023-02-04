using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour
{
    public float speed = 10.0f;
    public bool direction = true;

    void Update()
    {
        var x = speed * Time.deltaTime;
        if (direction == true)
        {
            transform.position -= new Vector3(x, 0, 0);
            if (transform.position.x < -1000)
            {
            direction = !direction;
            }
        }
        else
        {
            transform.position += new Vector3(x, 0, 0);
            if (transform.position.x > 2900)
            {
            direction = !direction;
            }
        }
    }
}
