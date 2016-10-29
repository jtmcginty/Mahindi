using UnityEngine;
using System.Collections;

public class Leg : MonoBehaviour
{
	public DirtCoverMatBlender dirtblender;
	public DirtCoverMatBlender dirtblender2;

	public void SetBothTargets()
	{
		dirtblender.SetTarget (0);
		dirtblender2.SetTarget (0);
	}
}
