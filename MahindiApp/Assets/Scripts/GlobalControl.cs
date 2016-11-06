using UnityEngine;
using System.Collections;

public class GlobalControl : MonoBehaviour 
{
	public static GlobalControl Instance;


	//Variables to save
	public string DAP;
	public string CAN;
	public string L;
	public string W;
	public string village;
	public string hhid;

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
}


