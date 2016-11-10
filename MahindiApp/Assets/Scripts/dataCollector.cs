using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class dataCollector : MonoBehaviour
{
	// Text Asset Variables
	string villageNum = "hi";
	string hhid = "555";

	public Text DAPText;
	public Text CANText;
	public Text LText;
	public Text WText;
	public Text cropYield;

	public string totalYield = "Total Yield";

	public int indexDAP = 0;
	public int indexCAN = 0;
	public int indexL = 0;
	public int indexW = 0;
	public int indexYield = 0;

	public string[] dataDAP;
	public string[] dataCAN;
	public string[] dataL;
	public string[] dataW;
	public string[] yieldTotal;

	public string[] dataDAPtest;
	public string[] dataCANtest;
	public string[] dataLtest;
	public string[] dataWtest;
	public string[] yieldTotaltest;

	public string DAP;
	public string CAN;
	public string L;
	public string W;
	public string Yield;


	List<string> listDataDAP = new List<string> ();
	List<string> listDataCAN = new List<string> ();
	List<string> listDataL = new List<string> ();
	List<string> listDataW = new List<string> ();
	List<string> listYieldTotal = new List<string> ();

	Boolean changedIndex = false;


	// Use this for initialization
	void Start ()
	{
		
		loadData ();
		DAPText.text = dataDAP[indexDAP];
		CANText.text = dataCAN[indexCAN];
		LText.text = dataL[indexL];
		WText.text = "Low";
		//cropYield.text = totalYield;
		//saveData ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (changedIndex) {
			DAPText.text = dataDAP [indexDAP];
			CANText.text = dataCAN [indexCAN];
			LText.text = dataL [indexL];
			if (dataW [indexW] == "1") {
				WText.text = "Low";
			} else if (dataW [indexW] == "2") {
				WText.text = "Med";
			} else if (dataW [indexW] == "3") {
				WText.text = "High";
			}
			//cropYield.text = totalYield;
			//saveData ();
		}
	}



	public void loadData(){
		
		string currLine;
		TextAsset csvData = (TextAsset)Resources.Load ("DataFiles/32_555", typeof(TextAsset));
		string dataFile = csvData.text;
		string[] stringSeparators = new string[] {"D_", "_C_", "_L_", "_W"};
		string[] fileLines = dataFile.Split("\n"[0]);

		for (int i = 0; i < fileLines.Length; i++) {
			currLine = fileLines [i];
			string [] lineItems = currLine.Split (',');
			string dataItems = lineItems [7];
			string lineYield = lineItems [19];
			string[] splitData = dataItems.Split (stringSeparators, StringSplitOptions.None);
			listDataDAP.Add(splitData[1]);
			listDataCAN.Add(splitData[2]);
			listDataL.Add(splitData[3]);
			listDataW.Add(splitData[4]);
			listYieldTotal.Add(lineYield);
		}

		dataDAPtest = listDataDAP.ToArray ();
		dataCANtest = listDataCAN.ToArray ();
		dataLtest = listDataL.ToArray ();
		dataWtest = listDataW.ToArray ();
		yieldTotal = listYieldTotal.ToArray ();
	
		dataDAP = dataDAPtest.Distinct().ToArray ();
		dataCAN = dataCANtest.Distinct().ToArray ();
		dataL = dataLtest.Distinct().ToArray ();
		dataW = dataWtest.Distinct ().ToArray ();
	}

	public void increaseDAPIndex(){
		if (indexDAP < (dataDAP.Length - 1)) {
			indexDAP++;
		}
		changedIndex = true;
	}
	public void increaseCANIndex(){
		if (indexCAN < (dataCAN.Length-1)) {
			indexCAN++;
		}
		changedIndex = true;
	}
	public void increaseLIndex(){
		if (indexL < (dataL.Length-1)) {
			indexL++;
		}
		changedIndex = true;
	}
	public void increaseWIndex(){
		if (indexW < (dataW.Length-1)) {
			indexW++;
		}
		changedIndex = true;
	}
	public void decreaseDAPIndex(){
		if (indexDAP > 0) {
			indexDAP--;
		}
		changedIndex = true;
	}
	public void decreaseCANIndex(){
		if (indexCAN > 0) {
			indexCAN--;
		}
		changedIndex = true;
	}
	public void decreaseLIndex(){
		if (indexL > 0) {
			indexL--;
		}
		changedIndex = true;
	}
	public void decreaseWIndex(){
		if (indexW > 0) {
			indexW--;
		}
		changedIndex = true;
	}

	public void findYield(){
		changedIndex = true;
		int DAP = Int32.Parse(dataDAP[indexDAP]);
		int CAN = Int32.Parse(dataCAN[indexCAN]);
		int L = Int32.Parse(dataL[indexL]);
		int W = Int32.Parse (dataW [indexW]);
		Debug.Log (DAP);
		Debug.Log (CAN);
		Debug.Log (L);
		Debug.Log (W);

		indexYield = 0;
		while (Int32.Parse(dataLtest [indexYield]) != L) {
			indexYield++;
			Debug.Log (indexYield);
		}
		Debug.Log (indexYield);
		while (Int32.Parse(dataCANtest [indexYield]) != CAN) {
			indexYield++;
			Debug.Log (indexYield);
		}
		Debug.Log (indexYield);
		while (Int32.Parse(dataDAPtest [indexYield]) != DAP) {
			indexYield++;
			Debug.Log (indexYield);
		}
		Debug.Log (indexYield);
		while (Int32.Parse (dataWtest [indexYield]) != W) {
			indexYield++;
			Debug.Log (indexYield);
		}
		Debug.Log (indexYield);
		totalYield = yieldTotal [indexYield];

		PlayerPrefs.SetString("TotalYield", totalYield);
	}

	public void saveData(){
		GlobalControl.Instance.DAP = dataDAP [indexDAP];
		GlobalControl.Instance.CAN = dataCAN [indexCAN];
		GlobalControl.Instance.L = dataL [indexL];
	}



}

