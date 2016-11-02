using UnityEngine;
using System.Collections;

public class Cho_Sequences : MonoBehaviour {
	Animator anim;
	int buttonHash = Animator.StringToHash("PlantGrowHigh");

	void Start () {
		anim = GetComponent<Animator>();
	}

	public void PlantGrowHigh() {
		anim.SetTrigger (buttonHash);
	}
}