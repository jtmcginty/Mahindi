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
	public LightScript CloudyHighSI;
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
		CloudyHighSI.CloudyLow ();
	}

	public void RainHigh() {
		RainOnOffSI.RainHigh ();
		CloudyHighSI.CloudyHigh ();
	}

	public void Grow1() {
		MaizePlantAnimsSI.Grow1 ();
	}

	public void Grow2High() {
		MaizePlantAnimsSI.Grow2High ();
	}
}