using UnityEngine;
using System.Collections;

public class CameraManage : MonoBehaviour {

	Vector3 startPos;

	// Use this for initialization
	void Start () {
		startPos = this.transform.position;
		UpdatePos ();
	}

	void UpdatePos (){
		float theta = Time.time * Mathf.PI/180*20;
		transform.position = new Vector3 (startPos.magnitude * Mathf.Cos (theta), startPos.y, startPos.magnitude * Mathf.Sin (theta));
		transform.LookAt(Vector3.zero);
	}

	// Update is called once per frame
	void Update () {
		UpdatePos ();
	}
}