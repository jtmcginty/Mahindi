using UnityEngine;
using System.Collections;

public class Cho_Sequences : MonoBehaviour {
	Animator anim;
	int buttonHash = Animator.StringToHash("PlantGrowHigh");
	int buttonHash1 = Animator.StringToHash("PlantGrowMed");
	int buttonHash2 = Animator.StringToHash("PlantGrowLow");

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
}