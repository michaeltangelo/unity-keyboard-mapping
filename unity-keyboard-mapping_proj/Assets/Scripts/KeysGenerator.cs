using UnityEngine;
using System.Collections;

public class KeysGenerator : MonoBehaviour {

	public GameObject whiteKeyPrefab;
	public GameObject blackKeyPrefab;
	public GameObject[] keyArray;
	public int numKeys;
	public float scaleVal;

	// Use this for initialization
	void Start () {
		keyArray = new GameObject[numKeys];
		for (int i = 0; i < numKeys; i++) {
			int keyInOctave = i % 12;
			if (keyInOctave == 1 || keyInOctave == 4 || keyInOctave == 6 || keyInOctave == 9 || keyInOctave == 11) {
				GameObject cube = GameObject.Instantiate(blackKeyPrefab,Vector3.zero,Quaternion.identity) as GameObject;
				cube.transform.SetParent(this.transform);
				cube.transform.localPosition = new Vector3(0, 1, 5 * scaleVal * i);
				keyArray[i] = cube;
			}
			else {
				GameObject cube = GameObject.Instantiate(whiteKeyPrefab,Vector3.zero,Quaternion.identity) as GameObject;
				cube.transform.SetParent(this.transform);
				cube.transform.localPosition = new Vector3(0, 0, 5 * scaleVal * i);
				keyArray[i] = cube;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
