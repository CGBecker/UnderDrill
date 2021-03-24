using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


public static class SaveRanking {




	public static int savedRankingScore;
	public static int savedRankingStars;
	public static int savedRankingTime;

	public static float time;


	public static void SaveRankings(){

		//savedRankingScore.Add (RankingController.currentScore);
		//savedRankingStars.Add (RankingController.currentStars);

		//savedRankingScore = RankingController.currentScore;
		//savedRankingStars = RankingController.currentStars;

		BinaryFormatter bf1 = new BinaryFormatter ();
		BinaryFormatter bf2 = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/savedRanking.gd");
		bf1.Serialize (file, SaveRanking.savedRankingScore);
		bf2.Serialize (file, SaveRanking.savedRankingStars);
		file.Close ();

		Debug.Log(Application.persistentDataPath);


	}

	public static void LoadRankings(){
		
		if (File.Exists (Application.persistentDataPath + "/savedRanking.gd")) {
			BinaryFormatter bf1 = new BinaryFormatter();
			BinaryFormatter bf2 = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/savedRanking.gd", FileMode.Open);
			SaveRanking.savedRankingScore = (int)bf1.Deserialize(file);
			SaveRanking.savedRankingStars = (int)bf2.Deserialize(file);
			file.Close();
			
			//RankingController.currentScore = savedRankingScore;
			//RankingController.currentStars = savedRankingStars;

			//SaveRankings();

		}
	}
}
