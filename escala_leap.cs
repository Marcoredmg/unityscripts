using UnityEngine;
using System.Collections;
using Leap;
public class escala_leap : MonoBehaviour {
	Leap.Controller controller;
	public float x = 0.01354618f;

	void Start () {
		controller = new Controller ();
		controller.EnableGesture (Gesture.GestureType.TYPECIRCLE);
		controller.EnableGesture (Gesture.GestureType.TYPESWIPE);
		controller.EnableGesture (Gesture.GestureType.TYPE_SCREEN_TAP);
		controller.EnableGesture (Gesture.GestureType.TYPE_KEY_TAP);
	}

	void Update () {

		Frame frame = controller.Frame ();
		foreach (Gesture gesture in frame.Gestures()) {
			switch(gesture.Type){
				case(Gesture.GestureType.TYPE_KEY_TAP):
				{
					this.transform.localScale = new Vector3(x,x,x);
					x = x * 1.2f;
					Debug.Log("Aumentando Tamaño");
				break;
				}
				case(Gesture.GestureType.TYPESWIPE):
				{
					this.transform.localScale = new Vector3(x,x,x);
					x = x / 1.2f;
					Debug.Log("Reduciendo tamaño");
					break;
				}
				default:
				{
					break;
				}
			}

		}
	}
}
