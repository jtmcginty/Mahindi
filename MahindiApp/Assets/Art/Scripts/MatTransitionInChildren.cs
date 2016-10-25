using UnityEngine;
using System.Collections;

public class MatTransitionInChildren : MonoBehaviour {

	public Material material1;
	public Material material2;
	[Range(0,1)] public float mix = 0f;

	[Range(0,1)] public float mixTarget = 0f;
	public float trackingSpeed = 1f;

	Renderer[] rends;

	void Start() {
		rends = GetComponentsInChildren<Renderer>();
	}
	public void Update() {
		if (mix != mixTarget && trackingSpeed > 0) {
			mix = Mathf.MoveTowards (mix, mixTarget, trackingSpeed * Time.deltaTime);
		}
		foreach (Renderer rend in rends) {
			if (rend != null)
				rend.material.Lerp (material1, material2, mix);
		}
	}
	public void SetTarget(float newTarget) {
		mixTarget = newTarget;
	}
}