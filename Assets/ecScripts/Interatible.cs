using UnityEngine;
using System.Collections;

public class Interatible : MonoBehaviour {

	[System.Serializable]
	public class Action {
		public Color color;
		public Sprite sprite;
		public string title;
	}

	public Action[] options;

	void Start(){
	}


	void OnMouseDown(){
		RadialMenuSpawner.ins.SpawnMenu (this);
	}
}
