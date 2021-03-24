using UnityEngine;
using System.Collections;

public class TileSummoner : MonoBehaviour {



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


	void Update () {

		DownCounter++;

		if (DownCounter < 300) {

			randomizer = Random.Range (0, 100);
			PositionY -= 0.625F;


			if (randomizer < 60) {
				Instantiate(LandTileNormal, new Vector3(transform.position.x, PositionY, 0), Quaternion.identity);
			}
			if (randomizer < 80 && randomizer >= 60) {
				Instantiate(LandTileIron, new Vector3(transform.position.x, PositionY, 0), Quaternion.identity);
			}
			if (randomizer < 90 && randomizer >= 80) {
				Instantiate(LandTileBronze, new Vector3(transform.position.x, PositionY, 0), Quaternion.identity);
			}
			if (randomizer < 95 && randomizer >= 90) {
				Instantiate(LandTileSilver, new Vector3(transform.position.x, PositionY, 0), Quaternion.identity);
			}
			if (randomizer < 95 && randomizer >= 90) {
				Instantiate(LandTileGold, new Vector3(transform.position.x, PositionY, 0), Quaternion.identity);
			}
			if (randomizer < 97 && randomizer >= 95) {
				Instantiate(LandTileEmerald, new Vector3(transform.position.x, PositionY, 0), Quaternion.identity);
			}
			if (randomizer < 98 && randomizer >= 97) {
				Instantiate(LandTileRuby, new Vector3(transform.position.x, PositionY, 0), Quaternion.identity);
			}
			if (randomizer < 99 && randomizer >= 98) {
				Instantiate(LandTileDiamond, new Vector3(transform.position.x, PositionY, 0), Quaternion.identity);
			}
			if (randomizer <= 100 && randomizer >= 99) {
				Instantiate(LandTileOpal, new Vector3(transform.position.x, PositionY, 0), Quaternion.identity);
			}		
		}	
	}
}
