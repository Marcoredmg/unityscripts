using UnityEngine;
using System.Collections;
[RequireComponent(typeof(gravedadXZ))]
[RequireComponent (typeof (Rigidbody))]
public class generar_balones : MonoBehaviour {
	public GameObject asteroide;
	public float time = 0.01f;

	void Start () {
		StartCoroutine ("corutina", time);
	}
	IEnumerator corutina(float t)
	{
		while(true)
		{
			yield return new WaitForSeconds(time);
			float x = Random.Range (0.5F, 4);
			GameObject asteroide = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			asteroide.tag = "asteroide";
			asteroide.transform.position = new Vector3(417.8F, 16.1F, 10.7F);
			asteroide.transform.localScale = new Vector3 (x, x, x);
			asteroide.AddComponent<Rigidbody>();				
			asteroide.AddComponent<gravedadXZ>();


			Debug.Log(Time.time);
		}
	}
	void Update () {

	}
	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.CompareTag("Untagged")) {
			asteroide.GetComponent<Rigidbody>().AddForce(0,-10000,0);
			asteroide.GetComponent<Rigidbody>().useGravity = true;
			asteroide.AddComponent<Rigidbody>().mass = .5f;	
		}
	}
}

