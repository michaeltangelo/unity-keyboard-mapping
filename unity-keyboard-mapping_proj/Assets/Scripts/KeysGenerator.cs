using UnityEngine;
using System.Collections;

public class KeysGenerator : MonoBehaviour {

	// GO Prefabs
	public GameObject whiteKeyPrefab;
	public GameObject blackKeyPrefab;

	// visible for debugging purposes	
	public GameObject[] keyArray;

	// alters # of keys to be generated (KeysGenerator should be set to 88)
	public int numKeys;

	// offset value controlling the distance between each key instance (0.25 works)
	public float offset;

	// Use this for initialization
	void Start () {
		keyArray = new GameObject[numKeys];
		for (int i = 0; i < numKeys; i++) {
			int keyInOctave = i % 12;
			// creates black keys
			if (keyInOctave == 1 || keyInOctave == 4 || keyInOctave == 6 || keyInOctave == 9 || keyInOctave == 11) {
				GameObject cube = GameObject.Instantiate(blackKeyPrefab,Vector3.zero,Quaternion.identity) as GameObject;
				cube.transform.SetParent(this.transform);
				cube.transform.localPosition = new Vector3(0, 1, 5 * offset * i);
				keyArray[i] = cube; // adding object instance to keyArray
			}
			// creates white keys
			else {
				GameObject cube = GameObject.Instantiate(whiteKeyPrefab,Vector3.zero,Quaternion.identity) as GameObject;
				cube.transform.SetParent(this.transform);
				cube.transform.localPosition = new Vector3(0, 0, 5 * offset * i);
				keyArray[i] = cube; // adding object instance to keyArray
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
