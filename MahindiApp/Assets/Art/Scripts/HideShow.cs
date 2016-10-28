using UnityEngine;
using System.Collections;

public class HideShow : MonoBehaviour
{
	public Renderer rend;

	void Start ()
	{
		rend = GetComponent<Renderer>();
		rend.enabled = false;
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