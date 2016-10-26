using UnityEngine;
using System.Collections;

public class MaizePlantMaterialMesh : MonoBehaviour
{
	public Material materialGreen;
	public Material materialBrown;
	public Material materialDry;
	[Range(0,1)] public float mix = 0f;
	[Range(0,1)] public float mixTarget = 0f;
	public float trackingSpeed = 1f;
	public int whichMats = 1;
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

		if (whichMats == 1)
		{
			rend.material.Lerp (materialGreen, materialBrown, mix);
		}
		if (whichMats == 2)
		{
			rend.material.Lerp (materialGreen, materialDry, mix);
		}
		if (whichMats == 3)
		{
			rend.material.Lerp (materialBrown, materialDry, mix);
		}
	}

	public void SetTarget(float newTarget)
	{
		mixTarget = newTarget;
	}
}