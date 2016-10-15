using UnityEngine;
using System.Collections;

public class HideShow : MonoBehaviour
{
	public Renderer rend;

	void Start ()
	{
		rend = GetComponent<Renderer>();
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