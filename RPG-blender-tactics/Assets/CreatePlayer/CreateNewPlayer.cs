using UnityEngine;
using System.Collections;

public class CreateNewPlayer : MonoBehaviour {

	private BasePlayer newPlayer;
	private bool isMageClass;
	private bool isWarriorClass;
	// Use this for initialization
	void Start () {
		newPlayer = new BasePlayer ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		isMageClass= GUILayout.Toggle(isMageClass,"Mage class")	;
		isWarriorClass = GUILayout.Toggle(isWarriorClass,"Mage class")	;
		if(GUILayout.Button("create"))
		{
			if(isMageClass){
				newPlayer.playerClass =  new BaseMageClass();}
			else if(isWarriorClass){
				newPlayer.playerClass = new BaseWarriorClass();
			}

			newPlayer.playerLevel=1;
			newPlayer.staminia = newPlayer.playerClass.staminia;
			newPlayer.edurance = newPlayer.playerClass.endurance;
			newPlayer.intellect = newPlayer.playerClass.inteligent;
			newPlayer.strength = newPlayer.playerClass.strength;

			Debug.Log("Player Class: "+newPlayer.playerClass.CharacterClassName);
			Debug.Log("Player Level: "+newPlayer.playerLevel);
			Debug.Log("Player staminia: "+newPlayer.staminia);
			Debug.Log("Player endurance: "+newPlayer.edurance);
			Debug.Log("Player intelect: "+newPlayer.intellect);
			Debug.Log("Player strength: "+newPlayer.strength);

		}
	}
}
