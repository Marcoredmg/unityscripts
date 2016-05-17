using UnityEngine;
using System.Collections;

public class gravedadXZ : MonoBehaviour {


	void Start () {

	
		int z = Random.Range (-15, -10);
		float y = Random.Range (-0.05F, 0.05F);
		Physics.gravity = new Vector3 (1, y, z);
	}
	

	void Update () {
	
	}
}
