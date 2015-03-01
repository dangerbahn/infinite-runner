using UnityEngine;
using System.Collections;

public class PowerupScript : MonoBehaviour {

  HUDScript hud;

  void Start(){
    hud = Camera.main.GetComponent<HUDScript>();
  }
  void OnTriggerEnter2D(Collider2D other){
    if(other.tag == "Player"){
      hud.IncreaseScore(10);
      hud.IncreaseGauge(2);
      Destroy(this.gameObject);
    }
  }
}
