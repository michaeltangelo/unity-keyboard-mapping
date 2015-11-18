using UnityEngine;
using System.Collections;

public class GenerateShit : MonoBehaviour {

	public GameObject bari;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 10; i++) {
			GameObject newBari = GameObject.Instantiate(bari,Vector3.zero,Quaternion.identity) as GameObject;
			//newBari.transform.SetParent(this.transform);
			newBari.transform.position = new Vector3(0,0,2*i);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
