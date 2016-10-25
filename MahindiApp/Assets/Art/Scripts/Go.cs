using UnityEngine;
using System.Collections;

public class Go : MonoBehaviour
{
	Animator[] anims;
	Animator anim;
	int buttonHash = Animator.StringToHash("GoNow");
	int buttonHash1 = Animator.StringToHash("DryNow");
	int buttonHash2 = Animator.StringToHash("Dry");

	void Start ()
	{
		anim = GetComponent<Animator>();
		anims = GetComponentsInChildren<Animator>();
	}

	public void GoNow()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash);
		}
	}
	public void DryNow()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash1);
		}
	}
	public void Dry()
	{
		anim.SetTrigger (buttonHash2);
	}
}