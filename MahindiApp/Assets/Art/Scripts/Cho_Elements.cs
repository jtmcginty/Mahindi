﻿using UnityEngine;
using System.Collections;

public class Cho_Elements : MonoBehaviour {
	public CameraSwitcher cameraSwitcherR;
	public CamAimSwitcher cameraAimSwitcherR;
	public AnimPlant PlantPHole;
	public AnimPlant PlantFHole;
	public AnimPlant PlantStick;
	public AnimPlant PlantHand;
	public AnimPlant PlantFertilizer;
	public AnimPlant PlantThrowDirt;
	public AnimPlant PlantSeed;
	public AnimPlant PlantLeg;
	public AnimPlant PlantDirtCover;
	public AnimPlant PlantDirtCover2;
	public RainOnOff RainOnOffSI;
	public LightScript CloudySI;
	public MaizePlantAnims MaizePlantAnimsSI;
	public HideShow PBHighVis;
	public HideShow PBHighCobsVis;
	public HideShow PBMedVis;
	public HideShow PBMedCobsVis;
	public HideShow PBLowVis;
	public HideShow PBLowCobsVis;
	public CornBag CornBagSI;
	public CornCob CornCobSI;

	public void CamClose() {
		cameraSwitcherR.CamClose ();
		cameraAimSwitcherR.CamAimCenter ();
	}

	public void CamMed() {
		cameraSwitcherR.CamMed ();
		cameraAimSwitcherR.CamAimCenter ();
	}

	public void CamHarv() {
		cameraSwitcherR.CamHarvest ();
		cameraAimSwitcherR.CamAimHarvest ();
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

	public void TopDressing() {
		PlantFHole.TopDressing ();
		PlantStick.TopDressing ();
		PlantHand.TopDressing ();
		PlantFertilizer.TopDressing ();
		PlantLeg.TopDressing ();
		PlantDirtCover2.TopDressing ();
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

	public void HarvestPrepHigh() {
		cameraSwitcherR.CamMedSnap ();
		cameraAimSwitcherR.CamAimCenter ();
		MaizePlantAnimsSI.High_Static ();
		PBHighVis.Show ();
		PBHighCobsVis.Show ();
		CornBagSI.StartHarv ();
		CornCobSI.PlayCornCob ();
	}

	public void HarvestPrepMed() {
		cameraSwitcherR.CamMedSnap ();
		cameraAimSwitcherR.CamAimCenter ();
		MaizePlantAnimsSI.Med_Static ();
		PBMedVis.Show ();
		PBMedCobsVis.Show ();
		CornBagSI.StartHarv ();
		CornCobSI.PlayCornCob ();
	}

	public void HarvestPrepLow() {
		cameraSwitcherR.CamMedSnap ();
		cameraAimSwitcherR.CamAimCenter ();
		MaizePlantAnimsSI.Low_Static ();
		PBLowVis.Show ();
		PBLowCobsVis.Show ();
		CornBagSI.StartHarv ();
		CornCobSI.PlayCornCob ();
	}

	public void HarvestStartDryHigh() {
		MaizePlantAnimsSI.DryHigh ();
	}

	public void HarvestStartDryMed() {
		MaizePlantAnimsSI.DryMed ();
	}

	public void HarvestStartDryLow() {
		MaizePlantAnimsSI.DryLow ();
	}

	public void Harvesting() {
		CornBagSI.StartHarv ();
		CornCobSI.PlayCornCob ();
	}
}