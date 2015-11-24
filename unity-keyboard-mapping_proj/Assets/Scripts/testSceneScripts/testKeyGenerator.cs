using UnityEngine;
using System.Collections;

public class testKeyGenerator : MonoBehaviour {

	// black keys aren't used in testing scene
	// use whiteKeyPrefab for the GameObject you would like to generate
	public GameObject whiteKeyPrefab;
	//public GameObject blackKeyPrefab;
	public GameObject[] keyArray;
	public int numKeys; // should be set to 9 in TestScene (asdfghjkl)
	public float scaleVal;

	// Use this for initialization
	void Start () {
		keyArray = new GameObject[numKeys];
		for (int i = 0; i < numKeys; i++) {
//			int keyInOctave = i % 12;
//			if (keyInOctave == 1 || keyInOctave == 4 || keyInOctave == 6 || keyInOctave == 9 || keyInOctave == 11) {
//				GameObject cube = GameObject.Instantiate(blackKeyPrefab,Vector3.zero,Quaternion.identity) as GameObject;
//				cube.transform.SetParent(this.transform);
//				cube.transform.localPosition = new Vector3(0, 1, 5 * scaleVal * i);
//				keyArray[i] = cube;
//			}
			GameObject cube = GameObject.Instantiate(whiteKeyPrefab,Vector3.zero,Quaternion.identity) as GameObject;
			cube.transform.SetParent(this.transform);
			cube.transform.localPosition = new Vector3(0, 0, 5 * scaleVal * i);
			keyArray[i] = cube;
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
