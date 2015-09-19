using UnityEngine;
using System.Collections;

public class ButtonBehaviour : MonoBehaviour {

	public int id ;

	//Must stay pressed ?
	public bool MustStayPressed = false;

	public bool IsPressed = false;



	// Use this for initialization
	void Start () {
	
	}
	void OnCollisionEnter2D(Collision2D other){

		if (this.MustStayPressed == false) {
			this.IsPressed = true;
		}

	}
	void OnCollisionExit2D(Collision2D other){

		if (this.MustStayPressed) {
			this.IsPressed = false;
		}
		
	}
	void OnCollisionStay2D(Collision2D other){

		if (this.MustStayPressed) {
			this.IsPressed = true;
		}

	}
	// Update is called once per frame
	void Update () {
	
	}
}
