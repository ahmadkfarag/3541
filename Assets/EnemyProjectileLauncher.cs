using UnityEngine;
using System.Collections;

public class EnemyProjectileLauncher : MonoBehaviour {

	public float time;
	// Use this for initialization
	void Start () {
		time = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if(time > 3)
		{
			Instantiate(Resources.Load ("Bullet"), transform.position + Vector3.forward, transform.rotation);
			time = 0.0f;
		}
	}
}