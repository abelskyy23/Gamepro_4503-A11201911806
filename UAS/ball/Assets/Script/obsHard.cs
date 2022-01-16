using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsHard : MonoBehaviour
{
    // Start is called before the first frame update
    float nilaiRandom;
    void Start()
    {
        nilaiRandom = Random.Range(-4.27f, -4.27f);
        transform.position = new Vector2(transform.position.x, nilaiRandom);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Vector2.left*100 ,Time.deltaTime*15);
    }
}
