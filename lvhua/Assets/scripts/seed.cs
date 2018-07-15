using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Seed___
{
    public int seed_style;
    public float shengzhang1;
    public float shengzhang2;
    public Sprite tree1;
    public Sprite tree2;
    public Sprite seed_img;

    public Vector3 daxiao_0;
    public Vector3 daxiao_1;
    public Vector3 daxiao_2;

    public float width_tree1;
    public float width_tree2;
}

public class seed : MonoBehaviour {



    

    public Seed___ seed_pr;
 
    public bool fall = true;
    public float life_time=0;
    public float speed;
    float kuandu = 1;
    public float width;
    SpriteRenderer ren;
    
	// Use this for initialization
	void Start () {
        ren = GetComponent<SpriteRenderer>();
        ren.sprite = seed_pr.seed_img;
        this.transform.localScale = seed_pr.daxiao_0;
        width = 1;
    }
	
	// Update is called once per frame
	void Update () {
        life_time += Time.deltaTime;
		if(fall)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y-speed*Time.deltaTime, this.transform.position.z);
        }
        if(life_time<10)
        {
            ren.sprite = seed_pr.seed_img;
            this.transform.localScale = seed_pr.daxiao_0;
            width = 1;
        }
        else if (life_time > 10&&life_time<25)
        {
            ren.sprite = seed_pr.tree1;
            this.transform.localScale = seed_pr.daxiao_1;
            width = seed_pr.width_tree1;
        }
        else if(life_time>25)
        {
            ren.sprite = seed_pr.tree2;
            this.transform.localScale = seed_pr.daxiao_2;
            width = seed_pr.width_tree2;
        }



        if(this.transform.position.y<-20)
        {
            Destroy(this.gameObject);
        }

    }
  
    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.gameObject.tag == "planet")
        {
           
            this.gameObject.transform.SetParent(other.gameObject.transform);
            fall = false;
        }
    }
    //private void OnCollisionEnter(Collision collision)
    //{

    //}
    //private void OnCollisionExit(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        collision.gameObject.transform.SetParent(null);
    //        collision.gameObject.transform.eulerAngles = Vector3.zero;
    //    }
    //}
}
