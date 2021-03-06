﻿//Cortesia de Miagui :D
using UnityEngine;
using System.Collections;

public abstract class DefaultTouch : MonoBehaviour {

	
public virtual void OnTouch(object o) { }
	
	
	public virtual void Update () {
		if (Input.touchSupported && Input.touchCount > 0) {
			for (int i = 0; i < Input.touchCount; i++) {
				Vector2 point = new Vector2 (Input.GetTouch (i).position.x, Input.GetTouch (i).position.y);
				if (this.gameObject.collider2D.OverlapPoint (Camera.main.ScreenToWorldPoint (point)))
					OnTouch (Input.GetTouch (i));
			}
		} 
		else 
		{
			Vector2 point = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
			if (this.gameObject.collider2D.OverlapPoint(Camera.main.ScreenToWorldPoint(point)))
				OnTouch(Input.mousePosition);
		}
	}
}
