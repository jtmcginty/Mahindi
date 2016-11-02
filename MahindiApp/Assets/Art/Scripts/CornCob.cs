using UnityEngine;
using System.Collections;

public class CornCob : MonoBehaviour
{
	Animator[] anims;
	int buttonHash = Animator.StringToHash("PlayCornCob");
	int buttonHash1 = Animator.StringToHash("StopCornCob");

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

	public void StopCornCob()
	{
		Debug.LogError("About to stop corn cobs really!");
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash1);
		}
	}
}