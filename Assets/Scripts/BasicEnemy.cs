using UnityEngine;
using System.Collections;

public class BasicEnemy : EnemyScript {

	// Use this for initialization
	protected override void Start () {
		Debug.Log ("Enemy created");
		Debug.Log (level);

		base.Start ();
	}

	void OnMouseDown(){
		gameObject.SetActive (false);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
