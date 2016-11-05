using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class ChooseVillage : MonoBehaviour {

	//private GlobalControl globalControl = GlobalControl.Instance();

	TextAsset[] assets;

	public Text villageText;
	public Text hhidText;

	int villageIndex = 0;
	int hhidIndex = 0;

	List<string> villageList = new List<string> ();
	List<string> HHIDList = new List<string> ();

	public string[] villageTest;
	public string[] hhidTest;

	public string[] village;
	public string[] hhid;

	Boolean changedIndex = false;

	// Use this for initialization
	void Start () {
		getFiles ();
		villageText.text = village[villageIndex];
		hhidText.text = hhid[hhidIndex];
		//saveData ();
	}
	
	// Update is called once per frame
	void Update () {
		if (changedIndex) {
			villageText.text = village [villageIndex];
			hhidText.text = hhid [hhidIndex];
			//saveData();
		}
	}


	public void getFiles(){
		object[] files;
		files = Resources.LoadAll ("DataFiles");
		foreach (object file in files) {
			TextAsset asset = (TextAsset)file;
			string[] splitName = asset.name.Split ('_');
			villageList.Add (splitName [0]);
			HHIDList.Add (splitName [1]);
		}
		villageTest = villageList.ToArray ();
		hhidTest = HHIDList.ToArray ();

		village = villageTest.Distinct ().ToArray ();
		hhid = hhidTest.Distinct ().ToArray ();
	}



	public void increaseVillage(){
		if (villageIndex < (village.Length-1)) {
			villageIndex++;
		}
		changedIndex = true;
	}
	public void increaseHHID(){
		if (hhidIndex < (hhid.Length-1)) {
			hhidIndex++;
		}
		changedIndex = true;
	}
	public void decreaseVillage(){
		if (villageIndex > 0) {
			villageIndex--;
		}
		changedIndex = true;
	}
	public void decreaseHHID(){
		if (hhidIndex > 0) {
			hhidIndex--;
		}
		changedIndex = true;
	}

//	public void saveData(){
//		globalControl.setVillageID(village [villageIndex]);
//		globalControl.setHHID(hhid[hhidIndex]);
//	}
}
