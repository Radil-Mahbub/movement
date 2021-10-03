using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaser : MonoBehaviour
{
  public Transform targetTransform;
	public float speed = 0;

	void Update ()
     {
		Vector3 displacementFromTarget = targetTransform.position - transform.position;
		Vector3 directionToTarget = displacementFromTarget.normalized;
		Vector3 velocity = directionToTarget * speed;

		float distanceToTarget = displacementFromTarget.magnitude;

		if (distanceToTarget > 3.0f) 
        {
			transform.Translate (velocity * Time.deltaTime);
		}
	
	}
}
