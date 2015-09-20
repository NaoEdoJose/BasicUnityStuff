using UnityEngine;
using System.Collections;

public class Highlight : MonoBehaviour {

	public string phrase;

	
	char[] array ;
	
	char letter;
	
	private TextMesh txt;

	private Color startcolor;
	void OnMouseEnter()
		
	{

		startcolor = renderer.material.color;
		renderer.material.color = Color.yellow;
		StartCoroutine(writer (0.1f));
	}
	void OnMouseExit()
	{
		renderer.material.color = startcolor;
		StopCoroutine (writer(0f));
		txt.text = "";
	}
	// Use this for initialization
	void Start () {
		txt = GetComponentInChildren<TextMesh> ();
		array = phrase.ToCharArray ();
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
