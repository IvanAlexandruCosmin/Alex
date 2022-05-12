using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxes : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
		 if( collision.contacts[0].normal.x < -0.2)
		 {
			 Destroy(gameObject);
		 }
	}
}
