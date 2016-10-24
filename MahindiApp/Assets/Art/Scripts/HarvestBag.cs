using UnityEngine;
using System.Collections;

public class HarvestBag : MonoBehaviour {
	Animator anim;
	int buttonHash = Animator.StringToHash("StartHarvest");
	public HideShowChildren ParentOfObjects;
	public NextBagScript NextBagOverThere;

	void Start ()
	{
		anim = GetComponent<Animator>();
	}

	public void StartHarvest()
	{
		anim.SetTrigger (buttonHash);
	}

	public void ShowPlayNextBag() {
		ParentOfObjects.ShowChildren ();
		NextBagOverThere.NextBag ();
	}

	public void ShowPlayNextBag2() {
		ParentOfObjects.ShowChildren ();
		NextBagOverThere.NextBag2 ();
	}
}