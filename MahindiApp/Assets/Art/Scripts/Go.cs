using UnityEngine;
using System.Collections;

public class Go : MonoBehaviour
{
	Animator[] anims;
	int buttonHash = Animator.StringToHash("Go");

	void Start ()
	{
		anims = GetComponentsInChildren<Animator>();
	}

	public void GoNow()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash);
		}
	}
}