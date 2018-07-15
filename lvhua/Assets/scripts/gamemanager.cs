using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour {
    //int stage = 2;
    public GameObject seed1;
    public GameObject seed2;
    public GameObject seed3;
    public Vector3 bornpos;
    GameObject seed_zhong ;

	// Use this for initialization
	void Start () {
        bornpos = this.transform.position;
        seed_zhong = seed1;
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            seed_zhong = seed1;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            seed_zhong = seed2;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            seed_zhong = seed3;
        }

        zhongtmd(seed_zhong);


    }
   void zhongtmd(GameObject seed)
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(seed_zhong, bornpos, Quaternion.Euler(Vector3.zero));
        }
    }
    

}
