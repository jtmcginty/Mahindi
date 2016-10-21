using UnityEngine;
using System.Collections;

public class RainOnOff : MonoBehaviour {
	Animator anim;
	int buttonHash1 = Animator.StringToHash("RainOn");
	int buttonHash2 = Animator.StringToHash("RainOff");

	void Start ()
	{
		anim = GetComponent<Animator>();
	}

	public void RainOn()
	{
		anim.SetTrigger (buttonHash1);
	}

	public void RainOff()
	{
		anim.SetTrigger (buttonHash2);
	}
}