using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using MidiJack;

// sets boolean 'pressed' according to the input received -> (determined by InputMap class)

public class InputController : MonoBehaviour {

	private GameObject keyObj;
	private Dictionary<int,int> map; // must change to int,int for pianokeyboardmap or str,int for computerkeyboard - WIP

	// Use this for initialization
	void Start () {
		//map = gameObject.GetComponent<InputMap>().initializeComputerKeyboardMap();
		map = gameObject.GetComponent<InputMap>().initializePianoKeyboardMap();
	}

//	void computerKeyboard() {
//		foreach (KeyValuePair<string, int> entry in map) {
//			// if key in inputmap is pressed, change associated key flag to True
//			if (Input.GetKeyDown(entry.Key)) {
//				// sets keyObj to the respective index object in keyArray
//				keyObj = gameObject.GetComponent<KeysGenerator>().keyArray[entry.Value-1];
//				
//				// sets the respective instance property 'pressed' to true
//				keyObj.GetComponent<ReactOnKey>().pressed = true;
//			}
//			
//			else if (Input.GetKeyUp(entry.Key)) {
//				// sets keyObj to respective index object in keyArray
//				keyObj = gameObject.GetComponent<KeysGenerator>().keyArray[entry.Value-1];
//				
//				// sets respective instance property 'pressed' to false
//				keyObj.GetComponent<ReactOnKey>().pressed = false;
//			}
//		}
//	}

	// Sets 'pressed' to true if key is pressed down -> false when released
	void pianoKeyboard() {
		foreach (KeyValuePair<int,int> entry in map) {
			if (MidiMaster.GetKeyDown(entry.Key)) {
				gameObject.GetComponent<KeysGenerator>().keyArray[entry.Value-1].GetComponent<ReactOnKey>().pressed = true;
			}

			else if (MidiMaster.GetKeyUp(entry.Key)) {
				gameObject.GetComponent<KeysGenerator>().keyArray[entry.Value-1].GetComponent<ReactOnKey>().pressed = false;
			}
		}
	}

	// Update is called once per frame
	void Update () {
		//computerKeyboard();
		pianoKeyboard();
	}
}