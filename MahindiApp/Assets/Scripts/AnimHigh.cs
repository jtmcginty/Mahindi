using UnityEngine;
using System.Collections;

public class AnimHigh : MonoBehaviour {

	public int counter = 0;

	public Cho_Sequences sequences;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (counter < 1) {
			sequences.PlantGrowHigh ();
			sequences.HarvestHigh ();
		}
		counter++;
	}
}
