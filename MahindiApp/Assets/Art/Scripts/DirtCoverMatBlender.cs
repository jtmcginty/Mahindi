using UnityEngine;
using System.Collections;

public class DirtCoverMatBlender : MonoBehaviour
{
	public Material materialOpaque;
	public Material materialTransparent;
	[Range(0,1)] public float mix = 0f;
	[Range(0,1)] public float mixTarget = 0f;
	public float trackingSpeed = 2.5f;
	Renderer rend;

	void Start()
	{
		rend = GetComponent<Renderer> ();
	}

	public void Update()
	{
		if (mix != mixTarget && trackingSpeed > 0)
		{
			mix = Mathf.MoveTowards(mix, mixTarget, trackingSpeed * Time.deltaTime);
		}
		rend.material.Lerp (materialOpaque, materialTransparent, mix);
	}

	public void SetTarget(float newTarget)
	{
		mixTarget = newTarget;
	}
}