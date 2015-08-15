using UnityEngine;
using System.Collections;

public class intercative : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collider){
		
		if(collider.gameObject.tag == "Player")
		{
			Debug.Log("Interacted!");
		}
		
	}
}
