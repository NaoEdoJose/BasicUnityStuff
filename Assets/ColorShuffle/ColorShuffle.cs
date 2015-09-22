//By ThiagoSemJoelho
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ColorShuffle : MonoBehaviour {

	private Color bgColor;
	
	IEnumerator ColorShifter(){
		while (true){ 

			bgColor = new Color(Random.value, Random.value, Random.value, 0.5f);
			
			float time = 0.0f;
			Color currentColor = Camera.main.backgroundColor;
			
			while( time < 1.0f ){
				Camera.main.backgroundColor = Color.Lerp(currentColor, bgColor, time );
				yield return new WaitForSeconds (0.0123f);
				time += Time.deltaTime;
			}
		}
	}

}
