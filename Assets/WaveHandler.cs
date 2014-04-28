using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WaveHandler : MonoBehaviour {

	public  int NumberEnemies;
	public static int WaveNumber = 0;
	public GameObject BallDroid;

	void Update(){
		
		NumberEnemies = ((GameObject.FindGameObjectsWithTag("Enemy").Length));
		
		if(NumberEnemies <= 0){
			NumberEnemies = 0;
		}
		
		if(NumberEnemies == 0){
			WaveNumber += 1;
			SpawnEnemies();
		}

	}

	void Start(){
		WaveNumber = 1;
		SpawnEnemies ();

		}
	
	void SpawnEnemies(){
		
		for (int i = 0; i < WaveNumber; i++) {
			Vector3 position = new Vector3(UnityEngine.Random.Range(100, 30), 0, UnityEngine.Random.Range(100, -200));
			GameObject enemy = (GameObject)Instantiate(BallDroid, position, Quaternion.identity);
			enemy.tag = "Enemy";
			BoxCollider enemycollider = enemy.AddComponent<BoxCollider>();
			enemycollider.size = new Vector3(2,2,2);
			enemycollider.isTrigger = true;
			Rigidbody rigidbody = enemy.AddComponent<Rigidbody>();
			rigidbody.mass = 1;
			rigidbody.useGravity = false;
			enemy.AddComponent("DontGoThroughThings");
			enemy.AddComponent("DeleteChildren");
			enemy.AddComponent("EnemyMovement");
			enemy.AddComponent ("EnemyProjectileLauncher");
		}

		//clone = Instantiate(heart, position, Quaternion.identity);
		
	}

	void OnGUI()
	{
		string numberofenemies = "Enemies Remaining: " + NumberEnemies.ToString (); 
		string wave = "Wave: " + WaveNumber.ToString ();
		GUI.Box (new Rect (0,0,200,20), wave);
		GUI.Box (new Rect (0,20,200,25), numberofenemies);
	}
	

}
