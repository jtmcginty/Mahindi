using UnityEngine;
using System.Collections;

public class AnimPlant : MonoBehaviour {
	Animator anim;
	int buttonHash = Animator.StringToHash("Plant");
	int buttonHash1 = Animator.StringToHash("TopDressing");
	int buttonHash2 = Animator.StringToHash("SetDefault");
	int buttonHash3 = Animator.StringToHash("PlantNoF");

	void Start ()
	{
		anim = GetComponent<Animator>();
	}

	public void Plant()
	{
		anim.SetTrigger (buttonHash);
	}
	public void TopDressing()
	{
		anim.SetTrigger (buttonHash1);
	}
	public void SetDefault()
	{
		anim.SetTrigger (buttonHash2);
	}
	public void PlantNoF()
	{
		anim.SetTrigger (buttonHash3);
	}
}