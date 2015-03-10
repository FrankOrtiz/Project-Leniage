using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null; 
	private GenerationScript generationScript;

	// Consistent player stats
	public int armor = 0;			// armor carried from previous generation
	public int weapon = 0;			// weapon carried from previous generation
	public int exp = 0;				// experience carried from previous generation
	public int generation = 1;  
	public int totalExp = 0;
	public int enemiesKilled = 0;
	public int furthestStage = 0;
	public int eldestHero = 0;
	public int mostSkillUpgrades = 0;


	void Awake () {
		if (instance == null)			// Check if instance already exists
			instance = this;			// if not, set instance to this (GameManager)
		else if (instance != this)		// If instance already exists and it's not this:
			Destroy(gameObject);   		// Then destroy this. This enforces our singleton pattern, 
										// meaning there can only ever be one instance of a GameManager. 

		DontDestroyOnLoad(gameObject);	// Sets this to not be destroyed when reloading scene

		generationScript = GetComponent<GenerationScript>();
										// Get a component reference to the attached GenerationScript

		InitGame();						// Call the InitGame function to initialize the first level 
	}
	
	void InitGame(){		// Initializes the game for each generation.
		generationScript.SetupGeneration (generation);		// Call the SetupScene function of the GenerationScript
															// pass it current generation number.
	}

	// Update is called once per frame
	void Update () {
	
	}
}
