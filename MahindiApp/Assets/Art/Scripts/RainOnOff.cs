using UnityEngine;
using System.Collections;

public class RainOnOff : MonoBehaviour {
	Animator anim;
	int buttonHash = Animator.StringToHash("RainFirst");
	int buttonHash1 = Animator.StringToHash("RainHigh");
	int buttonHash2 = Animator.StringToHash("RainMedium");
	int buttonHash3 = Animator.StringToHash("RainLow");
	public DirtCoverMatBlender dirtblender;
	public DirtCoverMatBlender dirtblender2;
	public AnimPlant default1;
	public AnimPlant default2;

	void Start ()
	{
		anim = GetComponent<Animator>();
	}

	public void RainFirst()
	{
		anim.SetTrigger (buttonHash);
	}
	public void RainHigh()
	{
		anim.SetTrigger (buttonHash1);
	}
	public void RainMedium()
	{
		anim.SetTrigger (buttonHash2);
	}
	public void RainLow()
	{
		anim.SetTrigger (buttonHash3);
	}

	public void ResetDirtCoverMats()
	{
		dirtblender.SetTarget (1);
		dirtblender2.SetTarget (1);
	}

	public void ResetDirtCoverMatsOpaque()
	{
		dirtblender.SetTarget (0);
		dirtblender2.SetTarget (0);
	}
	public void ResetDirtCovers()
	{
		default1.SetDefault ();
		default2.SetDefault ();
	}
}