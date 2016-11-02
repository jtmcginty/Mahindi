using UnityEngine;
using System.Collections;

public class Cho_Sequences : MonoBehaviour {
	Animator anim;
	int buttonHash = Animator.StringToHash("PlantGrowHigh");
	int buttonHash1 = Animator.StringToHash("PlantGrowMed");
	int buttonHash2 = Animator.StringToHash("PlantGrowLow");
	int buttonHash3 = Animator.StringToHash("PlantGrowTopHigh");
	int buttonHash4 = Animator.StringToHash("PlantGrowTopMed");
	int buttonHash5 = Animator.StringToHash("PlantGrowTopLow");
	int buttonHash6 = Animator.StringToHash("HarvestHigh");
	int buttonHash7 = Animator.StringToHash("HarvestMed");
	int buttonHash8 = Animator.StringToHash("HarvestLow");

	void Start () {
		anim = GetComponent<Animator>();
	}

	public void PlantGrowHigh() {
		anim.SetTrigger (buttonHash);
	}

	public void PlantGrowMed() {
		anim.SetTrigger (buttonHash1);
	}

	public void PlantGrowLow() {
		anim.SetTrigger (buttonHash2);
	}

	public void PlantGrowTopHigh() {
		anim.SetTrigger (buttonHash3);
	}

	public void PlantGrowTopMed() {
		anim.SetTrigger (buttonHash4);
	}

	public void PlantGrowTopLow() {
		anim.SetTrigger (buttonHash5);
	}

	public void HarvestHigh() {
		anim.SetTrigger (buttonHash6);
	}

	public void HarvestMed() {
		anim.SetTrigger (buttonHash7);
	}

	public void HarvestLow() {
		anim.SetTrigger (buttonHash8);
	}
}