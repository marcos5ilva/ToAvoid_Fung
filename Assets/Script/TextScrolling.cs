using UnityEngine;
using System.Collections;

public class TextScrolling : MonoBehaviour {

	public float speed = 0.1f;
	public float startY = -450.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector3 offset = new Vector3 (0f, startY +(Time.time * speed), 0f);
		GetComponent<RectTransform>().localPosition = offset;
	}
}
