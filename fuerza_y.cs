using UnityEngine;
using System.Collections;

public class fuerza_y : MonoBehaviour {
	public GameObject cubo;

	void Start(){
		cubo = GameObject.Find ("Cube 2");

	}
	void OnCollisionEnter(Collision collision){
		cubo.GetComponent<Rigidbody> ().AddForce (0, 500, 0);
	}
}
