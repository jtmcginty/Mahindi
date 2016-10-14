using UnityEngine;
using System.Collections;

public class AnimPlant : MonoBehaviour {
	Animator anim;
	int buttonHash = Animator.StringToHash("Plant");

	void Start ()
	{
		anim = GetComponent<Animator>();
	}

	public void Plant()
	{
		anim.SetTrigger (buttonHash);
	}
}