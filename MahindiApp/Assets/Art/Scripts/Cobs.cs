using UnityEngine;
using System.Collections;

public class Cobs : MonoBehaviour {
	Animator anim;
	int buttonHash = Animator.StringToHash("HarvestCobs");

	void Start ()
	{
		anim = GetComponent<Animator>();
	}

	public void HarvestCobs()
	{
		anim.SetTrigger (buttonHash);
	}
}