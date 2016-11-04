using UnityEngine;
using System.Collections;

public class CornCob : MonoBehaviour
{
	Animator[] anims;
	int buttonHash = Animator.StringToHash("StopCornCob");
	int buttonHash1 = Animator.StringToHash("PlayCornCob");
	int buttonHash2 = Animator.StringToHash("PlayCornCob1");
	int buttonHash3 = Animator.StringToHash("PlayCornCob2");
	int buttonHash4 = Animator.StringToHash("PlayCornCob3");
	int buttonHash5 = Animator.StringToHash("PlayCornCob4");
	int buttonHash6 = Animator.StringToHash("PlayCornCob5");
	int buttonHash7 = Animator.StringToHash("PlayCornCob6");
	int buttonHash8 = Animator.StringToHash("PlayCornCob7");
	int buttonHash9 = Animator.StringToHash("PlayCornCob8");


	void Start ()
	{
		anims = GetComponentsInChildren<Animator>();
	}

	public void StopCornCob()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash);
		}
	}

	public void PlayCornCob()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash1);
			anim.speed = 1f;
		}
	}

	public void PlayCornCob1()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash2);
			anim.speed = 1f;
		}
	}

	public void PlayCornCob2()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash3);
			anim.speed = 1f;
		}
	}

	public void PlayCornCob3()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash4);
			anim.speed = 1f;
		}
	}

	public void PlayCornCob4()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash5);
			anim.speed = 1f;
		}
	}

	public void PlayCornCob5()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash6);
			anim.speed = 1f;
		}
	}

	public void PlayCornCob6()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash7);
			anim.speed = 1f;
		}
	}

	public void PlayCornCob7()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash8);
			anim.speed = 1f;
		}
	}

	public void PlayCornCob8()
	{
		foreach (Animator anim in anims)
		{			
			anim.SetTrigger (buttonHash9);
			anim.speed = 1f;
		}
	}

	public void FastAnim()
	{
		foreach (Animator anim in anims)
		{			
			anim.speed = 3f;
		}
	}

	public void NormalAnim()
	{
		foreach (Animator anim in anims)
		{			
			anim.speed = 1f;
		}
	}

	public void SlowAnim()
	{
		foreach (Animator anim in anims)
		{			
			anim.speed = .5f;
		}
	}
}