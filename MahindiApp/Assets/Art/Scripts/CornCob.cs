using UnityEngine;
using System.Collections;

public class CornCob : MonoBehaviour
{
	Animator[] anims;
	int buttonHash = Animator.StringToHash("PlayCornCob");

	void Start ()
	{
		anims = GetComponentsInChildren<Animator>();
	}

	public void PlayCornCob()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash);
		}
	}
}