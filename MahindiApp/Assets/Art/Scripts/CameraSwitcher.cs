using UnityEngine;
using System.Collections;

public class CameraSwitcher : MonoBehaviour {
	public Transform targetfar;
	public Transform targetmed;
	public Transform targetclose;
	public Transform targetharvest;

	public void CamFar() {
		CameraPosition follower = GetComponent<CameraPosition>();
		if (follower == null) Debug.LogError("Hey, where's the CameraPosition script?!?");

		follower.target = targetfar;
		follower.smoothTime = 0.4f;
	}
	public void CamMed() {
		CameraPosition follower = GetComponent<CameraPosition>();
		if (follower == null) Debug.LogError("Hey, where's the CameraPosition script?!?");

		follower.target = targetmed;
		follower.smoothTime = 0.4f;
	}
	public void CamClose() {
		CameraPosition follower = GetComponent<CameraPosition>();
		if (follower == null) Debug.LogError("Hey, where's the CameraPosition script?!?");

		follower.target = targetclose;
		follower.smoothTime = 0.4f;
	}
	public void CamHarvest() {
		CameraPosition follower = GetComponent<CameraPosition>();
		if (follower == null) Debug.LogError("Hey, where's the CameraPosition script?!?");

		follower.target = targetharvest;
		follower.smoothTime = 0.9f;
	}
	public void CamMedSnap() {
		CameraPosition follower = GetComponent<CameraPosition>();
		follower.smoothTime = 0f;
		follower.target = targetmed;
	}
}