using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class AnimNoFHigh : MonoBehaviour {

	public int counter = 0;
	public Boolean finishedAnim = false;
	public GameObject myCanvas;



	public Cho_Sequences sequences;
	// Use this for initialization
	void Start () {
		myCanvas.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (counter < 1) {
			sequences.PlantGrowNoFHigh();
			sequences.HarvestHigh();
			finishedAnim = true;
			counter++;
		}
		if (counter == 1) {
			myCanvas.SetActive (finishedAnim);
		}
	}
}
