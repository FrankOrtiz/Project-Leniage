using UnityEngine;
using System.Collections;

public abstract class EnemyScript : MonoBehaviour {

	private StageScript stageScript;
	public int level;
	public int expReward;
	public bool isDead = false;

	// Use this for initialization
	protected virtual void Start () {
		stageScript = GameObject.Find ("GameManager").GetComponent<StageScript>();
		level = stageScript.thisStage;
		Debug.Log ("This runs last");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
