using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeScorer : MonoBehaviour {
	public GameObject scorer;
	public GameObject[] scorers;
	public int n;
	// Use this for initialization
	void Start () {
		n = 5;
		scorers = new GameObject[n];
		for(int i = 0; i < n; i++){
			scorers[i] = (GameObject)Instantiate(scorer, transform.position, transform.rotation);
			scorers[i].transform.localPosition = new Vector3(0,transform.position.y+(20 * i),0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
