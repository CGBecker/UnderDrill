using UnityEngine;
using System.Collections;

public class SideTileSummoner1 : MonoBehaviour {


	public GameObject SummonerTileNormal;
	public GameObject SummonerTileBronze;
	public GameObject SummonerTileSilver;
	public GameObject SummonerTileGold;
	public GameObject SummonerTileIron;
	public GameObject SummonerTileEmerald;
	public GameObject SummonerTileRuby;
	public GameObject SummonerTileOpal;
	public GameObject SummonerTileDiamond;


	private float PositionXRight;
	private float PositionXLeft;
	private float PositionY;
	private int randomizer;

	private int SideCounter;




	void Awake(){

		PositionY = transform.position.y;
	}

	void Update () {





		SideCounter++;




		if (SideCounter < 30) {

			PositionXRight += 0.625F;
			PositionXLeft -= 0.625F;
			randomizer = Random.Range (0, 100);

		
			if (randomizer < 50) {
				Instantiate (SummonerTileNormal, new Vector3 (PositionXRight, PositionY, 0), Quaternion.identity);
				Instantiate (SummonerTileNormal, new Vector3 (PositionXLeft, PositionY, 0), Quaternion.identity);
			}
			if (randomizer < 70 && randomizer >= 50) {
				Instantiate (SummonerTileIron, new Vector3 (PositionXRight, PositionY, 0), Quaternion.identity);
				Instantiate (SummonerTileIron, new Vector3 (PositionXLeft, PositionY, 0), Quaternion.identity);
			}
			if (randomizer < 80 && randomizer >= 70) {
				Instantiate (SummonerTileBronze, new Vector3 (PositionXRight, PositionY, 0), Quaternion.identity);
				Instantiate (SummonerTileBronze, new Vector3 (PositionXLeft, PositionY, 0), Quaternion.identity);
			}
			if (randomizer < 85 && randomizer >= 80) {
				Instantiate (SummonerTileSilver, new Vector3 (PositionXRight, PositionY, 0), Quaternion.identity);
				Instantiate (SummonerTileSilver, new Vector3 (PositionXLeft, PositionY, 0), Quaternion.identity);
			}
			if (randomizer < 90 && randomizer >= 85) {
				Instantiate (SummonerTileGold, new Vector3 (PositionXRight, PositionY, 0), Quaternion.identity);
				Instantiate (SummonerTileGold, new Vector3 (PositionXLeft, PositionY, 0), Quaternion.identity);
			}
			if (randomizer < 93 && randomizer >= 90) {
				Instantiate (SummonerTileEmerald, new Vector3 (PositionXRight, PositionY, 0), Quaternion.identity);
				Instantiate (SummonerTileEmerald, new Vector3 (PositionXLeft, PositionY, 0), Quaternion.identity);
			}
			if (randomizer < 96 && randomizer >= 93) {
				Instantiate (SummonerTileRuby, new Vector3 (PositionXRight, PositionY, 0), Quaternion.identity);
				Instantiate (SummonerTileRuby, new Vector3 (PositionXLeft, PositionY, 0), Quaternion.identity);
			}
			if (randomizer < 99 && randomizer >= 96) {
				Instantiate (SummonerTileDiamond, new Vector3 (PositionXRight, PositionY, 0), Quaternion.identity);
				Instantiate (SummonerTileDiamond, new Vector3 (PositionXLeft, PositionY, 0), Quaternion.identity);
			}
			if (randomizer <= 100 && randomizer >= 99) {
				Instantiate (SummonerTileOpal, new Vector3 (PositionXRight, PositionY, 0), Quaternion.identity);
				Instantiate (SummonerTileOpal, new Vector3 (PositionXLeft, PositionY, 0), Quaternion.identity);
			}

		}
	
	}
}
