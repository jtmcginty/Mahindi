using UnityEngine;
using System.Collections;

public class HideShowChildren : MonoBehaviour {
	Renderer[] rends;

	void Start () {
		rends = GetComponentsInChildren<Renderer> ();
	}

	public void HideChildren() {
		foreach (Renderer rend in rends) {
			rend.enabled = false;
		}
	}

	public void ShowChildren() {
		foreach (Renderer rend in rends) {
			rend.enabled = true;
		}
	}
}