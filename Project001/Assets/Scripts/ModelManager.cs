using UnityEngine;
using System.Collections;

public class ModelManager : MonoBehaviour {

	public Transform currentModel;

	public Transform target;

	public Transform[] models;

	private int modexIdx = 0;

	// Use this for initialization
	void Start () {

		modexIdx = 0;

		if (currentModel && target) {

		}
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

		currentModel = Instantiate (models [modexIdx]);
	}
}
