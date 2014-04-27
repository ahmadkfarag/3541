using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class DeleteChildren : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Transform plane = transform.FindChild ("Plane");
		Destroy (plane.gameObject);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
