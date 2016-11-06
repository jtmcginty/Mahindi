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

	public void PauseAnim() {
		foreach (Animator anim in anims) {
			anim.speed = 0f;
		}
	}

	public void FastAnim() {
		foreach (Animator anim in anims) {
			anim.speed = 3f;
		}
	}

	public void NormalAnim() {
		foreach (Animator anim in anims) {
			anim.speed = 1f;
		}
	}

	public void SlowAnim() {
		foreach (Animator anim in anims) {
			anim.speed = .5f;
		}
	}

	public void SpeedHigh() {
		foreach (Animator anim in anims) {
			anim.speed = 3f;
		}
	}

	public void SpeedMed() {
		foreach (Animator anim in anims) {
			anim.speed = 1.29f;
		}
	}

	public void SpeedLow() {
		foreach (Animator anim in anims) {
			anim.speed = .7f;
		}
	}
}