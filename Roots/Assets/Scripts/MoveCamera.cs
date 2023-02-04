using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] private float speed = 7.0f;
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
			transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
		}
		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
		}
		if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
		}
		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
		}
		if (Input.GetKey(KeyCode.Q))
		{
			if (Camera.main.orthographicSize > 1)
			{
				Camera.main.orthographicSize -= 0.015f;
			}
		}
		if (Input.GetKey(KeyCode.E))
		{
			if (Camera.main.orthographicSize < 15)
			{
				Camera.main.orthographicSize += 0.015f;
			}
		}
	}
}
