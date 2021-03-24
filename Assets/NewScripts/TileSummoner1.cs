using UnityEngine;
using System.Collections;

public class TileSummoner1 : MonoBehaviour {



	public GameObject LandTileNormal;
	public GameObject LandTileBronze;
	public GameObject LandTileSilver;
	public GameObject LandTileGold;
	public GameObject LandTileIron;
	public GameObject LandTileEmerald;
	public GameObject LandTileRuby;
	public GameObject LandTileOpal;
	public GameObject LandTileDiamond;



	private int randomizer;



	private float PositionY;

	private int DownCounter;



	private Transform Parent;




	
	

	void Awake(){
		PositionY = transform.position.y;
	
	
	}

	void Update () {



		DownCounter++;








		if (DownCounter < 10) {

			randomizer = Random.Range (0, 100);

			PositionY -= 0.625F;




			if (randomizer < 50) {
				Instantiate(LandTileNormal, new Vector3(transform.position.x, PositionY, 0), Quaternion.identity);
			}
			if (randomizer < 70 && randomizer >= 50) {
				Instantiate(LandTileIron, new Vector3(transform.position.x, PositionY, 0), Quaternion.identity);
			}
			if (randomizer < 80 && randomizer >= 70) {
				Instantiate(LandTileBronze, new Vector3(transform.position.x, PositionY, 0), Quaternion.identity);
			}
			if (randomizer < 85 && randomizer >= 80) {
				Instantiate(LandTileSilver, new Vector3(transform.position.x, PositionY, 0), Quaternion.identity);
			}
			if (randomizer < 90 && randomizer >= 85) {
				Instantiate(LandTileGold, new Vector3(transform.position.x, PositionY, 0), Quaternion.identity);
			}
			if (randomizer < 93 && randomizer >= 90) {
				Instantiate(LandTileEmerald, new Vector3(transform.position.x, PositionY, 0), Quaternion.identity);
			}
			if (randomizer < 96 && randomizer >= 93) {
				Instantiate(LandTileRuby, new Vector3(transform.position.x, PositionY, 0), Quaternion.identity);
			}
			if (randomizer < 99 && randomizer >= 96) {
				Instantiate(LandTileDiamond, new Vector3(transform.position.x, PositionY, 0), Quaternion.identity);
			}
			if (randomizer <= 100 && randomizer >= 99) {
				Instantiate(LandTileOpal, new Vector3(transform.position.x, PositionY, 0), Quaternion.identity);
			}
		


		
		}
	
	}
}
