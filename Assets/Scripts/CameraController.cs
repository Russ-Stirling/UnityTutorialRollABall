using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject Player;

    private Vector3 Offset;

	// Use this for initialization
	void Start () {
        Offset = transform.position - Player.transform.position;
	}
	
	// Late Update is called once per frame but guarenteed to run after all items in update processed so we know player moved
	void LateUpdate () {
        transform.position = Player.transform.position + Offset;
	}
}
