using UnityEngine;
using System.Collections;

public class coinTest : MonoBehaviour {
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("Hello", gameObject);
		count_coins.updateCoins();
		Destroy(gameObject);


	}

	void OnTriggerStay(Collider other) {
		Debug.Log ("Hello", gameObject);

	}

	void OnTriggerExit(Collider other) {
		Debug.Log ("Hello", gameObject);

	}
}
