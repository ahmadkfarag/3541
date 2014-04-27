using UnityEngine;
using System.Collections;

public class LightningScript : MonoBehaviour {
	public GameObject explosion;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

	}

	void OnTriggerEnter(Collider other) {
		
		if(other.gameObject.tag == "Enemy")
		{
			Destroy(other.gameObject);
			Vector3 position = other.transform.position;
			GameObject explosionobject = (GameObject)Instantiate(explosion, position, Quaternion.identity);
			Destroy(explosionobject,2);
		}
	}
}
