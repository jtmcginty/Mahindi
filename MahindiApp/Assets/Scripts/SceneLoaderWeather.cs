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
	string hasCAN = "";
	//variables to save

	public void LoadScene(string sceneName) {
		SceneManager.LoadScene( sceneName );
	}
	public void loadWord(Text CANdata){
		if (CANdata.text != "0") {
			hasCAN = "Top";
		}
	}

	public void LoadSceneWeather(Text weather) {
		SceneManager.LoadScene( hasCAN + weather.text );
	}

	public void saveWeather (){
		//
	}

}

