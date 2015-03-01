using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {

  float gauge = 10;
  float playerScore = 0;
	
	// Update is called once per frame
	void Update () {
	 playerScore += Time.deltaTime;
   gauge -= 0.025f;
   if(gauge <= 0)
    {
      Application.LoadLevel(1);
      return;
    }
	}

  public void IncreaseScore(int amount){
    playerScore += amount;
  }

  public void IncreaseGauge(int amount){
    gauge += 20f;
  }

  void OnDisable(){
    PlayerPrefs.SetInt("Score", (int)playerScore * 100);
  }

  void OnGUI(){
    GUI.Label(new Rect(10, 10, 100, 30), "Score: " + (int)(playerScore * 100));

    GUI.Label(new Rect(100, 100, 100, 30), "GAUGE: " + (int)(gauge * 100));
  }
}
