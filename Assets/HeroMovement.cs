using UnityEngine;
using System.Collections;

public class HeroMovement : MonoBehaviour {
	
	public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
	public RotationAxes axes = RotationAxes.MouseXAndY;
	public float sensitivityX = 5F;
	public float sensitivityY = 5F;
	
	public float minimumX = -360F;
	public float maximumX = 360F;
	
	public float minimumY = -60F;
	public float maximumY = 60F;
	
	float rotationY = 0F;
	
	public int force;


	
	void Update ()
	{

	

		if (axes == RotationAxes.MouseXAndY)
		{
			float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;
			rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
			rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);
			transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
		}


		if (Input.GetKey ("d") & Input.GetKey ("left shift") & force > 0)
		{
			force--;
			transform.Translate (new Vector3 (1f, 0, 0));
		}
		else if(Input.GetKey("a")& Input.GetKey("left shift") & force > 0)
		{
			force--;
			transform.Translate (new Vector3 (-1f, 0, 0));
		}
		else if(Input.GetKey("w")& Input.GetKey("left shift")& force > 0)
		{
			force--;
			transform.Translate (new Vector3 (0, 0, 1f));
		}
		else if(Input.GetKey("s")& Input.GetKey("left shift")& force > 0)
		{
			force--;
			transform.Translate (new Vector3 (0, 0, -1f));
		}
		else if (!Input.GetKey("left shift") & force <200)
		{
			force++;
		}

		if (Input.GetKey ("d"))
			transform.Translate (new Vector3 (.5f, 0, 0));
			if(Input.GetKey("a"))
			transform.Translate (new Vector3 (-.5f, 0, 0));
		if(Input.GetKey("w"))
			transform.Translate (new Vector3 (0, 0, .5f));
		if(Input.GetKey("s"))
			transform.Translate (new Vector3 (0, 0, -.5f));

		transform.position = new Vector3 (transform.position.x, 0, transform.position.z);

		//Matrix4x4 matrix = Matrix4x4.TRS (new Vector3 (0, 0, 0), Quaternion.Euler (0, rotationY, 0), new Vector3 (1, 1, 1));
		//newPosition = matrix.MultiplyVector (newPosition);

		//transform.position += newPosition;


	}
	
	void Start(){

		force = 200;


	}

	void OnGUI()
	{
		string forcepower = "Force Power: " + force.ToString (); 
		GUI.Box (new Rect (0,Screen.height - 50,200,50), forcepower);
	}

}
