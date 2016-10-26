using UnityEngine;
using System.Collections;

public class MaizePlantMaterialChanger : MonoBehaviour {
	MaizePlantMaterialMesh[] matTrans;

	void Start () {
		matTrans = GetComponentsInChildren<MaizePlantMaterialMesh>();
	}

	public void GreenBrown(float newTarget) {
		foreach (MaizePlantMaterialMesh matTran in matTrans) {
			matTran.whichMats = 1;
			matTran.trackingSpeed = 1;
			matTran.mixTarget = newTarget;
		}
	}

	public void GreenDry(float newTarget) {
		foreach (MaizePlantMaterialMesh matTran in matTrans) {
			matTran.whichMats = 2;
			matTran.trackingSpeed = 1;
			matTran.mixTarget = newTarget;
		}
	}

	public void BrownDry(float newTarget) {
		foreach (MaizePlantMaterialMesh matTran in matTrans) {
			matTran.whichMats = 3;
			matTran.trackingSpeed = 1;
			matTran.mixTarget = newTarget;
		}
	}

	public void SetBrown() {
		foreach (MaizePlantMaterialMesh matTran in matTrans) {
			matTran.whichMats = 3;
			matTran.mix = 0;
			matTran.mixTarget = 0;
		}
	}
}