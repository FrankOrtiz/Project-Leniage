using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;
using UnityEngine.UI;

public class StageScript : MonoBehaviour {

	private GameManager gameManager;
	private GenerationScript generationScript;
	public int enemyLevel;
	public bool weaponUpgrade;
	public bool armorUpgrade;
	public bool enemyCount;

	public GameObject[] backgroundsArray;
	public GameObject[] possiableEnemies;  
	public GameObject[] bossesArray;

	private bool playerTurn = true;
	public int enemiesKilledThisStage = 0;
	public int totalEnemies;
	public float stageStartDelay = 2f;
	public int thisStage;

	private Text stageText;
	private GameObject stageImage;
	private GameObject attackPanel;
	GameObject playerCharacter;
	GameObject currentEnemy;
	BasicEnemy enemyScript;

	private bool settingUp;
	
	private Transform stageHolder; 
	// Use this for initialization
	void Start () {
	
	}

	void NumberOfEnemies(int currentStage){
		int enemies = (currentStage / 5);

		if ((enemies) == 0)
			enemies = 1;

		totalEnemies = (enemies * 5);
	}

	public void BasicAttack(){
		GameObject generation = GameObject.Find ("Generation");
		Transform[] generationChildren = GetComponentsInChildren<Transform>(generation);
		foreach (Transform player in generationChildren) {
			playerCharacter = player.gameObject;
		}

		GameObject stage = GameObject.Find ("StageHolder");
		Transform[] stageChildren = GetComponentsInChildren<Transform>(stage);
		foreach (Transform enemy in stageChildren) {
			currentEnemy = enemy.gameObject;
		}

		BasicEnemy enemyScript = currentEnemy.GetComponent<BasicEnemy> ();
		Debug.Log ("Player Attacks");
		Debug.Log (enemyScript.level);
		Debug.Log ("Player " + playerCharacter.name + "Attacks: " + "lvl" + enemyScript.level + " " + currentEnemy.name);
	}

	public void StageSetup (int currentStage){
		gameManager = GetComponent<GameManager>();
		generationScript = GetComponent<GenerationScript> ();
		enemyLevel = generationScript.currentStage;
		stageHolder = new GameObject ("Stage " + enemyLevel).transform;
		thisStage = currentStage;

		Debug.Log ("Stage created");
		Debug.Log ("Stage: " + currentStage);
		Debug.Log ("Gen: " + gameManager.generation);
		Debug.Log ("Current armor: " + gameManager.armor);
		Debug.Log ("Current weapon: " + gameManager.weapon);
		Debug.Log ("Current exp: " + gameManager.exp);
		Debug.Log ("Total exp: " + gameManager.totalExp);
		Debug.Log ("Enemy level: " + enemyLevel);

		NumberOfEnemies (currentStage);
		Debug.Log ("Total enemies this stage: " + totalEnemies);
		// InitializeFight (possiableEnemies, enemyLevel, enemiesLeft);
		GameObject background = Instantiate (backgroundsArray [currentStage-1]);
		SelectEnemy (currentStage);
		background.transform.SetParent (stageHolder);
	}

	public void SelectEnemy(int currentStage){
		if (enemiesKilledThisStage < totalEnemies) {
//			GameObject currentEnemy = Instantiate (possiableEnemies [enemiesKilledThisStage]);
			GameObject currentEnemy = Instantiate (possiableEnemies [Random.Range(0, possiableEnemies.Length)]);
			currentEnemy.transform.SetParent(stageHolder);
		} else if (enemiesKilledThisStage == totalEnemies) {
			GameObject currentBoss = Instantiate (bossesArray [currentStage -1]);
			currentBoss.transform.SetParent(stageHolder);
		} else {
			currentStage++;
			InitStage (currentStage);
//			Next stage
		}
	}

	private void OnDisable (){
		//	When Player object is disabled, store the current local values in the GenerationScript so it can be re-loaded in next stage.
		//  generationScript.instance.armor = armor;
	}

	public void SceneCreate(){

	}
	void InitializeFight (GameObject enemiesArray){
//		GameObject currentEnemy = enemiesArray[Random.Range (0, enemiesArray.Length)];
//		Instantiate(currentEnemy);

	}

	public void InitStage(int currentStage){
		settingUp = true;
		stageImage = GameObject.Find ("StageImage");
		stageText = GameObject.Find ("StageText").GetComponent<Text>();
		attackPanel = GameObject.Find ("AttackPanel");
		stageText.text = "Stage " + currentStage;
		stageImage.SetActive (true);
		Invoke ("HideStageImage", stageStartDelay);

		StageSetup (currentStage);
	}

	private void HideStageImage(){
		stageImage.SetActive (false);
		settingUp = false;
		attackPanel.transform.Rotate (0,90,0);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
