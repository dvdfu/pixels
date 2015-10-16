using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Cluster : MonoBehaviour {

	public List<Block> allBlocks;
	public Block firstBlock;
	private Stage stageScript;


	void Start () {
		stageScript = gameObject.GetComponent<Stage> ();
		if(allBlocks == null){
			//allBlocks = new List<Block>();
		}

		//Debug.Log("weeeeeeeee");

	}

	public void initializeBlock(Stage script){
		firstBlock = Instantiate (script.block);
		firstBlock.transform.parent = gameObject.transform;
		firstBlock.transform.localPosition = script.CoordToPos(3,3);
		firstBlock.transform.localScale = new Vector3(script.cellSize, script.cellSize, 1);
		allBlocks = new List<Block>();
		allBlocks.Add(firstBlock);

	}

	void End (){
	}

	void Update (){

	}

	public void checkCollissions(List<Block> blocks){

	}

	public void checkCollission(Block b){
		/*
		List<Block> newBlocks = new List<Block>();
		foreach(Block clusterBlock in allBlocks){
			// If collide from top.
			Vector3 position = b.gameObject.transform.parent.position;
			if(b.direction == Block.Direction.Down){
				Debug.Log(stageScript.cellSize);
				//Debug.Log("Block : position);
				//Debug.Log
				Debug.Log(position.y - clusterBlock.gameObject.transform.position.y);
			}
			if(b.direction == Block.Direction.Down && (position.y - clusterBlock.gameObject.transform.position.y - 1 <= stageScript.cellSize)){
				Debug.Log("YAAAAAAY");
				b.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
				//newBlocks.Add(b);
			}

			// If collide from bottom.
		}

		//allBlocks.AddRange(newBlocks);
		*/
	}

	public void MoveBlocks(Vector3 newPosition){
		foreach(Block b in allBlocks){
			b.transform.position = newPosition;
		}
	}

	public void removeBlock(Block b){

	
	}
		 

}