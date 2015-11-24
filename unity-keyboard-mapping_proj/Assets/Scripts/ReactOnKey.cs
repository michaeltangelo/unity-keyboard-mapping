using UnityEngine;
using System.Collections;

public class ReactOnKey : MonoBehaviour {

	// bool pressed used to indicate if key should react (changed by InputController.cs)
	public bool pressed;
	private Vector3 startPos;

	// Use this for initialization
	void Start () {
		startPos = this.transform.localPosition;
	}

	// Update is called once per frame
	void Update () {
		if (pressed == true) {
			// moves key down
			this.transform.localPosition = Vector3.MoveTowards(this.transform.localPosition, startPos + (new Vector3(0,-5f,0)), 200f * Time.deltaTime);
			// Vector3.MoveTowards(obj.transform.localPosition, obj.transform.localPosition + new Vector3(0,-5f,0), 200f * Time.deltaTime);
			// (new Vector3(0,100f,0)*Time.deltaTime);
			//Vector3.MoveTowards(
		}
		else if (this.transform.localPosition.y < 0) {
			// if key position below 0, raises key slowly
				this.transform.localPosition += (new Vector3(0,50f,0)*Time.deltaTime);
			if (this.transform.localPosition.y < 0 && this.transform.localPosition.y > -5) {
				// resets key at 0 to avoid overstepping
				this.transform.localPosition = new Vector3(startPos.x,startPos.y,startPos.z);
			}
		}
	}
}
