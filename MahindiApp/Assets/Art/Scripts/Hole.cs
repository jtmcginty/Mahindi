using UnityEngine;
using System.Collections;

public class Hole : MonoBehaviour {
	Animator anim;
	int buttonHash1 = Animator.StringToHash("MakeHole");
	int buttonHash2 = Animator.StringToHash("ResetHole");

	void Start ()
	{
		anim = GetComponent<Animator>();
	}

	public void MakeHole()
	{
		anim.SetTrigger (buttonHash1);
	}

	public void ResetHole()
	{
		anim.SetTrigger (buttonHash2);
	}
}