using UnityEngine;
using System.Collections;

public class MaizePlantAnims : MonoBehaviour
{
	Animator[] anims;
	int buttonHash = Animator.StringToHash("Grow1");
	int buttonHash1 = Animator.StringToHash("Grow2High");
	int buttonHash2 = Animator.StringToHash("Grow2Med");
	int buttonHash3 = Animator.StringToHash("Grow2Low");
	int buttonHash4 = Animator.StringToHash("DryHigh");
	int buttonHash5 = Animator.StringToHash("DryMed");
	int buttonHash6 = Animator.StringToHash("DryLow");
	int buttonHash7 = Animator.StringToHash("High_Static");
	int buttonHash8 = Animator.StringToHash("Med_Static");
	int buttonHash9 = Animator.StringToHash("Low_Static");

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
	public void Grow2High()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash1);
		}
	}
	public void Grow2Med()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash2);
		}
	}
	public void Grow2Low()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash3);
		}
	}
	public void DryHigh()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash4);
		}
	}
	public void DryMed()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash5);
		}
	}
	public void DryLow()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash6);
		}
	}
	public void High_Static()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash7);
		}
	}
	public void Med_Static()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash8);
		}
	}
	public void Low_Static()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash9);
		}
	}
}