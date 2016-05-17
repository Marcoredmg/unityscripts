using UnityEngine;
using System.Collections;
using Leap;

public class GravityH : MonoBehaviour {
	Leap.Controller controller;
	
	void Start () {
		
		controller = new Controller ();
		controller.EnableGesture (Gesture.GestureType.TYPECIRCLE);
		controller.EnableGesture (Gesture.GestureType.TYPESWIPE);
		controller.EnableGesture (Gesture.GestureType.TYPE_SCREEN_TAP);
		controller.EnableGesture (Gesture.GestureType.TYPE_KEY_TAP);
	}

	void Update () {
		Frame frame = controller.Frame ();
		foreach(Gesture gesture in frame.Gestures()){
			switch (gesture.Type) {
			case(Gesture.GestureType.TYPE_KEY_TAP):
				{
					Physics.gravity = new Vector3 (0, 0.05F, 0);
					break;
				}
			case(Gesture.GestureType.TYPESWIPE):
				{
					Physics.gravity = new Vector3 (0, -9.81F, 0);
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