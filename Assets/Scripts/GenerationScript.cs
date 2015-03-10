using UnityEngine;
using System;
using System.Collections;
using Random = UnityEngine.Random;

public class GenerationScript : MonoBehaviour {

		
	[Serializable]						// Using Serializable allows us to embed a class with sub properties in the inspector.
	public class Count{
		public int minimum;             //	Minimum value for our Count class.
		public int maximum;             //	Maximum value for our Count class.

		public Count (int min, int max) //	Assignment constructor.
		{
			minimum = min;
			maximum = max;
		}
	}
	public GameObject[] enemyUnits;             //	Array of enemy prefabs.
	public GameObject[] bossUnits;              // Array of outer tile prefabs.

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
