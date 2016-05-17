using UnityEngine;
using System.Collections;

public class color_collider : MonoBehaviour {
	public Renderer rend;
	public int contador = 0;
	void OnCollisionEnter(Collision collision){
		if (contador == 0) {
			this.rend.material.color = Color.blue;
			contador++;
		}else if (contador == 1) {
			this.rend.material.color = Color.red;
			contador++;
		}else if (contador == 2) {
			this.rend.material.color = Color.green;
			contador++;
		}else if (contador == 3) {
			this.rend.material.color = Color.yellow;
			contador = 0;
		}
	}
}
