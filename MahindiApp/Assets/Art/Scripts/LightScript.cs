using UnityEngine;
using System.Collections;

public class LightScript : MonoBehaviour {
	Animator anim;
	int buttonHash2 = Animator.StringToHash("CloudyHigh");
	int buttonHash3 = Animator.StringToHash("CloudyMed");
	int buttonHash4 = Animator.StringToHash("CloudyLow");

	void Start ()
	{
		anim = GetComponent<Animator>();
	}

	public void CloudyHigh()
	{
		anim.SetTrigger (buttonHash2);
	}

	public void CloudyMed()
	{
		anim.SetTrigger (buttonHash3);
	}

	public void CloudyLow()
	{
		anim.SetTrigger (buttonHash4);
	}
}