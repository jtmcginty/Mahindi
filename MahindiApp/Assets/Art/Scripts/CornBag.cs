using UnityEngine;
using System.Collections;

public class CornBag : MonoBehaviour {
	Animator anim;
	int buttonHash = Animator.StringToHash("StartHarv");

	void Start ()
	{
		anim = GetComponent<Animator>();
	}
	
	public void StartHarv()
	{
		anim.SetTrigger (buttonHash);
	}
}