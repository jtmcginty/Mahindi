using UnityEngine;
using System.Collections;

public class CornBag26 : MonoBehaviour {
	public CornCob CornCobScript;

	public void StopCornCob()
	{
		Debug.LogError("About to stop corn cobs!");
		CornCobScript.StopCornCob ();
	}
}
