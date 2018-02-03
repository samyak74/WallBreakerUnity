using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	public AudioClip crack;
	public static int breakableCount=0; 
	public Sprite[] hitSprites;
	private int timesHit;
	private LevelManager lm;
	bool isBreakable;
	

	// Use this for initialization
	void Start () {
		timesHit=0;	
		isBreakable= (this.tag=="Breakable");
		if(isBreakable)
		{
			breakableCount++;
			
		}
		lm= GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter2D (Collision2D col)
	{
		
		AudioSource.PlayClipAtPoint(crack,transform.position,0.4f);
		
		if(isBreakable)
		{
			HandleHits();
		}
		
		
		//SimulateWin();
	}
	
	public void HandleHits(){
		timesHit++;
		int maxHits= hitSprites.Length+1;
		
		if(timesHit >= maxHits)
		{
			breakableCount--;
			
			Destroy(gameObject);
			if(breakableCount<=0)
			{
				lm.LoadNextLevel();
			}	
		}
		else
		{
			LoadSprites();
		}
	}
	

	
	void LoadSprites()
	{
		int spriteIndex= timesHit-1;
		this.GetComponent<SpriteRenderer>().sprite =hitSprites[spriteIndex];
	}
	
	
}
