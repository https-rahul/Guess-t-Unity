using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class guessit : MonoBehaviour {

	public InputField input;
	public Text infotext;

	private int guessNumber;
	private int usersGuess;

	void Start () {
		guessNumber = Random.Range (0, 100);
	}

	public void CheckGuess () {
		usersGuess = int.Parse(input.text);

		if (usersGuess == guessNumber) {
			infotext.text = "You are goddamn right";
		} else if (usersGuess > guessNumber) {
			infotext.text = "Your guess is Greater than the Guess number";
		} else if (usersGuess < guessNumber) {
			infotext.text = "Your guess is Smaller than the Guess number";
		}

		input.text = "";
		
	}
}