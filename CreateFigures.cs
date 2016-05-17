using UnityEngine;
using System.Collections;
using Leap;


public class CreateFigures : MonoBehaviour {
	public float tiempo = 1;
	Leap.Controller controller;
	// Use this for initialization
	void Start () {
		controller = new Controller();
		controller.EnableGesture(Gesture.GestureType.TYPECIRCLE);

		StartCoroutine ("corutina", tiempo);
	}
	IEnumerator corutina(float t)
	{
		while(true)
		{
			yield return new WaitForSeconds(tiempo);
			Frame frame = controller.Frame();
			foreach(Gesture gesture in frame.Gestures()){
				switch(gesture.Type)
				{
				case(Gesture.GestureType.TYPECIRCLE):
				{
					Debug.Log("Circle gesture recognized.");
					GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
					sphere.transform.position = new Vector3(-286, 70, -600);
					sphere.transform.localScale += new Vector3(25, 25, 25);
					Rigidbody sphereRigid = sphere.AddComponent<Rigidbody>();
					sphereRigid.mass = 5;
					
					break;
				}
					
				default:
				{
					break;
				}
				}
			}
		}
			Debug.Log(Time.time);
		}

	// Update is called once per frame
	void Update () {

	}
}
