using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerFish : MonoBehaviour {
    public static spawnerFish spnf;
    public float delay;
    public GameObject[] fish;
    public GameObject fish_to_respawn;
    int randomNo=0,result_list;
    float timer;
    float MaxPoY = 2f;
    float MinPoY = -3f;

	// Use this for initialization
	void Start () {
        
        timer = delay;
	}
    private void Awake()
    {
        spnf = this;
    }

    // Update is called once per frame
    public void Update() {
        float now = score.scoregame;
        if (delay > 2.5)
        {
            delay = (-now / 40) + 3;
        }
        else if (delay >1.8 )
        {
            delay = (-now / 50) + 3;
        }
        else 
        {
            delay = 1.7f;
        }
        
        int[] type_fish = whattheword(now);
        timer -= Time.deltaTime;
        if (timer <= 0) {
            randomNo = Random.Range(0, type_fish.Length);
            ///Debug.Log(randomNo);
            result_list = type_fish[randomNo];
            fish_to_respawn = fish[result_list];
            Vector3 position = new Vector3(transform.position.x,Random.Range(MaxPoY,MinPoY));
            Instantiate(fish[result_list], position, transform.rotation);
            timer = delay;
        }
	}
  
    static int[] whattheword(float sn)
    {
        if (sn < 10)
        {
            int[] walkaway = { 0 };
            return walkaway;
        }
        else if (sn < 20)
        {
            int[] walkaway = { 0, 0, 1 };
            return walkaway;

        }
        else if (sn < 35)
        {
            int[] walkaway = { 0, 0, 1, 1, 1, 2 };
            return walkaway;

        }
        else
        {
            int[] walkaway = { 1, 1, 2 };
            return walkaway;
        }

    }
}
