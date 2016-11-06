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

	//variables to save
	public int weather;

	public void chooseWeather(){
		weather = rnd.Next (1, 4);
		if (weather == 1) {
			LoadScene ("Low");
		} else if (weather == 2) {
			LoadScene ("Med");
		} else
			LoadScene ("High");
	}

	public void LoadScene(string sceneName) {
		SceneManager.LoadScene( sceneName );
	}

	public void saveWeather (){
		//
	}

}

