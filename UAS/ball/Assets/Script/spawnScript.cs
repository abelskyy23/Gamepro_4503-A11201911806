using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    float time = 0;
    float timer = 10;
    public GameObject obs;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(time<=0){
            Instantiate(obs,transform.position, Quaternion.identity);
            time = timer;
            Debug.Log("spawn");
        }
        else{
            time -= Time.deltaTime;
        }
    }
}
