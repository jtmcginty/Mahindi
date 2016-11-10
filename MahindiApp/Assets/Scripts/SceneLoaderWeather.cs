using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;

public class SceneLoaderWeather : MonoBehaviour
{
	public System.Random rnd = new System.Random ();
	public Text CAN;
	public Text DAP;
	string hasCAN = "";
	string hasDAP = "";
	//variables to save



	public void LoadScene(string sceneName) {
		SceneManager.LoadScene( sceneName );
	}
	public void loadWord(Text CANdata){
		if (CANdata.text != "0") {
			hasCAN = "Top";
		}
	}
	public void loadWordDAP(Text DAPdata){
		if (DAPdata.text == "0") {
			hasDAP = "NoF";
		}
	}
	public void execute(){
		
	}


	public void LoadSceneWeather(Text weather) {
		loadWord (CAN);
		loadWordDAP (DAP);
		SceneManager.LoadScene( hasCAN + hasDAP + weather.text );
	}



	public void saveCAN (Text CANdata){
		PlayerPrefs.SetString ("dataCAN",CANdata.text);
	}
	public void saveDAP (Text DAPdata){
		PlayerPrefs.SetString ("dataDAP",DAPdata.text);
	}
	public void saveL (Text Ldata){
		PlayerPrefs.SetString ("dataL",Ldata.text);
	}
	public void saveW (Text Wdata){
		PlayerPrefs.SetString ("dataW",Wdata.text);
	}

}

