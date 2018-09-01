using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour {
    public GameObject GameCamera;
    public GameObject Player;
    public Vector3 offset = new Vector3(0f, 5f, 15f);
	// Use this for initialization
	void Start () {
        offset = new Vector3(0f, 5f, -25f);
        }
	
	// Update is called once per frame
	void Update () {
        GameCamera.transform.position = Player.transform.position+offset;
        

        }
}
