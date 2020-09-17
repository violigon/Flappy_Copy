using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class passaro : MonoBehaviour
{
    public float velocidade = 1f;
    private Rigidbody2D rig;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

        void Update()
    {
        if(Input.GetMouseButtonDown(0)){

            rig.velocity = Vector2.up * velocidade;

        }
    }
}
