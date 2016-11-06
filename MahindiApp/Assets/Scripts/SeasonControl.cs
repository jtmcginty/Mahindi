using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class SeasonControl : MonoBehaviour 
{
	public static SeasonControl Instance;


	//Variables to save
	public string DAP;
	public string CAN;
	public string L;
	public string W;
	public string village;
	public string hhid;

	public Text DAPText;
	public Text CANText;
	public Text LText;
	public Text WText;
	public Text villageText;
	//public Text hhidText;

	void Awake ()   
	{
		if (Instance == null)
		{
			DontDestroyOnLoad(gameObject);
			Instance = this;
		}
		else if (Instance != this)
		{
			Destroy (gameObject);
		}
	}
	void Start(){
		DAPText.text = DAP;
		CANText.text = CAN;
		LText.text = L;
		WText.text = W;
	}
	void update(){
		
	
	}

	public SeasonControl getInstance(){
		return Instance;
	}

	public void updateDAP(Text myDAP){
		Instance.DAP = myDAP.text;
	}
	public void updateCAN(Text myCAN){
		Instance.CAN = myCAN.text;
	}
	public void updateL(Text myL){
		Instance.L = myL.text;
	}
	public void updateW(Text myW){
		Instance.W = myW.text;
	}
	public void updateVillage(Text myVillage){
		village = myVillage.text;
	}
	public void updateHHID(Text myHHID){
		Instance.hhid = myHHID.text;
	}

	public string getDAP(){
		return DAP;
	}
	public string getCAN(){
		return CAN;
	}
	public string getL(){
		return L;
	}
	public string getW(){
		return W;
	}
	public string getVillage(){
		return village;
	}
	public string getHHID(){
		return hhid;
	}
	public void setDAP (Text dapText){
		dapText.text = DAP;
	}

}


