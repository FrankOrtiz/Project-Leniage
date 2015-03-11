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
		isDead = true;
		gameObject.SetActive (false);
		Debug.Log ("clicky clicky");
		StageScript stageScript = GameObject.Find ("GameManager").GetComponent<StageScript>();
		stageScript.enemiesKilledThisStage++;
		stageScript.SelectEnemy (stageScript.thisStage);
	}
	// Update is called once per frame
	void Update () {
			
//		if (Input.GetMouseButtonDown(0)){ // if left button pressed...
//			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//			RaycastHit hit;
//			if (Physics.Raycast(ray, out hit)){
//				// the object identified by hit.transform was clicked
//		Debug.Log ("clicky clicky");
//				// do whatever you want
//			}
//		}
	}
}
