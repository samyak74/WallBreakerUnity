using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	
	public float xVelocity,yVelocity;
	bool hasStarted= false;
	private Paddle paddle;
	private Vector3 paddleToBallVector;

	// Use this for initialization
	void Start () {
		//xVelocity=6f;
		//yVelocity=10f;
		paddle= GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector= this.transform.position-paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(!hasStarted)
		{
			this.transform.position=paddle.transform.position+paddleToBallVector;
		
			if(Input.GetMouseButton(0))
			{
				hasStarted=true;
				this.rigidbody2D.velocity= new Vector2(xVelocity,yVelocity);
			}
		}
	}
	
	void OnCollisionEnter2D(Collision2D collision)
	{
		
		if(hasStarted)
		{
			//print("audio and collision");
			audio.Play();
			rigidbody2D.velocity +=new Vector2(Random.Range(0f,0.5f),Random.Range(0f,0.5f));
		}
	
	}
}
