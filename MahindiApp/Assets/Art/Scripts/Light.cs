using UnityEngine;
using System.Collections;

public class Light : MonoBehaviour {
	Animator anim;
	int buttonHash1 = Animator.StringToHash("Sunny");
	int buttonHash2 = Animator.StringToHash("Cloudy");

	void Start ()
	{
		anim = GetComponent<Animator>();
	}

	public void Sunny()
	{
		anim.SetTrigger (buttonHash1);
	}

	public void Cloudy()
	{
		anim.SetTrigger (buttonHash2);
	}
}