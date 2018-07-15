using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ro : MonoBehaviour {
    public float rospeed;
    public GameObject xian;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(new Vector3(0, 0, Time.deltaTime *rospeed));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            xian.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            xian.gameObject.SetActive(false);

        }


    }
}
