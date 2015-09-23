//By ThiagoSemJoelho
using UnityEngine;
using System.Collections;

public class DinamicCamera : MonoBehaviour {

	public GameObject target;
	public float startX;
	public float endX;

	void Update () {
		float targetX = target.transform.position.x;

		if (targetX < startX)
			targetX = startX;
		else if (targetX > endX)
			targetX = endX;

		Vector3 targetPosition = new Vector3 (targetX, 0, -10); 
		gameObject.transform.position = targetPosition;
	}
}
