using UnityEngine;
using System.Collections;

public class MaizePlantAnims : MonoBehaviour
{
	Animator[] anims;
	int buttonHash = Animator.StringToHash("Grow1");
	int buttonHash1 = Animator.StringToHash("Grow2");
	int buttonHash2 = Animator.StringToHash("Grow3");
	int buttonHash3 = Animator.StringToHash("GrowFull");
	int buttonHash4 = Animator.StringToHash("GrowMed");
	int buttonHash5 = Animator.StringToHash("GrowLow");
	int buttonHash6 = Animator.StringToHash("FullDry");
	int buttonHash7 = Animator.StringToHash("MedDry");
	int buttonHash8 = Animator.StringToHash("LowDry");

	void Start ()
	{
		anims = GetComponentsInChildren<Animator>();
	}

	public void Grow1()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash);
		}
	}
	public void Grow2()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash1);
		}
	}
	public void Grow3()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash2);
		}
	}
	public void GrowFull()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash3);
		}
	}
	public void GrowMed()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash4);
		}
	}
	public void GrowLow()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash5);
		}
	}
	public void FullDry()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash6);
		}
	}
	public void MedDry()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash7);
		}
	}
	public void LowDry()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash8);
		}
	}
}