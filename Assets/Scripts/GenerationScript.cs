using UnityEngine;
using System;
using System.Collections;
using Random = UnityEngine.Random;

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
	
	public GameObject[] enemyUnits;             // Array of enemy prefabs.
	public GameObject[] bossUnits;              // Array of outer tile prefabs.
	private GameManager gameManager;

	// Update is called once per frame
	void Update () {

	}

	//Sets up the outer walls and floor (background) of the game board.
	// Sets up the background of the stage
	void StageSetup (){
		gameManager = GetComponent<GameManager>();
		Debug.Log("Stage created");
		Debug.Log ("Gen: " + gameManager.generation);
		Debug.Log ("Current armor" + gameManager.armor);
		Debug.Log ("Current weapon" + gameManager.weapon);
		Debug.Log ("Current exp" + gameManager.exp);
		Debug.Log ("Total exp" + gameManager.totalExp);
		
		//Instantiate Board and set boardHolder to its transform.
//		boardHolder = new GameObject ("Board").transform;
		
		//Loop along x axis, starting from -1 (to fill corner) with floor or outerwall edge tiles.
//		for(int x = -1; x < columns + 1; x++)
//		{
//			//Loop along y axis, starting from -1 to place floor or outerwall tiles.
//			for(int y = -1; y < rows + 1; y++)
//			{
//				//Choose a random tile from our array of floor tile prefabs and prepare to instantiate it.
//				GameObject toInstantiate = floorTiles[Random.Range (0,floorTiles.Length)];
//				
//				//Check if we current position is at board edge, if so choose a random outer wall prefab from our array of outer wall tiles.
//				if(x == -1 || x == columns || y == -1 || y == rows)
//					toInstantiate = outerWallTiles [Random.Range (0, outerWallTiles.Length)];
//				
//				//Instantiate the GameObject instance using the prefab chosen for toInstantiate at the Vector3 corresponding to current grid position in loop, cast it to GameObject.
//				GameObject instance =
//					Instantiate (toInstantiate, new Vector3 (x, y, 0f), Quaternion.identity) as GameObject;
//				
//				//Set the parent of our newly instantiated object instance to boardHolder, this is just organizational to avoid cluttering hierarchy.
//				instance.transform.SetParent (boardHolder);
//			}
//		}
	}

	public void SetupGeneration (int generation){
		//Creates the outer walls and floor.
		StageSetup ();
		
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
}
