using UnityEngine;
using System.Collections;

public class coinTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("Hello", gameObject);
		Destroy(other.gameObject);

	}

	void OnTriggerStay(Collider other) {
		Debug.Log ("Hello", gameObject);

	}

	void OnTriggerExit(Collider other) {
		Debug.Log ("Hello", gameObject);

	}
}
