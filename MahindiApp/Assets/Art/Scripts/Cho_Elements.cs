using UnityEngine;
using System.Collections;

public class Cho_Elements : MonoBehaviour {
	public CameraSwitcher cameraSwitcherR;
	public AnimPlant PlantPHole;
	public AnimPlant PlantStick;
	public AnimPlant PlantHand;
	public AnimPlant PlantFertilizer;
	public AnimPlant PlantThrowDirt;
	public AnimPlant PlantSeed;
	public AnimPlant PlantLeg;
	public AnimPlant PlantDirtCover;
	public RainOnOff RainOnOffSI;
	public LightScript CloudySI;
	public MaizePlantAnims MaizePlantAnimsSI;

	public void CamClose() {
		cameraSwitcherR.CamClose ();
	}

	public void CamMed() {
		cameraSwitcherR.CamMed ();
	}

	public void Plant() {
		PlantPHole.Plant ();
		PlantStick.Plant ();
		PlantHand.Plant ();
		PlantFertilizer.Plant ();
		PlantThrowDirt.Plant ();
		PlantSeed.Plant ();
		PlantLeg.Plant ();
		PlantDirtCover.Plant ();
	}

	public void RainFirst() {
		RainOnOffSI.RainFirst ();
		CloudySI.CloudyLow ();
	}

	public void RainHigh() {
		RainOnOffSI.RainHigh ();
		CloudySI.CloudyHigh ();
	}

	public void RainMed() {
		RainOnOffSI.RainMedium ();
		CloudySI.CloudyMed ();
	}

	public void RainLow() {
		RainOnOffSI.RainLow ();
		CloudySI.CloudyLow ();
	}

	public void Grow1() {
		MaizePlantAnimsSI.Grow1 ();
	}

	public void Grow2High() {
		MaizePlantAnimsSI.Grow2High ();
	}

	public void Grow2Med() {
		MaizePlantAnimsSI.Grow2Med ();
	}

	public void Grow2Low() {
		MaizePlantAnimsSI.Grow2Low ();
	}
}