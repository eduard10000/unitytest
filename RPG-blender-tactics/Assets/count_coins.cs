using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class count_coins : MonoBehaviour {
	private  Text Punctuation;
	private static int coins = 0;

	// Use this for initialization
	void Start () {
		GameObject PunctuationGo = GameObject.Find("Punctuation");
		Punctuation = PunctuationGo.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		if(coins == 10){
			Application.Quit();
		}
		Punctuation.text = "coins: " + coins.ToString ();
	}

	public static void updateCoins(){
		coins++;
		Debug.Log (coins.ToString());

	}

}
