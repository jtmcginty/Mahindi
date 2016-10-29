using UnityEngine;
using System.Collections;

public class CornBag : MonoBehaviour
{
	Animator[] anims;
	int buttonHash1 = Animator.StringToHash("Harv1");

	void Start ()
	{
		anims = GetComponentsInChildren<Animator>();
	}

	public void Harv1()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash1);
		}
	}
}