using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using MidiJack;

// maps arbitrary input to standardized numbers 1-88
// Intended for processing MIDI input data for an 88 key piano
// MIDI Input ranges from [21,108]

public class InputMap : MonoBehaviour {
	public int numKeys;
	public Dictionary<int,int> map;

//	public Dictionary<string,int> initializeComputerKeyboardMap() {
//		map = new Dictionary<string, int>();
//		map.Add("a",1);
//		map.Add("s",2);
//		map.Add("d",3);
//		map.Add("f",4);
//		map.Add("g",5);
//		map.Add("h",6);
//		map.Add("j",7);
//		map.Add("k",8);
//		map.Add("l",9);
//		return map;
//	}

	public Dictionary<int,int> initializePianoKeyboardMap() {
		map = new Dictionary<int,int>();
		for (int i = 0; i < 88; i++) {
			map.Add(i+21,i+1);
		}
		return map;
	}

	// Use this for initialization
	void Start () {

		// references the numKey's property in KeysGenerator script
		numKeys = gameObject.GetComponent<KeysGenerator>().numKeys;
	}
	
	// Update is called once per frame
	void Update () {
		//if (MidiMaster.GetKey()>0) print(MidiMaster.GetKeyDown
	}
}
		                               