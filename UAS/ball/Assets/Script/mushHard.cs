using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushHard: MonoBehaviour
{
    float nilaiRandom;
    void Start()
    {
        nilaiRandom = Random.Range(-4f, 4f);
        transform.position = new Vector2(transform.position.x, nilaiRandom);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Vector2.left*100 ,Time.deltaTime*15);
    }
}
