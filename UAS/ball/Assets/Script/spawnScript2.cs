using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript2 : MonoBehaviour
{
    float time = 0;
    float timer = 10;
    public GameObject mush;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(time<=0){
            Instantiate(mush,transform.position, Quaternion.identity);
            time = timer;
            Debug.Log("spawn");
        }
        else{
            time -= Time.deltaTime;
        }
    }
}
