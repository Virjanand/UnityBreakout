using UnityEngine;
using System.Collections;

public class DeadZone : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider col){

		GM.instance.LoseLife ();
	}
}
