using UnityEngine;
using System.Collections;

public class CornBag : MonoBehaviour {
	Animator[] anims;
	int buttonHash = Animator.StringToHash("StartHarv");

	void Start () {
		anims = GetComponentsInChildren<Animator>();
	}
	
	public void StartHarv() {
		foreach (Animator anim in anims) {
			anim.SetTrigger (buttonHash);
		}
	}
}