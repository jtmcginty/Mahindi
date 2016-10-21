using UnityEngine;
using System.Collections;

public class MatSwap : MonoBehaviour {

	public Material material1;
	public Material material2;
	[Range(0,1)] public float mix = 0f;
	Renderer rend;

	void Start() {
		rend = GetComponent<Renderer>();
	}
	public void Update() {
		if (rend != null) rend.material.Lerp(material1, material2, mix);
	}
}
