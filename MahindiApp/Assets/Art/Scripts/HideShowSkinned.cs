using UnityEngine;
using System.Collections;

public class HideShowSkinned : MonoBehaviour
{
	public SkinnedMeshRenderer rend;

	void Start ()
	{
		rend = GetComponentInChildren<SkinnedMeshRenderer> ();
	}

	public void Show()
	{
		rend.enabled = true;
	}
	public void Hide()
	{
		rend.enabled = false;
	}
}