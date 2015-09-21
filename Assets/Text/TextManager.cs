using UnityEngine;
using System.Collections;
using System;

public class TextManager : MonoBehaviour {
	
	public string phrase;

	private int selectedphrase = 0;
	
	char[] array ;
	
	char letter;
	
	private TextMesh txt;
	// Use this for initialization
	void Start () {
		txt = GetComponentInChildren<TextMesh> ();
		array = phrase.ToCharArray ();
		StartCoroutine (writer (0.1f));
	}
	
	IEnumerator writer(float f){
		
		for (int i = 0; i < array.Length; i++) {
			
			letter = array[i];
			Debug.Log (letter);
			txt.text += letter;
			yield return new WaitForSeconds (f);
		}
	}
	
	
	
	// Update is called once per frame
	void Update () {

	}
}
