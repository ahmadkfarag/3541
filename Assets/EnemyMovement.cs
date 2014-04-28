using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	
	public float speed = 5.0f;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance (Camera.main.transform.position, this.gameObject.transform.position);
		transform.LookAt (Camera.main.transform);

		//move enemy closer to hero
		if (distance > 10) 
			transform.Translate (Vector3.forward * speed * Time.deltaTime);
	}
}