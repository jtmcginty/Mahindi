using UnityEngine;
using System.Collections;

public class CamAimSwitcher : MonoBehaviour {
	public Transform target1;
	public Transform target2;

	public void CamAimCenter() {
		CamAimPosition follower = GetComponent<CamAimPosition>();
		if (follower == null) Debug.LogError("Hey, where's the CamAimPosition script?!?");

		follower.target = target1;
	}
	public void CamAimHarvest() {
		CamAimPosition follower = GetComponent<CamAimPosition> ();
		if (follower == null) Debug.LogError ("Hey, where's the CameraPosition script?!?");

		follower.target = target2;
	}
}