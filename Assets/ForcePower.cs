using UnityEngine;
using System.Collections;

public class ForcePower : MonoBehaviour {

	public GameObject Spark;
	public HeroMovement movescript; 
	public GameObject Hero;
	public float distance = 40;
	// Use this for initialization
	void Start () {
		movescript = (HeroMovement)FindObjectOfType (typeof(HeroMovement));
		Hero = GameObject.Find ("Hero");

	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetButton("Fire2"))
		{

			if(movescript.force >100)
			{
				Vector3 throwPos = transform.position;
				GameObject lightning = (GameObject)Instantiate(Spark, throwPos, Hero.transform.rotation);
				lightning.tag = "Lightning";
				lightning.transform.parent = transform;
				lightning.transform.localPosition = new Vector3(-8,0,0);
				Destroy(lightning,1);
				movescript.force = movescript.force - 100;
			}

		}
	
	}

	void OnGUI(){
		}
}
