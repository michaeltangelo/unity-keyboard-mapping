using UnityEngine;
using System.Collections;

public class KeyGenerate : MonoBehaviour {

	// GO prefabs
	public GameObject whitePrefab;
	public GameObject blackPrefab;

	public float scale;
	public float offset;

	// visible for debugging
	public GameObject[] keyArray;

	// Use this for initialization
	void Start () {
		print("Working");
		keyArray = new GameObject[88];

		// generate all keys


		// generate white keys
		for (int i = 0; i < 52; i++) {
			int skip =0;
			float initOffset = .1175f;

			GameObject cube = GameObject.Instantiate(whitePrefab, Vector3.zero, Quaternion.identity) as GameObject;
			cube.transform.SetParent(this.transform);
			cube.transform.localPosition = new Vector3(0, 1, offset * i);
			keyArray[i] = cube;

			switch (i%7) {
			case 0:
				skip = 0;
				break;
			case 1:
				
				break;
			case 2:
				cube = GameObject.Instantiate(blackPrefab, Vector3.zero, Quaternion.identity) as GameObject;
				cube.transform.SetParent(this.transform);
				cube.transform.localPosition = new Vector3(0, 1.25f, (initOffset + (offset * i)));
				break;
			case 3:
				skip = 1;
				initOffset += offset;
				break;
			case 4:
				skip = 0;
				break;
			case 5:
				skip = 0;
				break;
			case 6:
				cube = GameObject.Instantiate(blackPrefab, Vector3.zero, Quaternion.identity) as GameObject;
				cube.transform.SetParent(this.transform);
				cube.transform.localPosition = new Vector3(0, 1.25f, (initOffset + (offset * i)));
				break;
			}

		}

//		for (int i = 0; i < 36; i++) {
//			GameObject cube = GameObject.Instantiate(blackPrefab, Vector3.zero, Quaternion.identity) as GameObject;
//			cube.transform.SetParent(this.transform);
//			float initOffset = .1175f;
//			float skipOffset = offset;
//			int skip = 0;
//			switch (i%5) {
//			case 0:
//				skip = 0;
//				break;
//			case 1:
//				skip = 1;
//				initOffset += offset;
//				break;
//			case 2:
//				skip = 0;
//				break;
//			case 3:
//				skip = 1;
//				initOffset += offset;
//				break;
//			case 4:
//				skip = 0;
//				break;
//			}
//			cube.transform.localPosition = new Vector3(0, 1.25f, (initOffset + (offset * i)) + (skip*offset));
//			keyArray[i+52] = cube;
//		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
