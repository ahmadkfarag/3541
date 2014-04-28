using UnityEngine;
using System.Collections;

public class ProjectileMovement : MonoBehaviour {

	public float speed;
	public float time;

	// Use this for initialization
	void Start () {
		speed = 20.0f;
		time = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (Vector3.forward * speed * Time.deltaTime);
		time += Time.deltaTime;

		if (time > 10)
			Destroy (gameObject);
	}

	void OnCollisionEnter(Collision col)
	{

		//Can't get it to recognize when hit by the lightsaber
		Debug.Log ("COLLISION");
		if (col.gameObject.name == "saber") 
		{
			Debug.Log ("RECOGNIZED SABER");
			speed = -speed;
		} 
		else
			Destroy (gameObject);
	}
}
