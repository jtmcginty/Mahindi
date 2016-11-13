using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	public Text CANdata;
	public Text DAPdata;
	public Text Ldata;
	public Text Wdata;
	public Text Yield;
	public Text Village;
	public Text HHID;

	public string tempYield;
	public int hectareYield;
	public double acreYield;
	public double numBagsYield;


	public int valW;
	public int valCAN;
	public int valDAP;
	public int valL;

	string tempW;

	void Start(){
		getAndSetCAN (CANdata);
		getAndSetDAP (DAPdata);
		getAndSetL (Ldata);
		getAndSetW (Wdata);
		getAndSetYield (Yield);
		getAndSetVillage (Village);
		getAndSetHHID (HHID);
	}

	public void LoadScene(string sceneName) {
		SceneManager.LoadScene( sceneName );
	}
	public void getAndSetCAN(Text CANdata){
		CANdata.text = PlayerPrefs.GetString ("dataCAN");
	}
	public void getAndSetDAP(Text DAPdata){
		DAPdata.text = PlayerPrefs.GetString ("dataDAP");
	}
	public void getAndSetL(Text Ldata){
		Ldata.text = PlayerPrefs.GetString ("dataL");
	}
	public void getAndSetW(Text Wdata){
		Wdata.text = PlayerPrefs.GetString ("dataW");
	}
	public void getAndSetYield(Text Yield){
		tempYield = PlayerPrefs.GetString ("TotalYield");
		hectareYield = Int32.Parse (tempYield);
		acreYield = hectareYield / (2.471057);
		numBagsYield = acreYield / 90;
		Yield.text = numBagsYield.ToString("F0");
	}
	public void getAndSetVillage(Text Village){
		Village.text = PlayerPrefs.GetString ("Village");
	}
	public void getAndSetHHID(Text HHID){
		HHID.text = PlayerPrefs.GetString ("HHID");
	}
	public void saveVillage (Text Village){
		PlayerPrefs.SetString ("Village",Village.text);
	}
	public void saveHHID (Text HHID){
		PlayerPrefs.SetString ("HHID",HHID.text);
	}

}
