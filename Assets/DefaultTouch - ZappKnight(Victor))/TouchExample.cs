//Cortesia de Miagui :D
using UnityEngine;
using System.Collections;

public class TouchExample : DefaultTouch {

	public override void OnTouch (object t)
	{
		if (t is Vector3) {
			if(Input.GetMouseButton(1))
			{
				Debug.Log("tatatatatta");
			}
		}
	}
	
	// Update is called once per frame
	new void Update () {
		base.Update ();
	}
}
