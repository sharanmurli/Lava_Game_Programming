using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballgame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(1f, 1f, 1f)*Time.deltaTime;

        GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
        
    }
}
