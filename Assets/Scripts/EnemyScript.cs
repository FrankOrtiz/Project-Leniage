using UnityEngine;
using System.Collections;

public abstract class EnemyScript : MonoBehaviour {

	public int level;
	public int expReward;
	// Use this for initialization
	protected virtual void Start () {
		Debug.Log ("This runs last");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
