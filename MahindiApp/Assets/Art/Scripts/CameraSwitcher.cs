using UnityEngine;
using System.Collections;

public class CameraSwitcher : MonoBehaviour {
	public Transform targetfar;
	public Transform targetmed;
	public Transform targetclose;

	public void CamFar() {
		CameraPosition follower = GetComponent<CameraPosition>();
		if (follower == null) Debug.LogError("Hey, where's the CameraPosition script?!?");

		follower.target = targetfar;
	}
	public void CamMed() {
		CameraPosition follower = GetComponent<CameraPosition>();
		if (follower == null) Debug.LogError("Hey, where's the CameraPosition script?!?");

		follower.target = targetmed;
	}
	public void CamClose() {
		CameraPosition follower = GetComponent<CameraPosition>();
		if (follower == null) Debug.LogError("Hey, where's the CameraPosition script?!?");

		follower.target = targetclose;
	}
}