using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour
{
	[SerializeField] private string chosenTag;

	void OnCollisionEnter2D(Collision2D collision)
    {
		if (collision.gameObject.tag == chosenTag)
		{
			Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
		}
    }
}
