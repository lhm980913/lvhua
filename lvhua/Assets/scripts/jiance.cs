using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jiance : MonoBehaviour {
    GameObject[] seeds;
    public Transform planet;
    float danwei;
	// Use this for initialization
	void Start () {
        seeds = GameObject.FindGameObjectsWithTag("seed");
        danwei = 3 * Mathf.PI * (9 / 180);
    }
	
	// Update is called once per frame
	void Update () {
        seeds = GameObject.FindGameObjectsWithTag("seed");
        
        for(int i=0;i<seeds.Length;i++)
        {
            if(seeds[i].GetComponent<seed>().fall)
            {
                continue;
            }
            for(int j=i+1;j<seeds.Length;i++)
            {
                if (seeds[j].GetComponent<seed>().fall)
                {
                    continue;
                }

                Vector3 pos1 = seeds[i].GetComponentInChildren<Transform>().position - planet.position;
                Vector3 pos2 = seeds[j].GetComponentInChildren<Transform>().position - planet.position;
                float f = Mathf.PI*3*(Vector3.Angle(pos1, pos2) / 180);
                if(f<(seeds[i].GetComponent<seed>().width+ seeds[j].GetComponent<seed>().width)/2*danwei)
                {
                    if(seeds[i].GetComponent<seed>().life_time> seeds[j].GetComponent<seed>().life_time)
                    {
                        Destroy(seeds[i]);
                    }
                    else
                    {
                        Destroy(seeds[j]);
                    }
                }

                
            }
        }
    }
}
