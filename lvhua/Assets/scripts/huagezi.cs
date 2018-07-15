using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class huagezi : MonoBehaviour {
    public float fenqu;
    public GameObject xian;
	// Use this for initialization
	void Start () {
        
        for (int i = 0; i < fenqu / 2; i++)
        {
            Instantiate(xian, this.transform.position, Quaternion.Euler(new Vector3(0, 0, (360 / fenqu) * i)));
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
