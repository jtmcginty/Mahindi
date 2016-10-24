using UnityEngine;
using System.Collections;

public class NextBagScript : MonoBehaviour {
	Animator anim;
	int buttonHash = Animator.StringToHash("NextBag");
	int buttonHash1 = Animator.StringToHash("NextBag2");

	void Start ()
	{
		anim = GetComponent<Animator>();
	}

	public void NextBag()
	{
		anim.SetTrigger (buttonHash);
	}

	public void NextBag2()
	{
		anim.SetTrigger (buttonHash1);
	}
}
