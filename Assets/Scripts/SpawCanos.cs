﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawCanos : MonoBehaviour
{
    public GameObject cano;

    public float altura;

    public float tempo_max;

    private float tempo;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject novoCano = Instantiate(cano);
        novoCano.transform.position = transform.position + new Vector3(0,Random.Range(-altura,altura),0);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(tempo > tempo_max){
            GameObject novoCano = Instantiate(cano);
            novoCano.transform.position = transform.position + new Vector3(0,Random.Range(-altura,altura),0);
            Destroy(novoCano,20f);
        }
        tempo += Time.deltaTime;
    }
}
