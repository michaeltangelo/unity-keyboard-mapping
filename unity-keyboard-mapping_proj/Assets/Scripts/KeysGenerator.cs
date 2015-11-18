using UnityEngine;
using System.Collections;

public class KeysGenerator : MonoBehaviour {

	public GameObject cubePrefab;
	public GameObject[] keyArray;
	public int numKeys;
	public float scaleVal;

	// Use this for initialization
	void Start () {
		keyArray = new GameObject[numKeys];
		for (int i = 0; i < numKeys; i++) {
			GameObject cube = GameObject.Instantiate(cubePrefab,Vector3.zero,Quaternion.identity) as GameObject;
			cube.transform.SetParent(this.transform);
			cube.transform.localPosition = new Vector3(0, 0, 5 * scaleVal * i);
			keyArray[i] = cube;
		}

	}
	
	// Update is called once per frame
	void Update () {
	}
}
