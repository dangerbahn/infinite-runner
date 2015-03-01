using UnityEngine;
using System.Collections;

public class gauge : MonoBehaviour {

  public float gaugeValue = 10;
	// Use this for initialization, or dont!
	void Start () {
	 
	}
	
	// Update is called once per frame
	void Update () {
	   gaugeValue -= 0.025f;
     Debug.Log(gaugeValue);
	}
}
