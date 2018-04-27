using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishmove : MonoBehaviour {

    public float speed = 1.5f;
	
	void Update () {
        Debug.Log(speed);
        transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
	}
    
}
