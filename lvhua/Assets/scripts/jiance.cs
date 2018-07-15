using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jiance : MonoBehaviour {
    //GameObject[] seeds;
    public Transform planet;
    float danwei;
    public List<GameObject> seeds= new List<GameObject>();

    // Use this for initialization
    private void Awake()
    {
       //seeds.Clear();
    }

    void Start () {

      
        //seeds.Clear();


        danwei = 3 * Mathf.PI * (9 / 180);

    }
 
    // Update is called once per frame
    void Update() {



        for (int i = 0; i < seeds.Count; i++) 
        {

            for (int j = i + 1; j < seeds.Count; j++)
            {

                float f = Vector3.Angle(seeds[i].GetComponent<seed>().xiangliang, seeds[j].GetComponent<seed>().xiangliang);
                

                if (f < (seeds[i].GetComponent<seed>().width + seeds[j].GetComponent<seed>().width)*9 / 2)
                {
                    
                    if (seeds[i].GetComponent<seed>().life_time > seeds[j].GetComponent<seed>().life_time)
                    {

                        Destroy(seeds[i]);
                        seeds.RemoveAt(i);
                    }
                    else
                    {
                        Destroy(seeds[j]);
                        seeds.RemoveAt(j);

                    }
                }


            }
        }
    }
}
