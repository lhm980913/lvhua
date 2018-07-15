using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class gamemanager : MonoBehaviour {
    //int stage = 2;
    public GameObject seed1;
    public GameObject seed2;
    public GameObject seed3;
    public Vector3 bornpos;
    GameObject seed_zhong ;
    public float score;
    public float play_time;
    public Text text;
    public GameObject text2;

    public GameObject sssssss;

    public Text text1;
    public GameObject gamemanager1;
    public jiance jiance1;

    public Sprite s1;
    public Sprite s2;
    public Sprite s3;


    // Use this for initialization
    void Start () {
        bornpos = this.transform.position;
        seed_zhong = seed1;
        gamemanager1 = GameObject.Find("gamemanager");
        jiance1 = gamemanager1.GetComponent<jiance>();


    }

    // Update is called once per frame
    void Update()
    {
        play_time -= Time.deltaTime;
        if(play_time<0)
        {
            Time.timeScale = 0;
            text2.SetActive(true);

        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            seed_zhong = seed1;
            sssssss.GetComponent<SpriteRenderer>().sprite = s1;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            seed_zhong = seed2;
            sssssss.GetComponent<SpriteRenderer>().sprite = s2;

        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            seed_zhong = seed3;
            sssssss.GetComponent<SpriteRenderer>().sprite = s3;

        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("main");
        }
        score = 0;
        for (int i=0;i<jiance1.seeds.Count;i++)
        {
            
            score += jiance1.seeds[i].GetComponent<seed>().width;
        }

        zhongtmd(seed_zhong);
        string str = "Time:";
        text.text = str + (int)play_time;
        string str1 = "Score:";
        text1.text = str1 + (int)score;

    }
   void zhongtmd(GameObject seed)
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(seed_zhong, bornpos, Quaternion.Euler(Vector3.zero));
        }
    }

    

}
