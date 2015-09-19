using UnityEngine;
using System.Collections;

public class SwitchManager : MonoBehaviour {

	DoorBehaviour door ;
	ButtonBehaviour button;
	public Transform target;
	public float DoorSpeed;
	Rigidbody2D doorRb;


	// Use this for initialization
	void Start () {
		door = GetComponentInChildren<DoorBehaviour> ();
		doorRb = GetComponentInChildren<Rigidbody2D> ();
		button = GetComponentInChildren<ButtonBehaviour> ();

	}

	// Update is called once per frame
	void Update () {
		float step = DoorSpeed * Time.deltaTime;
		Debug.DrawLine (button.transform.position, door.transform.position , Color.cyan);
		if (button.IsPressed) {
			door.transform.position = Vector3.MoveTowards (door.transform.position, target.position, step);
			doorRb.gravityScale = 0;
	
		} else
			doorRb.gravityScale = 4;
	}
}