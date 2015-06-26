using UnityEngine;
using System.Collections;

public class AutoRotate : MonoBehaviour {

	public float rotateSpeed = 1.0f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate (new Vector3 (0, 1, 0), rotateSpeed);
	}
}
