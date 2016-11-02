using UnityEngine;
using System.Collections;

public class Cho_Elements : MonoBehaviour {
	public CameraSwitcher cameraSwitcherR;
	public AnimPlant PlantStick;
	public AnimPlant PlantHand;

	public void CamClose() {
		cameraSwitcherR.CamClose ();
	}

	public void Plant() {
		PlantStick.Plant ();
		PlantHand.Plant ();
	}
}