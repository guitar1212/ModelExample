using UnityEngine;
using System.Collections;

public class ModelManager : MonoBehaviour {

	public GameObject initModel;

	public Transform target;

	public Transform[] models;

	private Transform currentModel;

	private int modexIdx = 0;

	// Use this for initialization
	void Start () {

		//modexIdx = 0;
		// for test
		modexIdx = 5;
		currentModel = (Transform)Instantiate(models [modexIdx]);
	}
	
	// Update is called once per frame
	void Update () {
	
		if (currentModel && target) {
			currentModel.position = target.position;

			//currentModel.rotation = target.rotation;
		}
	}

	public void NextModel()
	{
		if (currentModel) {
			Destroy(currentModel.gameObject);
			currentModel = null;
		}

		modexIdx++;

		if (modexIdx >= models.Length)
			modexIdx = 0;

		currentModel = (Transform)Instantiate(models [modexIdx]);
	}

	public void PreModel()
	{
		if (currentModel) {
			Destroy (currentModel.gameObject);
			currentModel = null;
		}
		
		modexIdx--;
		
		if (modexIdx < 0)
			modexIdx = models.Length - 1;
		
		currentModel = (Transform)Instantiate(models [modexIdx]);
	}

	public void toggleRotation()
	{
		if (currentModel) {
			AutoRotate ar = currentModel.GetComponent<AutoRotate>();
			ar.enabled = !ar.enabled;
		}
	}
}
