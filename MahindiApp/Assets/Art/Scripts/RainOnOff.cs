using UnityEngine;
using System.Collections;

public class RainOnOff : MonoBehaviour {
	Animator anim;
	int buttonHash1 = Animator.StringToHash("RainHigh");
	int buttonHash2 = Animator.StringToHash("RainMedium");
	int buttonHash3 = Animator.StringToHash("RainLow");
	int buttonHash4 = Animator.StringToHash("RainOff");

	void Start ()
	{
		anim = GetComponent<Animator>();
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

	public void RainOff()
	{
		anim.SetTrigger (buttonHash4);
	}
}