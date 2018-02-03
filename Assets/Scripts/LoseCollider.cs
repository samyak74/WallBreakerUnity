using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	private LevelManager levelManager;

	void OnCollisionEnter2D (Collision2D collision)
	{
		
		Debug.Log("Collision");
		levelManager.LoadLevel("Win Screen");
	}
	void OnTriggerEnter2D (Collider2D collider)
	{
		Debug.Log("Trigger");
		levelManager.LoadLevel("Lose Screen");	
	}
	

	// Use this for initialization
	void Start () {
		levelManager= GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
