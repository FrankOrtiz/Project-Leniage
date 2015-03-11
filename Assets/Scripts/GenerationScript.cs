using UnityEngine;
using System;
using System.Collections;
using Random = UnityEngine.Random;
using UnityEngine.UI;

public class GenerationScript : MonoBehaviour {

		
	[Serializable]						// Using Serializable allows us to embed a class with sub properties in the inspector.
	public class Count{
		public int minimum;             // Minimum value for our Count class.
		public int maximum;             // Maximum value for our Count class.

		public Count (int min, int max) // Assignment constructor.
		{
			minimum = min;
			maximum = max;
		}
	}

	public float stageStartDelay = 2f;
	private StageScript stageScript;
	public GameObject[] possiableCharacters;
	private GameManager gameManager;



	public int playerHealth = 0;
	public int playerAge = 18;
	public int currentExp = 0;
	public int currentStage = 1;
	void OnLevelWasLoaded(int index){

		currentStage++;

		stageScript.InitStage (currentStage);
	}

	// Update is called once per frame
	void Update () {

	}

	//Sets up the outer walls and floor (background) of the game board.
	// Sets up the background of the stage

	public void SetupGeneration (int generation){
		//Creates the outer walls and floor.
		stageScript = GetComponent<StageScript>();
	
		stageScript.InitStage (currentStage);
		Instantiate(possiableCharacters[Random.Range (0, possiableCharacters.Length)]);
		//Reset our list of gridpositions.
//		InitialiseList ();
		
		//Instantiate a random number of wall tiles based on minimum and maximum, at randomized positions.
//		LayoutObjectAtRandom (wallTiles, wallCount.minimum, wallCount.maximum);
		
		//Instantiate a random number of food tiles based on minimum and maximum, at randomized positions.
//		LayoutObjectAtRandom (foodTiles, foodCount.minimum, foodCount.maximum);
		
		//Determine number of enemies based on current level number, based on a logarithmic progression
//		int enemyCount = (int)Mathf.Log(level, 2f);
		
		//Instantiate a random number of enemies based on minimum and maximum, at randomized positions.
//		LayoutObjectAtRandom (enemyTiles, enemyCount, enemyCount);
		
		//Instantiate the exit tile in the upper right hand corner of our game board
//		Instantiate (exit, new Vector3 (columns - 1, rows - 1, 0f), Quaternion.identity);
	}
	public void PlayerDied(){
		enabled = false;
	}
}
