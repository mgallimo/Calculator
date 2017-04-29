using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class codeforcalc : MonoBehaviour {

	/* how to make objects fall down from top of screen
	http://answers.unity3d.com/questions/829566/how-to-make-objects-falling-down-from-the-top-of-t.html
	*/

	// video url: https://www.youtube.com/watch?v=zvkBGMUQkqM

	//this is the strings a, b, and the sum. eventually, a will add to b to get the sum
	string a = "First Number";
	string b = "Second Number";
	string quotant = "Quotant";

	void OnGUI() {
		a = GUI.TextField (new Rect (350, 200, 100, 50), a);
		b = GUI.TextField (new Rect (650, 200, 100, 50), b);

		if (GUI.Button (new Rect (525, 150, 50, 50), "")) {
			int integer_a = 0;
			int integer_b = 0;

			System.Int32.TryParse (a, out integer_a);
			System.Int32.TryParse (b, out integer_b);

			quotant = (integer_a / integer_b).ToString ();

		}
		if (GUI.Button (new Rect (525, 250, 50, 50), "Clear")) {
			a = "0";
			b = "0";
			quotant = "0";
		}
		GUI.Label (new Rect (525, 150, 50, 50), quotant);

	}
}

	// video url: https://www.youtube.com/watch?v=N6MbuMAzckA

/*
	Texture resultText;
	double result = 0.0;
	// A temporary double, saving
	double tempSave;
	string operation;
	double multiplier = 1;
	public double storeInt;

	// Use this for initialization
	void Start () {
		resultText = GameObject.Find ("Result").GetComponent<Text> ();

	}

	// Update is called once per frame
	void Update () {
		
	}

	public void writeToTextField()
		{
			resultText.text = "" + result;
		}

	public void ClearResult()
		{
			result = 0.0;
			multiplier = 1;
			writeToTextField ();
		}
	public void saveOperation(string 0)
		{
		operation = o;
		texpSave = result;
		result = 0.0;
		multiplier = 1;
		// Displays the operation character
*/
/*
}
*/