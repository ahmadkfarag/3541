using UnityEngine;
using System.Collections;

public class Saber : MonoBehaviour {

	protected Animator animator;
	public AudioSource[] sounds;
	public AudioSource idle;
	public AudioSource swing;
	public AudioSource swing2;
	public GameObject explosion;
	// Use this for initialization
	void Start () {

		sounds = GetComponents<AudioSource> ();
		idle = sounds [0];
		swing = sounds [1];
		swing2 = sounds [2];
		idle.Play();


	}
	
	// Update is called once per frame
	void Update () {
		animator = GetComponent<Animator>();
		animator.ResetTrigger ("Swing");
		int randomSwing = Random.Range (0, 1);


		if(Input.GetButton("Fire1"))
		{
			animator.SetTrigger("Swing");
			swing.Play();
		}

		

	
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


