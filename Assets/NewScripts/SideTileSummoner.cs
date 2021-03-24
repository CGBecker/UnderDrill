using UnityEngine;
using System.Collections;

public class SideTileSummoner : MonoBehaviour {




	private float PositionXRight;
	private float PositionXLeft;

	private int SideCounter;

	public GameObject LandTileGrass;


	void Awake(){


	}

	void Update () {



		SideCounter++;


		if (SideCounter < 30) {

			PositionXRight += 0.625F;
			PositionXLeft -= 0.625F;

			Instantiate (LandTileGrass, new Vector3 (PositionXRight, 0, 0), Quaternion.identity);
			Instantiate (LandTileGrass, new Vector3 (PositionXLeft, 0, 0), Quaternion.identity);



		}
	
	}
}
