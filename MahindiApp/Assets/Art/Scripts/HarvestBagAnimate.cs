using UnityEngine;
using System.Collections;

public class HarvestBagAnimate : MonoBehaviour
{
	Animator[] anims;
	int buttonHash = Animator.StringToHash("StartHarvest");

	void Start ()
	{
		anims = GetComponentsInChildren<Animator>();
	}

	public void StartHarvest()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash);
		}
	}
}