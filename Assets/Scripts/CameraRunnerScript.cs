using UnityEngine;
using System.Collections;

public class CameraRunnerScript : MonoBehaviour {

  public Transform player;
  private float verticalTracking;

	void Update () {
    if(player.position.y < 3){
      verticalTracking = 0;
    }
    else{
      verticalTracking = (player.position.y - 3);
    }
	 transform.position = new Vector3(player.position.x + 2, verticalTracking, -10);
	}
}
