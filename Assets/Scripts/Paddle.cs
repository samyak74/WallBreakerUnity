using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public bool autoPlay=false;
	public Vector3 paddleLength;
	private Ball ball;
	public float maxX,maxY;	
	
	void Start()
	{
		this.transform.localScale+=paddleLength;
		ball= GameObject.FindObjectOfType<Ball>();
		
	}
	
	void Update () 
	{
		if(!autoPlay)
		{
			MoveWithMouse();
		}
		else
		{
			AutoPlay();
		}
		
	}
	void AutoPlay()
	{
		Vector3 paddlePos= new Vector3(0.5f,this.transform.position.y,0f);
		Vector3 ballPos= ball.transform.position;
		paddlePos.x=Mathf.Clamp(ballPos.x,maxX,maxY);
		this.transform.position= paddlePos;
	}
	
	void MoveWithMouse()
	{
		Vector3 paddlePos= new Vector3(0.5f,this.transform.position.y,0f);
		float GetMousePos;
		GetMousePos= Input.mousePosition.x/Screen.width*16;
		paddlePos.x=Mathf.Clamp(GetMousePos,maxX,maxY);
		this.transform.position= paddlePos;
	}
	
	void MoveWithKeyboard()
	{
		//TODO get keyboard input
		/*if(Input.GetKey(KeyCode.RightArrow))
		{
			this.transform.position+= new Vector3(.3f,0f,0f);
			Mathf.Clamp(this.transform.position.x,0.5f,15.5f);
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			this.transform.position+=new Vector3(-.3f,0f,0f);
		}*/
		
	}
}
	